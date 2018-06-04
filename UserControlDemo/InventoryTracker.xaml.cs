using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UserControlDemo
{
    /// <summary>
    /// Interaction logic for InventoryTracker.xaml
    /// </summary>
    public partial class InventoryTracker : UserControl
    {
        private string _ctrlName;
        private string _ctrlStartValue;
        private string _ctrlCurrentValue;

        // PUBLIC PROPERTIES 

        public string ctrlName
        {
            get
            {
                return _ctrlName;
            }
            set
            {
                _ctrlName = value;

                carName.Text = ctrlName;
            }
        }

        public string ctrlCurrentValue
        {
            get
            {
                return _ctrlCurrentValue;
            }
            set
            {
                _ctrlCurrentValue = value;

                currentValue.Text = ctrlCurrentValue;
            }
        }

        public string ctrlStartValue
        {
            get
            {
                return _ctrlStartValue;
            }
            set
            {
                _ctrlStartValue = value;

                startValue.Text = ctrlStartValue;
            }
        }

        public InventoryTracker()
        {
            InitializeComponent();
        }


    }
}
