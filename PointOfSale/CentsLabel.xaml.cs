/*
 * Author: Nolan Meyer
 * Class name: CentsLabel.xaml.cs
 * Purpose: Class used to create a custom CentsLabel Label
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
    /// Interaction logic for CentsLabel.xaml
    /// </summary>
    public partial class CentsLabel : UserControl
    {
        /// <summary>
        /// Dependency Property for the Value property
        /// </summary>
        public static DependencyProperty ValueProperty = DependencyProperty.Register("Value", typeof(int), typeof(CentsLabel));

        /// <summary>
        /// The value in the Label. the number for the coin it represents.
        /// </summary>
        public int Value
        {
            get { return (int)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        /// <summary>
        /// Initializes the CentsLabel
        /// </summary>
        public CentsLabel()
        {
            InitializeComponent();
        }
    }
}
