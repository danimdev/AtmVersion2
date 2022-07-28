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

namespace ATM2._0
{
    public partial class MainWindow : Window
    {
        int MaxPinNumberCount = 0;

        string pinToSet;

        PinLoginPage pinPage = new PinLoginPage();

        public MainWindow()
        {
            InitializeComponent();

            MainFrame.Content = pinPage;
        }

        void AddNumberToString(Label numberLabel,int number)
        {
            if(MaxPinNumberCount > 3)
            {
                return;
            }
            else
            {
                numberLabel.Content += number.ToString();
                MaxPinNumberCount++;
            }
        }

        public void SetPin(object sender, RoutedEventArgs e)
        {
            if(MaxPinNumberCount >= 3)
            {
                pinToSet = pinPage.PinLabel.Content.ToString();
            }
        }

        public void CheckPin(object sender, RoutedEventArgs e)
        {
            if(pinToSet == pinPage.PinLabel.Content.ToString())
            {

                MainFrame.Content = new ShowAccountData();
            }
        }

        private void ButtonNum1(object sender, RoutedEventArgs e)
        {
            AddNumberToString(pinPage.PinLabel, 1);
        }

        private void ButtonNum2(object sender, RoutedEventArgs e)
        {
            AddNumberToString(pinPage.PinLabel, 2);
        }

        private void ButtonNum3(object sender, RoutedEventArgs e)
        {
            AddNumberToString(pinPage.PinLabel, 3);
        }

        private void ButtonNum4(object sender, RoutedEventArgs e)
        {
            AddNumberToString(pinPage.PinLabel, 4);
        }

        private void ButtonNum5(object sender, RoutedEventArgs e)
        {
            AddNumberToString(pinPage.PinLabel, 5);
        }

        private void ButtonNum6(object sender, RoutedEventArgs e)
        {
            AddNumberToString(pinPage.PinLabel, 6);
        }

        private void ButtonNum7(object sender, RoutedEventArgs e)
        {
            AddNumberToString(pinPage.PinLabel, 7);
        }

        private void ButtonNum8(object sender, RoutedEventArgs e)
        {
            AddNumberToString(pinPage.PinLabel, 8);
        }

        private void ButtonNum9(object sender, RoutedEventArgs e)
        {
            AddNumberToString(pinPage.PinLabel, 9);
        }

        private void ButtonNum0(object sender, RoutedEventArgs e)
        {
            AddNumberToString(pinPage.PinLabel, 0);
        }

        private void ButtonCancel(object sender, RoutedEventArgs e)
        {
            pinPage.PinLabel.Content = "Pin:";
            MaxPinNumberCount = 0;
        }
    }
}
