using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            AddCarInventory();
            updateCarInventory();
        }

        /// <summary>
        /// Description: This method adds the InventoryTracker user control to the wrap panel 
        /// </summary>
        private void AddCarInventory()
        {
            InventoryTracker car1 = new InventoryTracker
            {
                ctrlName = "Honda",
                ctrlStartValue = InventoryDb.Honda.ToString()
            };
            InventoryTracker car2 = new InventoryTracker
            {
                ctrlName = "Mazda",
                ctrlStartValue = InventoryDb.Honda.ToString()
            };
            InventoryTracker car3 = new InventoryTracker
            {
                ctrlName = "Ford",
                ctrlStartValue = InventoryDb.Honda.ToString()
            };
            InventoryTracker car4 = new InventoryTracker
            {
                ctrlName = "Nissan",
                ctrlStartValue = InventoryDb.Honda.ToString()
            };

            uiInventory.Children.Add(car1);
            uiInventory.Children.Add(car2);
            uiInventory.Children.Add(car3);
            uiInventory.Children.Add(car4);
        }

        /// <summary>
        /// Description: This method uses a DispatcherTimer object to update the car inventory every 3 seconds 
        /// </summary>
        private void updateCarInventory()
        {

            System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 3);
            dispatcherTimer.Start();

        }

        /// <summary>
        /// Description: This is the dispatcherTimer event handler. It displays the new car inventory
        /// everytime the dispatcherTimer ticks. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            foreach (FrameworkElement fe in uiInventory.Children)
            {
                if (fe is InventoryTracker)
                {
                    InventoryTracker car = (InventoryTracker)fe;
                    car.ctrlCurrentValue = InventoryDb.GetInventory(car.ctrlName).ToString();
                }
            }
        }
    }
}
