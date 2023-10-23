using System;
using System.Windows;

namespace LAB2 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow {
        public MainWindow() {
            InitializeComponent();
        }

        private void Count(object sender, RoutedEventArgs e) {
            try {
                if ((bool)isFast.IsChecked) {
                    var bus = new BusOnSpeed(int.Parse(price.Text), int.Parse(seats.Text), int.Parse(speed.Text));
                    res.Content = bus.Count();
                } else {
                    var bus = new Bus(int.Parse(price.Text), int.Parse(seats.Text));
                    res.Content = bus.Count();
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}