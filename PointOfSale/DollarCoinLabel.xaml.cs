/*
 * Author: Nolan Meyer
 * Class name: DollarCoinLabel.xaml.cs
 * Purpose: Class used to create a DollarCoinLabel
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
    /// Interaction logic for DollarCoinLabel.xaml
    /// </summary>
    public partial class DollarCoinLabel : UserControl
    {
        /// <summary>
        /// Dependency Property for the Value property
        /// </summary>
        public static DependencyProperty ValueProperty = DependencyProperty.Register("Value", typeof(int), typeof(DollarCoinLabel),
            new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsRender));

        /// <summary>
        /// The value of the label, represents a dollar coin value.
        /// </summary>
        public int Value
        {
            get { return (int)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }

        /// <summary>
        /// Initializes a DollarCoinLabel
        /// </summary>
        public DollarCoinLabel()
        {
            InitializeComponent();
        }
    }
}
