using RoundRegister;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PointOfSale
{
    public class RegisterViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;


        CashRegisterControl currencyControl = new CashRegisterControl();


        public RegisterViewModel()
        {
            currencyControl.Show();
        }
    }
}
