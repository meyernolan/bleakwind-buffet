/*
 * Author: Nolan Meyer
 * Class name: Order.cs
 * Purpose: represents an Order
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Collections;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data;
using System.Linq;

namespace BleakwindBuffet.Data
{
    public class Order : ObservableCollection<IOrderItem> // ICollection<IOrderItem>, INotifyCollectionChanged, INotifyPropertyChanged
    {
        /// <summary>
        /// Constructor for an Order, initializes the Number and increments it.
        /// It also attatches CollectionChangedListener to CollectionChanged.
        /// </summary>
        public Order()
        {
            Number = nextOrderNumber;
            nextOrderNumber++;
            CollectionChanged += CollectionChangedListener;
        }

        /*
        public bool IsReadOnly =>  false;


        public void CopyTo(IOrderItem[] arr, int index)
        {
            orderItems.CopyTo(arr, index);
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return orderItems.GetEnumerator();
        }


        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }


        public bool Contains(IOrderItem item)
        {
            return orderItems.Contains(item);
        }


        public IEnumerator<IOrderItem> GetEnumerator()
        {
            return orderItems.GetEnumerator();
        }


        public int Count => orderItems.Count;


        public void Clear()
        {
            foreach(IOrderItem item in orderItems)
            {
                orderItems.Remove(item);
            }
            orderItems.Clear();
        }


        private List<IOrderItem> orderItems = new List<IOrderItem>();


        public event PropertyChangedEventHandler PropertyChanged;


        public event NotifyCollectionChangedEventHandler CollectionChanged;

        */

        /// <summary>
        /// Holds the value for the next order number.
        /// </summary>
        private static uint nextOrderNumber = 1;


        private uint number = 0;
        /// <summary>
        /// Property representing what order number this order is.
        /// </summary>
        public uint Number
        {
            get => number;
            set
            {
                number = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Number"));
            }
        }


        /// <summary>
        /// Adds an item to the collection.
        /// </summary>
        /// <param name="item">The item to add to the collection.</param>
        public new void Add(IOrderItem item)
        {
            ObservableCollection<IOrderItem> items = this;
            items.Add(item);
            var entree = this.OfType<Entree>().FirstOrDefault<Entree>();
            var side = this.OfType<Side>().FirstOrDefault<Side>();
            var drink = this.OfType<Drink>().FirstOrDefault<Drink>();
            if (entree != null && side != null && drink != null)
            {
                Remove(entree);
                Remove(side);
                Remove(drink);
                Combo newCombo = new Combo(entree, side, drink);
                Add(newCombo);
            }
        }
        
        /// <summary>
        /// Listener for when an item in the collection is changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CollectionItemChangedListener(object sender, PropertyChangedEventArgs e)
        {
            if(e.PropertyName == "Price")
            {
                OnPropertyChanged(new PropertyChangedEventArgs("Total"));
                OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
                OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
            }
            else if(e.PropertyName == "Calories")
            {
                OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
            }
        }

        /// <summary>
        /// Listener for when the collection changes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void CollectionChangedListener(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    foreach (IOrderItem item in e.NewItems)
                    {
                        item.PropertyChanged += CollectionItemChangedListener;
                    }
                    OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
                    OnPropertyChanged(new PropertyChangedEventArgs("Total"));
                    OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
                    OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
                    break;
                case NotifyCollectionChangedAction.Remove:
                    foreach(IOrderItem item in e.OldItems)
                    {
                        item.PropertyChanged -= CollectionItemChangedListener;
                    }
                    OnPropertyChanged(new PropertyChangedEventArgs("Subtotal"));
                    OnPropertyChanged(new PropertyChangedEventArgs("Total"));
                    OnPropertyChanged(new PropertyChangedEventArgs("Tax"));
                    OnPropertyChanged(new PropertyChangedEventArgs("Calories"));
                    break;
                case NotifyCollectionChangedAction.Reset:
                    throw new NotImplementedException("NotifyCollectionChangedAction.Reset not supported");
            }
        }


        /// <summary>
        /// Property for the sales tax rate.
        /// </summary>
        public double SalesTaxRate { get; set; } = 0.12;

        /// <summary>
        /// Property for the Subtotal price of the order.
        /// </summary>
        public double Subtotal
        {
            get
            {
                double subtotal = 0.00;
                foreach (IOrderItem item in this)
                {
                    subtotal += item.Price;
                }
                return subtotal;
            }
        }

        /// <summary>
        /// Property for the Total price of the order.
        /// </summary>
        public double Total
        {
            get => Subtotal+Tax;
        }

        /// <summary>
        /// Property for the tax on the order.
        /// </summary>
        public double Tax
        {
            get => Subtotal * SalesTaxRate;
        }

        /// <summary>
        /// Property for the Calories of the order.
        /// </summary>
        public uint Calories
        {
            get
            {
                uint calories = 0;
                foreach(IOrderItem item in this)
                {
                    calories += item.Calories;
                }
                return calories;
            }
        }
    }
}