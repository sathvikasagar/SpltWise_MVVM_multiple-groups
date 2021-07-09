using SplitWise_MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;

namespace SplitWise_MVVM.ViewModel
{
    public class SplitWiseViewModel : Person
    {
        public ObservableCollection<Person> _person { get; set; }

        public ObservableCollection<int> gcount { get; set; }

        public ICommand AddPerson { get; set; }

        public ICommand Calculate { get; set; }

        public ICommand AddNewGroup { get; set; }

        public ICommand RemoveGroup { get; set; }

        private Person itemSelected;

        public int gnumber = 0;
        public int count = 0;
        public int s;
        public int e;

        public SplitWiseViewModel() : base("", "", "",0)
        {
            this._person = new ObservableCollection<Person>();

            this.gcount = new ObservableCollection<int>();

            this.AddPerson = new RelayCommand(_addPerson, disableAdd);

            this.Calculate = new RelayCommand(_calculate);

            this.AddNewGroup = new RelayCommand(_newGroup);
        }

        public void CheckSelection()
        {
            if (this.itemSelected == null)
            {
                e = _person.Count;
                if (gcount.Count == 0)
                {
                    s = 0;
                }
                else
                {
                    s = gcount[gnumber - 1];
                }
            }
            else
            {
                int selectedGrpNumber = this.itemSelected.Gnumber;
                if (selectedGrpNumber == gcount.Count && selectedGrpNumber != 0)
                {
                    s = gcount[selectedGrpNumber - 1];
                    e = _person.Count;
                }
                else if (selectedGrpNumber == 0 && gcount.Count!=0)
                {
                    s = 0;
                    e = gcount[0];
                }
                else if (selectedGrpNumber == 0 && gcount.Count == 0)
                {
                    s = 0;
                    e = _person.Count;
                }
                else
                {
                    s = gcount[selectedGrpNumber - 1];
                    e = gcount[selectedGrpNumber];
                }
            }
        }

        public void _addPerson(object parameter)
        {
            if (Spent == "" && Share == "")
            {
                MessageBox.Show("plese enter amount spent and share");
            }
            else if (Spent == "" || Share == "")
            {
                if (Spent == "")
                {
                    MessageBox.Show("plese enter amount spent");
                }
                else if (Share == "")
                {
                    MessageBox.Show("plese enter share");
                }
            }
            else
            {
                _person.Add(new Person(Name, Spent, Share,gnumber));
                count++;
                Name = "";
                Spent = "";
                Share = "";
            }
        }
        public bool disableAdd(object parameter)
        {
            if (Name == "")
            {
                return false;
            }
            return true;
        }

        public void _calculate(object parameter)
        {
            CheckSelection();
            var output = new List<string>();

            float totalShare = 0;
            float totalAmount = 0;
            for (int i = s; i < e; i++)
            {
                if(_person[i].Name=="")
                {
                    break;
                }
                totalAmount += float.Parse(_person[i].Spent);
                totalShare += float.Parse(_person[i].Share);
            }
            if (totalShare == 100)
            {
                for (int i = s; i < e; i++)
                {
                    if (_person[i].Name == "")
                    {
                        break;
                    }
                    float toBeRecieved = (float.Parse(_person[i].Spent) - (totalAmount * float.Parse(_person[i].Share)) / 100);
                    string message = "";
                    if (toBeRecieved < 0)
                    {
                        message = _person[i].Name + " should pay " + Math.Abs(toBeRecieved).ToString();
                    }
                    else
                    {
                        message = _person[i].Name + " should recieve " + Math.Abs(toBeRecieved).ToString();
                    }
                    output.Add(message);
                }
                var op = string.Join(Environment.NewLine, output);
                MessageBox.Show(op);
            }
            else
            {
                MessageBox.Show("Total sum of share percentage should be equal to 100 per group");
            }
        }

        public void _newGroup(object parameter)
        {
            _person.Add(new Person("", "", "", gnumber));
            count++;
            gcount.Add(count);
            gnumber++;
        }

        public Person ItemSelected
        {
            get
            {
                return itemSelected;
            }
            set
            {
                this.itemSelected = value;
            }
        }
        
    }
}
