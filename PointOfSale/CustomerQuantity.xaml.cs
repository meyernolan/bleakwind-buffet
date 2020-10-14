using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomerQuantity.xaml
    /// </summary>
    public partial class CustomerQuantity : UserControl
    {
        public static DependencyProperty StepProperty = DependencyProperty.Register("Step", typeof(int), typeof(CustomerQuantity));


        public int Step
        {
            get { return (int)GetValue(StepProperty); }
            set { SetValue(StepProperty, value); }
        }


        public int Value
        {
            get { return (int)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }


        public int MinValue => 0;


        public static readonly RoutedEvent ValueClampedEvent = EventManager.RegisterRoutedEvent("ValueClamped",
            RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(CustomerQuantity));


        public event RoutedEventHandler ValueClamped
        {
            add { AddHandler(ValueClampedEvent, value); }
            remove { RemoveHandler(ValueClampedEvent, value); }
        }


        public CustomerQuantity()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the click of the increment or decrement button
        /// </summary>
        /// <param name="sender">The button clicked</param>
        /// <param name="e">The event arguments</param>
        void HandleButtonClick(object sender, RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                switch (button.Name)
                {
                    case "Increment":
                        Value += Step;
                        break;
                    case "Decrement":
                        Value -= Step;
                        break;
                }
            }
            e.Handled = true;
        }


        public static DependencyProperty ValueProperty = DependencyProperty.Register("Value", typeof(int), typeof(CustomerQuantity),
            new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, HandleValueChanged));

        /// <summary>
        /// Callback for the ValueProperty, which clamps the Value to the range 
        /// defined by MinValue and MaxValue
        /// </summary>
        /// <param name="sender">The NumberBox whose value is changing</param>
        /// <param name="e">The event args</param>
        static void HandleValueChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            if (e.Property.Name == "Value" && sender is CustomerQuantity customer)
            {
                if (customer.Value < customer.MinValue)
                {
                    customer.Value = customer.MinValue;
                    customer.RaiseEvent(new RoutedEventArgs(ValueClampedEvent));
                }
            }
        }
    }
}
