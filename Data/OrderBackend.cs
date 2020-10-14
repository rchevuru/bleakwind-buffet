using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Collections.Specialized;
using System.Collections;

namespace BleakwindBuffet.Data
{
    public class OrderBackend : /*INotifyCollectionChanged,*/  INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
       // public event NotifyCollectionChangedEventHandler CollectionChanged;
        List<IOrderItem> list = new List<IOrderItem>(); 
        private double salesTaxRate = 0.12;
        private double subtotal = 0;
        private uint cal = 0;
        private int count = 0; 

        public double SalesTaxRate
        {
            get { return salesTaxRate; }

            set
            {
                salesTaxRate = value; 
            }
        }
       
        public double Subtotal {
            get 
            {
                return subtotal; 
            }
        }
        
        public int CountOrderNum
        {
           get { return count; } 
           set
            {
                if(count != value)
                {
                    count = value; 
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Count"));
                }
                
            }
        }

        private void calculateCal()
        {
            uint calCal = 0;
            foreach(IOrderItem item in list)
            {
                calCal += item.Calories; 
            }
            cal = calCal; 
        }

        private void calculateSubtotal()
        {
            double tempNum = 0; 
            foreach (IOrderItem item in list)
            {
                tempNum += item.Price;
            }
            subtotal = tempNum; 
          //  return subtotal;
        }
        

        public double Tax => Subtotal * SalesTaxRate;
        public double Total => Tax + Subtotal;

       /* public int Count => throw new NotImplementedException();

        public bool IsSynchronized => throw new NotImplementedException();

        public object SyncRoot => throw new NotImplementedException(); */

        public new void Add(IOrderItem item)
        {
            list.Add(item);
            calculateSubtotal();
            calculateCal(); 
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("list"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
        }

        public new void Remove(IOrderItem item)
        {
            list.Add(item);
            calculateSubtotal();
            calculateCal(); 
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("list"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
        }

       /* public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        } */
    }
}
