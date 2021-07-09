using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SplitWise_MVVM.Model
{
    public class Person : INotifyPropertyChanged
    {
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                RaisePropertyChange("Name");
            }
        }

        private string spent;
        public string Spent
        {
            get { return spent; }
            set
            {
                spent = value;
                RaisePropertyChange("Spent");
            }
        }

        private string share;
        public string Share
        {
            get { return share; }
            set
            {
                share = value;
                RaisePropertyChange("Share");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChange(string propertyname)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyname));
            }
        }

        public int Gnumber;

        public Person(string name, string spent, string share,int gnumber)
        {
            this.Name = name;
            this.Spent = spent;
            this.Share = share;
            this.Gnumber = gnumber;
        }
    }
}
