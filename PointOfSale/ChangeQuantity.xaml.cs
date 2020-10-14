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
    /// Interaction logic for ChangeQuantity.xaml
    /// </summary>
    public partial class ChangeQuantity : UserControl
    {

        public static DependencyProperty ValueProperty = DependencyProperty.Register("Value", typeof(int), typeof(ChangeQuantity),
            new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, HandleValueChanged));


        public int Value
        {
            get { return (int)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }


        public static readonly RoutedEvent ValueClampedEvent = EventManager.RegisterRoutedEvent("ValueClamped", 
            RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(ChangeQuantity));


        public event RoutedEventHandler ValueClamped
        {
            add { AddHandler(ValueClampedEvent, value); }
            remove { RemoveHandler(ValueClampedEvent, value); }
        }


        public int MinValue => 0;


        public ChangeQuantity()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Callback for the ValueProperty, which clamps the Value to the range 
        /// defined by MinValue and MaxValue
        /// </summary>
        /// <param name="sender">The NumberBox whose value is changing</param>
        /// <param name="e">The event args</param>
        static void HandleValueChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            if (e.Property.Name == "Value" && sender is ChangeQuantity customer)
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
