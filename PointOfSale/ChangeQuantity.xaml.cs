/*
 * Author: Nolan Meyer
 * Class name: ChangeQuantity.xaml.cs
 * Purpose: Class used to create a custom ChangeQuantity control.
 */
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
        /// <summary>
        /// Dependency Property for the Change property
        /// </summary>
        public static DependencyProperty ChangeProperty = DependencyProperty.Register("Change", typeof(int), typeof(ChangeQuantity));

        /// <summary>
        /// Property for the amount of change. The value in the text box.
        /// </summary>
        public int Change
        {
            get { return (int)GetValue(ChangeProperty); }
            set { SetValue(ChangeProperty, value); }
        }

        /// <summary>
        /// Initializes ChangeQuantity
        /// </summary>
        public ChangeQuantity()
        {
            InitializeComponent();
        }

    }
}
