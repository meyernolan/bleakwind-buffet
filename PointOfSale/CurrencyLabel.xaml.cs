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
    /// Interaction logic for CurrencyLabel.xaml
    /// </summary>
    public partial class CurrencyLabel : UserControl
    {

        public static DependencyProperty ValueProperty = DependencyProperty.Register("Value", typeof(int), typeof(CurrencyLabel),
            new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.AffectsRender));


        public int Value
        {
            get { return (int)GetValue(ValueProperty); }
            set { SetValue(ValueProperty, value); }
        }


        public CurrencyLabel()
        {
            InitializeComponent();
        }
    }
}
