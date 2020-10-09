using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;


namespace BleakwindBuffet.Data
{
    class Combo : ObservableCollection<IOrderItem>, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        uint numTotalCal = 0;
        double numTotalprice = 0;
        private Drink drink;
        private Entree entree;
        private Side side; 

        public uint CountCal
        {
            get
            {
                foreach (IOrderItem item in this)
                {
                    numTotalCal += item.Calories;
                }
                return numTotalCal;
            }
        }

        public double CountPrice
        {
            get
            {
                foreach (IOrderItem item in this)
                {
                    numTotalprice += item.Price;
                }
                return numTotalprice - 1;
            }
        }

        public List<string> DisplaySpecialInstructions
        {
            get
            {
                List<string> list = new List<string>();
                foreach (IOrderItem item in this)
                {
                    list.Add(item.ToString()); 
                    list.AddRange(item.SpecialInstructions);
                }
                return list;
            }
        }
         
       public Drink Drink
        {
            get { return drink; }
            set 
            { 
                drink = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Drink"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            } 
        }

        public Entree Entree
        {
            get { return entree; }
            set
            {
                entree = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Entree"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        public Side Side 
        { 
            get { return side; }
            set
            {
                side = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Side"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }
    }
}
