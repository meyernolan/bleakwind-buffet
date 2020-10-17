using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Enums;
using System.Data;
using System.Linq;
using RoundRegister;

namespace BleakwindBuffet.DataTests.UnitTests
{
    public class RegisterViewModelTests
    {
        [Fact]
        public void HundredsGetsAmountOfHundredsInTheCashDrawer()
        {
            CashDrawer.ResetDrawer();
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.Equal(register.Hundreds, CashDrawer.Hundreds);
        }

        [Fact]
        public void FiftiesGetsAmountOfFiftiesInTheCashDrawer()
        {
            CashDrawer.ResetDrawer();
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.Equal(register.Fifties, CashDrawer.Fifties);
        }

        [Fact]
        public void TwentiesGetsAmountOfTwentiesInThedrawer()
        {
            CashDrawer.ResetDrawer();
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.Equal(register.Twenties, CashDrawer.Twenties);
        }

        [Fact]
        public void TensGetsAmountOfTensInTheCashDrawer()
        {
            CashDrawer.ResetDrawer();
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.Equal(register.Tens, CashDrawer.Tens);
        }

        [Fact]
        public void FivesGetsAmountOfFivesInTheCashDrawer()
        {
            CashDrawer.ResetDrawer();
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.Equal(register.Fives, CashDrawer.Fives);
        }

        [Fact]
        public void TwosGetsAmountOfTwosInTheCashDrawer()
        {
            CashDrawer.ResetDrawer();
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.Equal(register.Twos, CashDrawer.Twos);
        }

        [Fact]
        public void OnesGetsAmountOfOnesInTheCashDrawer()
        {
            CashDrawer.ResetDrawer();
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.Equal(register.Ones, CashDrawer.Ones);
        }

        [Fact]
        public void DollarCoinsGetsAmountOfDollarsInTheCashDrawer()
        {
            CashDrawer.ResetDrawer();
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.Equal(register.DollarCoins, CashDrawer.Dollars);
        }

        [Fact]
        public void FiftyCentsGetsAmountOfHalfDollarsInTheCashDrawer()
        {
            CashDrawer.ResetDrawer();
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.Equal(register.FiftyCents, CashDrawer.HalfDollars);
        }

        [Fact]
        public void QuartersGetsAmountOfQuartersInTheCashDrawer()
        {
            CashDrawer.ResetDrawer();
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.Equal(register.Quarters, CashDrawer.Quarters);
        }

        [Fact]
        public void DimesGetsAmountOfDimesInTheCashDrawer()
        {
            CashDrawer.ResetDrawer();
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.Equal(register.Dimes, CashDrawer.Dimes);
        }


        [Fact]
        public void NickelsGetsAmountOfNickelsInTheCashDrawer()
        {
            CashDrawer.ResetDrawer();
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.Equal(register.Nickels, CashDrawer.Nickels);
        }

        [Fact]
        public void PenniesGetsAmountOfPenniesInTheCashDrawer()
        {
            CashDrawer.ResetDrawer();
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.Equal(register.Pennies, CashDrawer.Pennies);
        }

        [Fact]
        public void CustomerHundredsGetsTheAmountOfHundredsCustomerGives()
        {
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.Equal(0, register.CustomerHundreds);
        }

        [Fact]
        public void CustomerFiftiesGetsTheAmountOfFiftiesCustomerGives()
        {
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.Equal(0, register.CustomerFifties);
        }

        [Fact]
        public void CustomerTwentiesGetsTheAmountOfTwentiesCustomerGives()
        {
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.Equal(0, register.CustomerTwenties);
        }

        [Fact]
        public void CustomerTensGetsTheAmountOfTensCustomerGives()
        {
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.Equal(0, register.CustomerTens);
        }

        [Fact]
        public void CustomerFivesGetsTheAmountOfFivesCustomerGives()
        {
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.Equal(0, register.CustomerFives);
        }

        [Fact]
        public void CustomerTwosGetsTheAmountOfTwosCustomerGives()
        {
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.Equal(0, register.CustomerTwos);
        }

        [Fact]
        public void CustomerOnesGetsTheAmountOfOnesCustomerGives()
        {
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.Equal(0, register.CustomerOnes);
        }

        [Fact]
        public void CustomerDollarCoinsGetsTheAmountOfDollarCoinsCustomerGives()
        {
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.Equal(0, register.CustomerDollarCoins);
        }

        [Fact]
        public void CustomerFiftyCentsGetsTheAmountOfHalfDollarsCustomerGives()
        {
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.Equal(0, register.CustomerFiftyCents);
        }

        [Fact]
        public void CustomerQuartersGetsTheAmountOfQuartersCustomerGives()
        {
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.Equal(0, register.CustomerQuarters);
        }

        [Fact]
        public void CustomerDimesGetsTheAmountOfDimesCustomerGives()
        {
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.Equal(0, register.CustomerDimes);
        }

        [Fact]
        public void CustomerNickelsGetsTheAmountOfNickelsCustomerGives()
        {
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.Equal(0, register.CustomerNickels);
        }

        [Fact]
        public void CustomerPenniesGetsTheAmountOfPenniesCustomerGives()
        {
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.Equal(0, register.CustomerPennies);
        }

        [Fact]
        public void CustomerTotalShouldReturnTotalCustomerIsGiving()
        {
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.Equal(0, register.CustomerTotal);
        }

        [Fact]
        public void AmountDueShouldReturnTheAmountTheCustomerOwes()
        {
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.Equal(order.Total - register.CustomerTotal + register.ChangeTotal, register.AmountDue);
        }

        [Fact]
        public void OrderTotalShouldReturnTheOrderTotal()
        {
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.Equal(order.Total, register.OrderTotal);
        }

        [Fact]
        public void ChangingCustomerHundredsNotifiesCustomerHundredsCustomerTotalAndAmountDue()
        {
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.PropertyChanged(register, "CustomerHundreds", () =>
            {
                register.CustomerHundreds++;
            });
            Assert.PropertyChanged(register, "CustomerTotal", () =>
            {
                register.CustomerHundreds++;
            });
            Assert.PropertyChanged(register, "AmountDue", () =>
            {
                register.CustomerHundreds++;
            });
        }

        [Fact]
        public void ChangingCustomerFiftiesNotifiesCustomerFiftiesCustomerTotalAndAmountDue()
        {
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.PropertyChanged(register, "CustomerFIfties", () =>
            {
                register.CustomerFifties++;
            });
            Assert.PropertyChanged(register, "CustomerTotal", () =>
            {
                register.CustomerFifties++;
            });
            Assert.PropertyChanged(register, "AmountDue", () =>
            {
                register.CustomerFifties++;
            });
        }

        [Fact]
        public void ChangingCustomerTwentiesNotifiesCustomerTwentiesCustomerTotalAndAmountDue()
        {
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.PropertyChanged(register, "CustomerTwenties", () =>
            {
                register.CustomerTwenties++;
            });
            Assert.PropertyChanged(register, "CustomerTotal", () =>
            {
                register.CustomerTwenties++;
            });
            Assert.PropertyChanged(register, "AmountDue", () =>
            {
                register.CustomerTwenties++;
            });
        }

        [Fact]
        public void ChangingCustomerTensNotifiesCustomerTensCustomerTotalAndAmountDue()
        {
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.PropertyChanged(register, "CustomerTens", () =>
            {
                register.CustomerTens++;
            });
            Assert.PropertyChanged(register, "CustomerTotal", () =>
            {
                register.CustomerTens++;
            });
            Assert.PropertyChanged(register, "AmountDue", () =>
            {
                register.CustomerTens++;
            });
        }

        [Fact]
        public void ChangingCustomerFivesNotifiesCustomerFivesCustomerTotalAndAmountDue()
        {
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.PropertyChanged(register, "CustomerFives", () =>
            {
                register.CustomerFives++;
            });
            Assert.PropertyChanged(register, "CustomerTotal", () =>
            {
                register.CustomerFives++;
            });
            Assert.PropertyChanged(register, "AmountDue", () =>
            {
                register.CustomerFives++;
            });
        }

        [Fact]
        public void ChangingCustomerTwosNotifiesCustomerTwosCustomerTotalAndAmountDue()
        {
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.PropertyChanged(register, "CustomerTwos", () =>
            {
                register.CustomerTwos++;
            });
            Assert.PropertyChanged(register, "CustomerTotal", () =>
            {
                register.CustomerTwos++;
            });
            Assert.PropertyChanged(register, "AmountDue", () =>
            {
                register.CustomerTwos++;
            });
        }

        [Fact]
        public void ChangingCustomerOnesNotifiesCustomerOnesCustomerTotalAndAmountDue()
        {
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.PropertyChanged(register, "CustomerOnes", () =>
            {
                register.CustomerOnes++;
            });
            Assert.PropertyChanged(register, "CustomerTotal", () =>
            {
                register.CustomerOnes++;
            });
            Assert.PropertyChanged(register, "AmountDue", () =>
            {
                register.CustomerOnes++;
            });
        }

        [Fact]
        public void ChangingCustomerFiftyCentsNotifiesCustomerFiftyCentsCustomerTotalAndAmountDue()
        {
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.PropertyChanged(register, "CustomerFiftyCents", () =>
            {
                register.CustomerFiftyCents++;
            });
            Assert.PropertyChanged(register, "CustomerTotal", () =>
            {
                register.CustomerFiftyCents++;
            });
            Assert.PropertyChanged(register, "AmountDue", () =>
            {
                register.CustomerFiftyCents++;
            });
        }

        [Fact]
        public void ChangingCustomerDollarCoinsNotifiesCustomerDollarCoinsCustomerTotalAndAmountDue()
        {
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.PropertyChanged(register, "CustomerDollarCoins", () =>
            {
                register.CustomerDollarCoins++;
            });
            Assert.PropertyChanged(register, "CustomerTotal", () =>
            {
                register.CustomerDollarCoins++;
            });
            Assert.PropertyChanged(register, "AmountDue", () =>
            {
                register.CustomerDollarCoins++;
            });
        }

        [Fact]
        public void ChangingCustomerQuartersNotifiesCustomerQuartersCustomerTotalAndAmountDue()
        {
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.PropertyChanged(register, "CustomerQuarters", () =>
            {
                register.CustomerQuarters++;
            });
            Assert.PropertyChanged(register, "CustomerTotal", () =>
            {
                register.CustomerQuarters++;
            });
            Assert.PropertyChanged(register, "AmountDue", () =>
            {
                register.CustomerQuarters++;
            });
        }

        [Fact]
        public void ChangingCustomerDimesNotifiesCustomerDimesCustomerTotalAndAmountDue()
        {
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.PropertyChanged(register, "CustomerDimes", () =>
            {
                register.CustomerDimes++;
            });
            Assert.PropertyChanged(register, "CustomerTotal", () =>
            {
                register.CustomerDimes++;
            });
            Assert.PropertyChanged(register, "AmountDue", () =>
            {
                register.CustomerDimes++;
            });
        }

        [Fact]
        public void ChangingCustomerNickelsNotifiesCustomerNickelsCustomerTotalAndAmountDue()
        {
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.PropertyChanged(register, "CustomerNickels", () =>
            {
                register.CustomerNickels++;
            });
            Assert.PropertyChanged(register, "CustomerTotal", () =>
            {
                register.CustomerNickels++;
            });
            Assert.PropertyChanged(register, "AmountDue", () =>
            {
                register.CustomerNickels++;
            });
        }

        [Fact]
        public void ChangingCustomerPenniesNotifiesCustomerPenniesCustomerTotalAndAmountDue()
        {
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.PropertyChanged(register, "CustomerPennies", () =>
            {
                register.CustomerPennies++;
            });
            Assert.PropertyChanged(register, "CustomerTotal", () =>
            {
                register.CustomerPennies++;
            });
            Assert.PropertyChanged(register, "AmountDue", () =>
            {
                register.CustomerPennies++;
            });
        }

        [Fact]
        public void ChangingChangeHundredsNotifiesChangeHundredsChangeTotalAndAmountDue()
        {
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.PropertyChanged(register, "ChangeHundreds", () =>
            {
                register.ChangeHundreds++;
            });
            Assert.PropertyChanged(register, "ChangeTotal", () =>
            {
                register.ChangeHundreds++;
            });
            Assert.PropertyChanged(register, "AmountDue", () =>
            {
                register.ChangeHundreds++;
            });
        }

        [Fact]
        public void ChangingChangeFiftiesNotifiesChangeFiftiesChangeTotalAndAmountDue()
        {
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.PropertyChanged(register, "ChangeFIfties", () =>
            {
                register.ChangeFifties++;
            });
            Assert.PropertyChanged(register, "ChangeTotal", () =>
            {
                register.ChangeFifties++;
            });
            Assert.PropertyChanged(register, "AmountDue", () =>
            {
                register.ChangeFifties++;
            });
        }

        [Fact]
        public void ChangingChangeTwentiesNotifiesChangeTwentiesChangeTotalAndAmountDue()
        {
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.PropertyChanged(register, "ChangeTwenties", () =>
            {
                register.ChangeTwenties++;
            });
            Assert.PropertyChanged(register, "ChangeTotal", () =>
            {
                register.ChangeTwenties++;
            });
            Assert.PropertyChanged(register, "AmountDue", () =>
            {
                register.ChangeTwenties++;
            });
        }

        [Fact]
        public void ChangingChangeTensNotifiesChangeTensChangeTotalAndAmountDue()
        {
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.PropertyChanged(register, "ChangeTens", () =>
            {
                register.ChangeTens++;
            });
            Assert.PropertyChanged(register, "ChangeTotal", () =>
            {
                register.ChangeTens++;
            });
            Assert.PropertyChanged(register, "AmountDue", () =>
            {
                register.ChangeTens++;
            });
        }

        [Fact]
        public void ChangingChangeFivesNotifiesChangeFivesChangeTotalAndAmountDue()
        {
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.PropertyChanged(register, "ChangeFives", () =>
            {
                register.ChangeFives++;
            });
            Assert.PropertyChanged(register, "ChangeTotal", () =>
            {
                register.ChangeFives++;
            });
            Assert.PropertyChanged(register, "AmountDue", () =>
            {
                register.ChangeFives++;
            });
        }

        [Fact]
        public void ChangingChangeTwosNotifiesChangeTwosChangeTotalAndAmountDue()
        {
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.PropertyChanged(register, "ChangeTwos", () =>
            {
                register.ChangeTwos++;
            });
            Assert.PropertyChanged(register, "ChangeTotal", () =>
            {
                register.ChangeTwos++;
            });
            Assert.PropertyChanged(register, "AmountDue", () =>
            {
                register.ChangeTwos++;
            });
        }

        [Fact]
        public void ChangingChangeOnesNotifiesChangeOnesChangeTotalAndAmountDue()
        {
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.PropertyChanged(register, "ChangeOnes", () =>
            {
                register.ChangeOnes++;
            });
            Assert.PropertyChanged(register, "ChangeTotal", () =>
            {
                register.ChangeOnes++;
            });
            Assert.PropertyChanged(register, "AmountDue", () =>
            {
                register.ChangeOnes++;
            });
        }

        [Fact]
        public void ChangingChangeFiftyCentsNotifiesChangeFiftyCentsChangeTotalAndAmountDue()
        {
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.PropertyChanged(register, "ChangeFiftyCents", () =>
            {
                register.ChangeFiftyCents++;
            });
            Assert.PropertyChanged(register, "ChangeTotal", () =>
            {
                register.ChangeFiftyCents++;
            });
            Assert.PropertyChanged(register, "AmountDue", () =>
            {
                register.ChangeFiftyCents++;
            });
        }

        [Fact]
        public void ChangingChangeDollarCoinsNotifiesChangeDollarCoinsChangeTotalAndAmountDue()
        {
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.PropertyChanged(register, "ChangeDollarCoins", () =>
            {
                register.ChangeDollarCoins++;
            });
            Assert.PropertyChanged(register, "ChangeTotal", () =>
            {
                register.ChangeDollarCoins++;
            });
            Assert.PropertyChanged(register, "AmountDue", () =>
            {
                register.ChangeDollarCoins++;
            });
        }

        [Fact]
        public void ChangingChangeQuartersNotifiesChangeQuartersChangeTotalAndAmountDue()
        {
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.PropertyChanged(register, "ChangeQuarters", () =>
            {
                register.ChangeQuarters++;
            });
            Assert.PropertyChanged(register, "ChangeTotal", () =>
            {
                register.ChangeQuarters++;
            });
            Assert.PropertyChanged(register, "AmountDue", () =>
            {
                register.ChangeQuarters++;
            });
        }

        [Fact]
        public void ChangingChangeDimesNotifiesChangeDimesChangeTotalAndAmountDue()
        {
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.PropertyChanged(register, "ChangeDimes", () =>
            {
                register.ChangeDimes++;
            });
            Assert.PropertyChanged(register, "ChangeTotal", () =>
            {
                register.ChangeDimes++;
            });
            Assert.PropertyChanged(register, "AmountDue", () =>
            {
                register.ChangeDimes++;
            });
        }

        [Fact]
        public void ChangingChangeNickelsNotifiesChangeNickelsChangeTotalAndAmountDue()
        {
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.PropertyChanged(register, "ChangeNickels", () =>
            {
                register.ChangeNickels++;
            });
            Assert.PropertyChanged(register, "ChangeTotal", () =>
            {
                register.ChangeNickels++;
            });
            Assert.PropertyChanged(register, "AmountDue", () =>
            {
                register.ChangeNickels++;
            });
        }

        [Fact]
        public void ChangingChangePenniesNotifiesChangePenniesChangeTotalAndAmountDue()
        {
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.PropertyChanged(register, "ChangePennies", () =>
            {
                register.ChangePennies++;
            });
            Assert.PropertyChanged(register, "ChangeTotal", () =>
            {
                register.ChangePennies++;
            });
            Assert.PropertyChanged(register, "AmountDue", () =>
            {
                register.ChangePennies++;
            });
        }

        /*
        [Fact]
        public void ChangingChangeHundredsUnderZeroDoesNotNotifiesChangeHundredsChangeTotalAndAmountDue()
        {
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.PropertyChanged(register, "ChangeHundreds", () =>
            {
                register.ChangeHundreds++;
            });
            Assert.PropertyChanged(register, "ChangeTotal", () =>
            {
                register.ChangeHundreds++;
            });
            Assert.PropertyChanged(register, "AmountDue", () =>
            {
                register.ChangeHundreds++;
            });
        }

        [Fact]
        public void ChangingChangeFiftiesUnderZeroDoesNotNotifiesChangeFiftiesChangeTotalAndAmountDue()
        {
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.PropertyChanged(register, "ChangeFIfties", () =>
            {
                register.ChangeFifties++;
            });
            Assert.PropertyChanged(register, "ChangeTotal", () =>
            {
                register.ChangeFifties++;
            });
            Assert.PropertyChanged(register, "AmountDue", () =>
            {
                register.ChangeFifties++;
            });
        }

        [Fact]
        public void ChangingChangeTwentiesUnderZeroDoesNotNotifiesChangeTwentiesChangeTotalAndAmountDue()
        {
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.PropertyChanged(register, "ChangeTwenties", () =>
            {
                register.ChangeTwenties++;
            });
            Assert.PropertyChanged(register, "ChangeTotal", () =>
            {
                register.ChangeTwenties++;
            });
            Assert.PropertyChanged(register, "AmountDue", () =>
            {
                register.ChangeTwenties++;
            });
        }

        [Fact]
        public void ChangingChangeTensUnderZeroDoesNotNotifiesChangeTensChangeTotalAndAmountDue()
        {
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.PropertyChanged(register, "ChangeTens", () =>
            {
                register.ChangeTens++;
            });
            Assert.PropertyChanged(register, "ChangeTotal", () =>
            {
                register.ChangeTens++;
            });
            Assert.PropertyChanged(register, "AmountDue", () =>
            {
                register.ChangeTens++;
            });
        }

        [Fact]
        public void ChangingChangeFivesUnderZeroDoesNotNotifiesChangeFivesChangeTotalAndAmountDue()
        {
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.PropertyChanged(register, "ChangeFives", () =>
            {
                register.ChangeFives++;
            });
            Assert.PropertyChanged(register, "ChangeTotal", () =>
            {
                register.ChangeFives++;
            });
            Assert.PropertyChanged(register, "AmountDue", () =>
            {
                register.ChangeFives++;
            });
        }

        [Fact]
        public void ChangingChangeTwosUnderZeroDoesNotNotifiesChangeTwosChangeTotalAndAmountDue()
        {
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.PropertyChanged(register, "ChangeTwos", () =>
            {
                register.ChangeTwos++;
            });
            Assert.PropertyChanged(register, "ChangeTotal", () =>
            {
                register.ChangeTwos++;
            });
            Assert.PropertyChanged(register, "AmountDue", () =>
            {
                register.ChangeTwos++;
            });
        }

        [Fact]
        public void ChangingChangeOnesUnderZeroDoesNotNotifiesChangeOnesChangeTotalAndAmountDue()
        {
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.PropertyChanged(register, "ChangeOnes", () =>
            {
                register.ChangeOnes++;
            });
            Assert.PropertyChanged(register, "ChangeTotal", () =>
            {
                register.ChangeOnes++;
            });
            Assert.PropertyChanged(register, "AmountDue", () =>
            {
                register.ChangeOnes++;
            });
        }

        [Fact]
        public void ChangingChangeFiftyUnderZeroDoesNotCentsNotifiesChangeFiftyCentsChangeTotalAndAmountDue()
        {
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.PropertyChanged(register, "ChangeFiftyCents", () =>
            {
                register.ChangeFiftyCents++;
            });
            Assert.PropertyChanged(register, "ChangeTotal", () =>
            {
                register.ChangeFiftyCents++;
            });
            Assert.PropertyChanged(register, "AmountDue", () =>
            {
                register.ChangeFiftyCents++;
            });
        }

        [Fact]
        public void ChangingChangeDollarCoinsUnderZeroDoesNotNotifiesChangeDollarCoinsChangeTotalAndAmountDue()
        {
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.PropertyChanged(register, "ChangeDollarCoins", () =>
            {
                register.ChangeDollarCoins++;
            });
            Assert.PropertyChanged(register, "ChangeTotal", () =>
            {
                register.ChangeDollarCoins++;
            });
            Assert.PropertyChanged(register, "AmountDue", () =>
            {
                register.ChangeDollarCoins++;
            });
        }

        [Fact]
        public void ChangingChangeQuartersUnderZeroDoesNotNotifiesChangeQuartersChangeTotalAndAmountDue()
        {
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.PropertyChanged(register, "ChangeQuarters", () =>
            {
                register.ChangeQuarters++;
            });
            Assert.PropertyChanged(register, "ChangeTotal", () =>
            {
                register.ChangeQuarters++;
            });
            Assert.PropertyChanged(register, "AmountDue", () =>
            {
                register.ChangeQuarters++;
            });
        }

        [Fact]
        public void ChangingChangeDimesUnderZeroDoesNotNotifiesChangeDimesChangeTotalAndAmountDue()
        {
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.PropertyChanged(register, "ChangeDimes", () =>
            {
                register.ChangeDimes--;
            });
            Assert.PropertyChanged(register, "ChangeTotal", () =>
            {
                register.ChangeDimes++;
            });
            Assert.PropertyChanged(register, "AmountDue", () =>
            {
                register.ChangeDimes++;
            });
        }

        [Fact]
        public void ChangingChangeNickelsUnderZeroDoesNotNotifiesChangeNickelsChangeTotalAndAmountDue()
        {
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.PropertyChanged(register, "ChangeNickels", () =>
            {
                register.ChangeNickels++;
            });
            Assert.PropertyChanged(register, "ChangeTotal", () =>
            {
                register.ChangeNickels++;
            });
            Assert.PropertyChanged(register, "AmountDue", () =>
            {
                register.ChangeNickels++;
            });
        }

        [Fact]
        public void ChangingChangePenniesUnderZeroDoesNotNotifiesChangePenniesChangeTotalAndAmountDue()
        {
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.PropertyChanged(register, "ChangePennies", () =>
            {
                register.ChangePennies++;
            });
            Assert.PropertyChanged(register, "ChangeTotal", () =>
            {
                register.ChangePennies++;
            });
            Assert.PropertyChanged(register, "AmountDue", () =>
            {
                register.ChangePennies++;
            });
        }
        */

        [Fact]
        public void GivingAHundredInChangeNotifiesChangeHundredsAndAmountDue()
        {
            CashDrawer.ResetDrawer();
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            order.Add(new BriarheartBurger());
            CashDrawer.OpenDrawer();
            CashDrawer.Hundreds += 10;
            register.CustomerHundreds += 2;
            register.MakeChange();
            register.CustomerHundreds++;
            Assert.PropertyChanged(register, "ChangeHundreds", () =>
            {
                register.MakeChange();
            });
            register.CustomerHundreds ++;
            Assert.PropertyChanged(register, "AmountDue", () =>
            {
                register.MakeChange();
            });
        }

        [Fact]
        public void GivingAFiftyInChangeNotifiesChangeFiftiesAndAmountDue()
        {
            CashDrawer.ResetDrawer();
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            order.Add(new BriarheartBurger());
            CashDrawer.OpenDrawer();
            CashDrawer.Fifties += 10;
            register.CustomerHundreds += 2;
            register.MakeChange();
            register.CustomerFifties++;
            Assert.PropertyChanged(register, "ChangeFifties", () =>
            {
                register.MakeChange();
            });
            register.CustomerFifties++;
            Assert.PropertyChanged(register, "AmountDue", () =>
            {
                register.MakeChange();
            });
        }

        [Fact]
        public void GivingATwentyInChangeNotifiesChangeTwentiesAndAmountDue()
        {
            CashDrawer.ResetDrawer();
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            order.Add(new BriarheartBurger());
            CashDrawer.OpenDrawer();
            CashDrawer.Twenties += 10;
            register.CustomerHundreds += 2;
            register.MakeChange();
            register.CustomerTwenties++;
            Assert.PropertyChanged(register, "ChangeTwenties", () =>
            {
                register.MakeChange();
            });
            register.CustomerTwenties++;
            Assert.PropertyChanged(register, "AmountDue", () =>
            {
                register.MakeChange();
            });
        }

        [Fact]
        public void GivingATenInChangeNotifiesChangeTensAndAmountDue()
        {
            CashDrawer.ResetDrawer();
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            order.Add(new BriarheartBurger());
            CashDrawer.OpenDrawer();
            CashDrawer.Tens += 10;
            register.CustomerHundreds += 2;
            register.MakeChange();
            register.CustomerTens++;
            Assert.PropertyChanged(register, "ChangeTens", () =>
            {
                register.MakeChange();
            });
            register.CustomerTens++;
            Assert.PropertyChanged(register, "AmountDue", () =>
            {
                register.MakeChange();
            });
        }

        [Fact]
        public void GivingAFiveInChangeNotifiesChangeFivesAndAmountDue()
        {
            CashDrawer.ResetDrawer();
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            order.Add(new BriarheartBurger());
            CashDrawer.OpenDrawer();
            CashDrawer.Fives += 10;
            register.CustomerHundreds += 2;
            register.MakeChange();
            register.CustomerFives++;
            Assert.PropertyChanged(register, "ChangeFives", () =>
            {
                register.MakeChange();
            });
            register.CustomerFives++;
            Assert.PropertyChanged(register, "AmountDue", () =>
            {
                register.MakeChange();
            });
        }

        [Fact]
        public void GivingATwoInChangeNotifiesChangeTwosAndAmountDue()
        {
            CashDrawer.ResetDrawer();
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            order.Add(new BriarheartBurger());
            CashDrawer.OpenDrawer();
            CashDrawer.Twos += 10;
            register.CustomerHundreds += 2;
            register.MakeChange();
            register.CustomerTwos++;
            Assert.PropertyChanged(register, "ChangeTwos", () =>
            {
                register.MakeChange();
            });
            register.CustomerTwos++;
            Assert.PropertyChanged(register, "AmountDue", () =>
            {
                register.MakeChange();
            });
        }

        [Fact]
        public void GivingAOneInChangeNotifiesChangeOnesAndAmountDue()
        {
            CashDrawer.ResetDrawer();
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            order.Add(new BriarheartBurger());
            CashDrawer.OpenDrawer();
            CashDrawer.Ones += 10;
            register.CustomerHundreds += 2;
            register.MakeChange();
            register.CustomerOnes++;
            Assert.PropertyChanged(register, "ChangeOnes", () =>
            {
                register.MakeChange();
            });
            register.CustomerOnes++;
            Assert.PropertyChanged(register, "AmountDue", () =>
            {
                register.MakeChange();
            });
        }

        [Fact]
        public void GivingADollarCoinInChangeNotifiesChangeDollarCoinsAndAmountDue()
        {
            CashDrawer.ResetDrawer();
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            order.Add(new BriarheartBurger());
            CashDrawer.OpenDrawer();
            CashDrawer.Dollars += 10;
            register.CustomerHundreds += 2;
            register.MakeChange();
            register.CustomerDollarCoins++;
            Assert.PropertyChanged(register, "ChangeDollarCoins", () =>
            {
                register.MakeChange();
            });
            register.CustomerDollarCoins++;
            Assert.PropertyChanged(register, "AmountDue", () =>
            {
                register.MakeChange();
            });
        }

        [Fact]
        public void GivingAHalfDollarInChangeNotifiesChangeFiftyCentsAndAmountDue()
        {
            CashDrawer.ResetDrawer();
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            order.Add(new BriarheartBurger());
            CashDrawer.OpenDrawer();
            CashDrawer.HalfDollars += 10;
            register.CustomerHundreds += 2;
            register.MakeChange();
            register.CustomerFiftyCents++;
            Assert.PropertyChanged(register, "ChangeFiftyCents", () =>
            {
                register.MakeChange();
            });
            register.CustomerFiftyCents++;
            Assert.PropertyChanged(register, "AmountDue", () =>
            {
                register.MakeChange();
            });
        }

        [Fact]
        public void GivingAQuarterInChangeNotifiesChangeQuartersAndAmountDue()
        {
            CashDrawer.ResetDrawer();
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            order.Add(new BriarheartBurger());
            CashDrawer.OpenDrawer();
            CashDrawer.Quarters++;
            register.CustomerHundreds += 2;
            register.MakeChange();
            register.CustomerQuarters++;
            Assert.PropertyChanged(register, "ChangeQuarters", () =>
            {
                register.MakeChange();
            });
            register.CustomerQuarters++;
            Assert.PropertyChanged(register, "AmountDue", () =>
            {
                register.MakeChange();
            });
        }

        [Fact]
        public void GivingADImeInChangeNotifiesChangeDimesAndAmountDue()
        {
            CashDrawer.ResetDrawer();
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            order.Add(new BriarheartBurger());
            CashDrawer.OpenDrawer();
            CashDrawer.Dimes++;
            register.CustomerHundreds += 2;
            register.MakeChange();
            register.CustomerDimes++;
            Assert.PropertyChanged(register, "ChangeDimes", () =>
            {
                register.MakeChange();
            });
            register.CustomerDimes++;
            Assert.PropertyChanged(register, "AmountDue", () =>
            {
                register.MakeChange();
            });
        }

        [Fact]
        public void GivingANickelInChangeNotifiesChangeNickelsAndAmountDue()
        {
            CashDrawer.ResetDrawer();
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            order.Add(new BriarheartBurger());
            CashDrawer.OpenDrawer();
            CashDrawer.Nickels++;
            register.CustomerHundreds += 2;
            register.MakeChange();
            register.CustomerNickels++;
            Assert.PropertyChanged(register, "ChangeNickels", () =>
            {
                register.MakeChange();
            });
            register.CustomerNickels++;
            Assert.PropertyChanged(register, "AmountDue", () =>
            {
                register.MakeChange();
            });
        }

        [Fact]
        public void GivingAPennyInChangeNotifiesChangePenniesAndAmountDue()
        {
            CashDrawer.ResetDrawer();
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            order.Add(new BriarheartBurger());
            CashDrawer.OpenDrawer();
            CashDrawer.Pennies++;
            register.CustomerHundreds += 2;
            register.MakeChange();
            register.CustomerPennies++;
            Assert.PropertyChanged(register, "ChangePennies", () =>
            {
                register.MakeChange();
            });
            register.CustomerPennies++;
            Assert.PropertyChanged(register, "AmountDue", () =>
            {
                register.MakeChange();
            });
        }


        [Fact]
        public void TotalInDrawerPropertyIsSetToTheTotalInTheDrawer()
        {
            CashDrawer.ResetDrawer();
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            double total = CashDrawer.Total;
            Assert.Equal(total, register.TotalInDrawer);
        }

        [Fact]
        public void OnPropertyChangedChangesPropertyPassed()
        {
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            Assert.PropertyChanged(register, "ChangeHundreds", () =>
            {
                register.OnPropertyChanged("ChangeHundreds");
            });
        }


        [Fact]
        public void CashOutPutsBillsInAndGivesBillsToCustomer()
        {
            Order order = new Order();
            RegisterViewModel register = new RegisterViewModel(order);
            int hundreds = CashDrawer.Hundreds;
            int fifties = CashDrawer.Fifties;
            int twenties = CashDrawer.Twenties;
            int tens = CashDrawer.Tens;
            int fives = CashDrawer.Fives;
            int twos = CashDrawer.Twos;
            int ones = CashDrawer.Ones;
            int dollars = CashDrawer.Dollars;
            int halfDollars = CashDrawer.HalfDollars;
            int quarters = CashDrawer.Quarters;
            int dimes = CashDrawer.Dimes;
            int nickels = CashDrawer.Nickels;
            int pennies = CashDrawer.Pennies;
            register.CashOut();
            Assert.Equal(hundreds, CashDrawer.Hundreds);
            Assert.Equal(fifties, CashDrawer.Fifties);
            Assert.Equal(twenties, CashDrawer.Twenties);
            Assert.Equal(tens, CashDrawer.Tens);
            Assert.Equal(fives, CashDrawer.Fives);
            Assert.Equal(twos, CashDrawer.Twos);
            Assert.Equal(ones, CashDrawer.Ones);
            Assert.Equal(dollars, CashDrawer.Dollars);
            Assert.Equal(halfDollars, CashDrawer.HalfDollars);
            Assert.Equal(quarters, CashDrawer.Quarters);
            Assert.Equal(dimes, CashDrawer.Dimes);
            Assert.Equal(nickels, CashDrawer.Nickels);
            Assert.Equal(pennies, CashDrawer.Pennies);
        }

    }
}