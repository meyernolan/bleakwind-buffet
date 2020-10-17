/*
 * Author: Nolan Meyer
 * Class name: RegisterViewModel.xaml.cs
 * Purpose: Class used as the ViewModel for the Cash Register.
 */
using RoundRegister;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data;
using System.Windows;
using System.Diagnostics;

namespace BleakwindBuffet.Data
{
    public class RegisterViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// The propertyChanged event handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Method for taking the cash from the customer and putting it in the register.
        /// It also takes out the change given to the customer.
        /// </summary>
        public void CashOut()
        {
            CashDrawer.OpenDrawer();
            CashDrawer.Hundreds += CustomerHundreds;
            CashDrawer.Fifties += CustomerFifties;
            CashDrawer.Twenties += CustomerTwenties;
            CashDrawer.Tens += CustomerTens;
            CashDrawer.Fives += CustomerFives;
            CashDrawer.Twos += CustomerTwos;
            CashDrawer.Ones += CustomerOnes;
            CashDrawer.Dollars += CustomerDollarCoins;
            CashDrawer.HalfDollars += CustomerFiftyCents;
            CashDrawer.Quarters += CustomerQuarters;
            CashDrawer.Dimes += CustomerDimes;
            CashDrawer.Nickels += CustomerNickels;
            CashDrawer.Pennies += CustomerPennies;

            CashDrawer.Hundreds -= ChangeHundreds;
            CashDrawer.Fifties -= ChangeFifties;
            CashDrawer.Twenties -= ChangeTwenties;
            CashDrawer.Tens -= ChangeTens;
            CashDrawer.Fives -= ChangeFives;
            CashDrawer.Twos -= ChangeTwos;
            CashDrawer.Ones -= ChangeOnes;
            CashDrawer.Dollars -= ChangeDollarCoins;
            CashDrawer.HalfDollars -= ChangeFiftyCents;
            CashDrawer.Quarters -= ChangeQuarters;
            CashDrawer.Dimes -= ChangeDimes;
            CashDrawer.Nickels -= ChangeNickels;
            CashDrawer.Pennies -= ChangePennies;
        }
         
        /// <summary>
        /// Logic for calculating the amount of change and what kind of change to give.
        /// </summary>
        public void MakeChange()
        {
            
            ChangeHundreds = 0;
            ChangeFifties = 0;
            ChangeTwenties = 0;
            ChangeTens = 0;
            ChangeFives = 0;
            ChangeTwos = 0;
            ChangeOnes = 0;
            ChangeDollarCoins = 0;
            ChangeFiftyCents = 0;
            ChangeQuarters = 0;
            ChangeDimes = 0;
            ChangeNickels = 0;
            ChangePennies = 0;

            while (Math.Round(AmountDue, 2) < 0.00)
            {
                double amountDue = Math.Round(AmountDue, 2);
                if(Hundreds > 0 && ChangeHundreds < Hundreds && -amountDue >= 100)
                {
                    ChangeHundreds++;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeHundreds"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                }
                else if (Fifties > 0 && ChangeFifties < Fifties && -amountDue >= 50)
                {
                    ChangeFifties++;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeFifties"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                }
                else if (Twenties > 0 && ChangeTwenties < Twenties && -amountDue >= 20)
                {
                    ChangeTwenties++;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTwenties"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                }
                else if (Tens > 0 && ChangeTens < Tens && -amountDue >= 10)
                {
                    ChangeTens++;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTens"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                }
                else if (Fives > 0 && ChangeFives < Fives && -amountDue >= 5)
                {
                    ChangeFives++;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeFives"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                }
                else if (Twos > 0 && ChangeTwos < Twos && -amountDue >= 2)
                {
                    ChangeTwos++;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTwos"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                }
                else if (Ones > 0 && ChangeOnes < Ones && -amountDue >= 1)
                {
                    ChangeOnes++;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOnes"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                }
                else if (DollarCoins > 0 && ChangeDollarCoins < DollarCoins && -amountDue >= 1)
                {
                    ChangeDollarCoins++;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDollarCoins"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                }
                else if (FiftyCents > 0 && ChangeFiftyCents < FiftyCents && -amountDue >= 0.50)
                {
                    ChangeFiftyCents++;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeFiftyCents"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                }
                else if (Quarters > 0 && ChangeQuarters < Quarters && -amountDue >= 0.25)
                {
                    ChangeQuarters++;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeQuarters"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                }
                else if (Dimes > 0 && ChangeDimes < Dimes && -amountDue >= 0.10)
                {
                    ChangeDimes++;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDimes"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                }
                else if (Nickels > 0 && ChangeNickels < Nickels && -amountDue >= 0.05)
                {
                    ChangeNickels++;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeNickels"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                }
                else if (Pennies > 0 && ChangePennies < Pennies && -amountDue >= 0.01)
                {
                    ChangePennies++;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangePennies"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                }
                else
                {
                    break;
                }
            }
        }


        private int hundreds = RoundRegister.CashDrawer.Hundreds;
        /// <summary>
        /// Property holding the amount of Hundreds in the Cash Drawer
        /// </summary>
        public int Hundreds
        {
            get => hundreds;
        }

        private int fifties = RoundRegister.CashDrawer.Fifties;
        /// <summary>
        /// Property holding the amount of Hundreds in the Cash Drawer
        /// </summary>
        public int Fifties
        {
            get => fifties;
        }


        private int twenties = RoundRegister.CashDrawer.Twenties;
        /// <summary>
        /// Property holding the amount of Twenties in the Cash Drawer
        /// </summary>
        public int Twenties
        {
            get => twenties;
        }

        private int tens = RoundRegister.CashDrawer.Tens;
        /// <summary>
        /// Property holding the amount of Tens in the Cash Drawer
        /// </summary>
        public int Tens
        {
            get => tens;
        }

        private int fives = RoundRegister.CashDrawer.Fives;
        /// <summary>
        /// Property holding the amount of Fives in the Cash Drawer
        /// </summary>
        public int Fives
        {
            get => fives;
        }

        private int twos = RoundRegister.CashDrawer.Twos;
        /// <summary>
        /// Property holding the amount of Twos in the Cash Drawer
        /// </summary>
        public int Twos
        {
            get => twos;
        }

        private int ones = RoundRegister.CashDrawer.Ones;
        /// <summary>
        /// Property holding the amount of Ones in the Cash Drawer
        /// </summary>
        public int Ones
        {
            get => ones;
        }

        private int dollarCoins = RoundRegister.CashDrawer.Dollars;
        /// <summary>
        /// Property holding the amount of DollarCoins in the Cash Drawer
        /// </summary>
        public int DollarCoins
        {
            get => dollarCoins;
        }

        private int fiftyCents = RoundRegister.CashDrawer.HalfDollars;
        /// <summary>
        /// Property holding the amount of HalfDollars in the Cash Drawer
        /// </summary>
        public int FiftyCents
        {
            get => fiftyCents;
        }

        private int quarters = RoundRegister.CashDrawer.Quarters;
        /// <summary>
        /// Property holding the amount of Quarters in the Cash Drawer
        /// </summary>
        public int Quarters
        {
            get => quarters;
        }

        private int dimes = RoundRegister.CashDrawer.Dimes;
        /// <summary>
        /// Property holding the amount of Dimes in the Cash Drawer
        /// </summary>
        public int Dimes
        {
            get => dimes;
        }

        private int nickels = RoundRegister.CashDrawer.Nickels;
        /// <summary>
        /// Property holding the amount of Nickels in the Cash Drawer
        /// </summary>
        public int Nickels
        {
            get => nickels;
        }

        private int pennies = RoundRegister.CashDrawer.Pennies;
        /// <summary>
        /// Property holding the amount of Pennies in the Cash Drawer
        /// </summary>
        public int Pennies
        {
            get => pennies;
        }


        private double totalInDrawer = RoundRegister.CashDrawer.Total;
        /// <summary>
        /// Property holding the amount of TotalInDrawer in the Cash Drawer
        /// </summary>
        public double TotalInDrawer
        {
            get => totalInDrawer;
        }


        private int customerHundreds = 0;
        /// <summary>
        /// Property holding the amount of Hundreds the customer gives
        /// </summary>
        public int CustomerHundreds
        {
            get => customerHundreds;
            set
            {
                if(value >= 0)
                {
                    customerHundreds = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerHundreds"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerTotal"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                    MakeChange();
                }
            }
        }

        private int customerFifties = 0;
        /// <summary>
        /// Property holding the amount of Fifties the customer gives
        /// </summary>
        public int CustomerFifties
        {
            get => customerFifties;
            set
            {
                if (value >= 0)
                {
                    customerFifties = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerFifties"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerTotal"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                    MakeChange();
                }
            }
        }

        private int customerTwenties = 0;
        /// <summary>
        /// Property holding the amount of Twenties the customer gives
        /// </summary>
        public int CustomerTwenties
        {
            get => customerTwenties;
            set
            {
                if (value >= 0)
                {
                    customerTwenties = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerTwenties"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerTotal"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                    MakeChange();
                }
            }
        }

        private int customerTens = 0;
        /// <summary>
        /// Property holding the amount of Tens the customer gives
        /// </summary>
        public int CustomerTens
        {
            get => customerTens;
            set
            {
                if (value >= 0)
                {
                    customerTens = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerTens"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerTotal"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                    MakeChange();
                }
            }
        }

        private int customerFives = 0;
        /// <summary>
        /// Property holding the amount of Fives the customer gives
        /// </summary>
        public int CustomerFives
        {
            get => customerFives;
            set
            {
                if (value >= 0)
                {
                    customerFives = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerFives"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerTotal"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                    MakeChange();
                }
            }
        }

        private int customerTwos = 0;
        /// <summary>
        /// Property holding the amount of Twos the customer gives
        /// </summary>
        public int CustomerTwos
        {
            get => customerTwos;
            set
            {
                if (value >= 0)
                {
                    customerTwos = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerTwos"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerTotal"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                    MakeChange();

                }
            }
        }

        private int customerOnes = 0;
        /// <summary>
        /// Property holding the amount of Ones the customer gives
        /// </summary>
        public int CustomerOnes
        {
            get => customerOnes;
            set
            {
                if (value >= 0)
                {
                    customerOnes = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerOnes"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerTotal"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                    MakeChange();

                }
            }
        }

        private int customerDollarCoins = 0;
        /// <summary>
        /// Property holding the amount of DollarCoins the customer gives
        /// </summary>
        public int CustomerDollarCoins
        {
            get => customerDollarCoins;
            set
            {
                if (value >= 0)
                {

                    customerDollarCoins = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerDollarCoins"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerTotal"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                    MakeChange();
                }
            }
        }

        private int customerFiftyCents = 0;
        /// <summary>
        /// Property holding the amount of FiftyCents the customer gives
        /// </summary>
        public int CustomerFiftyCents
        {
            get => customerFiftyCents;
            set
            {
                if (value >= 0)
                {
                    customerFiftyCents = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerFiftyCents"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerTotal"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                    MakeChange();
                }
            }
        }

        private int customerQuarters = 0;
        /// <summary>
        /// Property holding the amount of Quarters the customer gives
        /// </summary>
        public int CustomerQuarters
        {
            get => customerQuarters;
            set
            {
                if (value >= 0)
                {
                    customerQuarters = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerQuarters"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerTotal"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                    MakeChange();

                }
            }
        }

        private int customerDimes = 0;
        /// <summary>
        /// Property holding the amount of Dimes the customer gives
        /// </summary>
        public int CustomerDimes
        {
            get => customerDimes;
            set
            {
                if (value >= 0)
                {
                    customerDimes = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerDimes"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerTotal"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                    MakeChange();

                }
            }
        }

        private int customerNickels = 0;
        /// <summary>
        /// Property holding the amount of Nickels the customer gives
        /// </summary>
        public int CustomerNickels
        {
            get => customerNickels;
            set
            {
                if (value >= 0)
                {
                    customerNickels = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerNickels"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerTotal"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                    MakeChange();
                }
            }
        }

        private int customerPennies = 0;
        /// <summary>
        /// Property holding the amount of Pennies the customer gives
        /// </summary>
        public int CustomerPennies
        {
            get => customerPennies;
            set
            {
                if (value >= 0)
                {
                    customerPennies = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerPennies"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CustomerTotal"));
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
                    MakeChange();
                }
            }
        }

        /// <summary>
        /// The total amount the customer gives
        /// </summary>
        public double CustomerTotal
        {
            get => CustomerHundreds * 100 + CustomerFifties * 50 + CustomerTwenties * 20 + CustomerTens * 10 + CustomerFives * 5 + CustomerTwos * 2 +
                customerOnes + CustomerDollarCoins + CustomerFiftyCents * 0.5 + CustomerQuarters * 0.25 + CustomerDimes * 0.1 + CustomerNickels * 0.05 + CustomerPennies * 0.01;
        }


        private int changeHundreds = 0;
        /// <summary>
        /// Property holding the amount of Hundreds given in change
        /// </summary>
        public int ChangeHundreds
        {
            get => changeHundreds;
            set
            {
                changeHundreds = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeHundreds"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
            }
        }

        private int changeFifties = 0;
        /// <summary>
        /// Property holding the amount of Fifties given in change
        /// </summary>
        public int ChangeFifties
        {
            get => changeFifties;
            set
            {
                changeFifties = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeFifties"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
            }
        }

        private int changeTwenties = 0;
        /// <summary>
        /// Property holding the amount of Twenties given in change
        /// </summary>
        public int ChangeTwenties
        {
            get => changeTwenties;
            set
            {
                changeTwenties = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTwenties"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
            }
        }

        private int changeTens = 0;
        /// <summary>
        /// Property holding the amount of Tens given in change
        /// </summary>
        public int ChangeTens
        {
            get => changeTens;
            set
            {
                changeTens = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTens"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
            }
        }

        private int changeFives = 0;
        /// <summary>
        /// Property holding the amount of Fives given in change
        /// </summary>
        public int ChangeFives
        {
            get => changeFives;
            set
            {
                changeFives = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeFives"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
            }
        }

        private int changeTwos = 0;
        /// <summary>
        /// Property holding the amount of Twos given in change
        /// </summary>
        public int ChangeTwos
        {
            get => changeTwos;
            set
            {
                changeTwos = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTwos"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
            }
        }

        private int changeOnes = 0;
        /// <summary>
        /// Property holding the amount of Ones given in change
        /// </summary>
        public int ChangeOnes
        {
            get => changeOnes;
            set
            {
                changeOnes = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeOnes"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
            }
        }

        private int changeDollarCoins = 0;
        /// <summary>
        /// Property holding the amount of DollarCoins given in change
        /// </summary>
        public int ChangeDollarCoins
        {
            get => changeDollarCoins;
            set
            {
                changeDollarCoins = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDollarCoins"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
            }
        }

        private int changeFiftyCents = 0;
        /// <summary>
        /// Property holding the amount of FiftyCents given in change
        /// </summary>
        public int ChangeFiftyCents
        {
            get => changeFiftyCents;
            set
            {
                changeFiftyCents = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeFiftyCents"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
            }
        }

        private int changeQuarters = 0;
        /// <summary>
        /// Property holding the amount of Quarters given in change
        /// </summary>
        public int ChangeQuarters
        {
            get => changeQuarters;
            set
            {
                changeQuarters = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeQuarters"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
            }
        }

        private int changeDimes = 0;
        /// <summary>
        /// Property holding the amount of Dimes given in change
        /// </summary>
        public int ChangeDimes
        {
            get => changeDimes;
            set
            {
                changeDimes = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeDimes"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
            }
        }

        private int changeNickels = 0;
        /// <summary>
        /// Property holding the amount of Nickels given in change
        /// </summary>
        public int ChangeNickels
        {
            get => changeNickels;
            set
            {
                changeNickels = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeNickels"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
            }
        }

        private int changePennies = 0;
        /// <summary>
        /// Property holding the amount of Pennies given in change
        /// </summary>
        public int ChangePennies
        {
            get => changePennies;
            set
            {
                changePennies = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangePennies"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ChangeTotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("AmountDue"));
            }
        }

        /// <summary>
        /// Total change to be given to the customer.
        /// </summary>
        public double ChangeTotal
        {
            get => ChangeHundreds * 100 + ChangeFifties * 50 + ChangeTwenties * 20 + ChangeTens * 10 + ChangeFives * 5 + ChangeTwos * 2 +
                ChangeOnes + ChangeDollarCoins + ChangeFiftyCents * 0.5 + ChangeQuarters * 0.25 + ChangeDimes * 0.1 + ChangeNickels * 0.05 + ChangePennies * 0.01;
        }

        /// <summary>
        /// The amount of money due to the customer in change.
        /// </summary>
        public double AmountDue
        {
            get => order.Total - CustomerTotal + ChangeTotal;
        }

        /// <summary>
        /// The order total.
        /// </summary>
        public double OrderTotal
        {
            get => order.Total;
        }

        /// <summary>
        /// Method for other classes to call property changed
        /// </summary>
        /// <param name="str"></param>
        public void OnPropertyChanged(string str)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(str));
        }

        //CashRegisterControl register = new CashRegisterControl();

        Order order;

        /// <summary>
        /// Initializes the RegisterViewModel and sets the order to the current Order.
        /// </summary>
        /// <param name="o"></param>
        public RegisterViewModel(Order o)
        {
            order = o;
        }
        
    }
}
