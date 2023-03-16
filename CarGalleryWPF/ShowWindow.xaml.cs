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
using System.Windows.Shapes;

namespace CarGalleryWPF
{
    /// <summary>
    /// Interaction logic for ShowWindow.xaml
    /// </summary>
    public partial class ShowWindow : Window
    {
        public CarGallery carGallery = new CarGallery();
        public ShowWindow()
        {
            InitializeComponent();

            DataContext = carGallery;
        }

        private void Rectangle_MouseLeftButtonDown(object sender, MouseButtonEventArgs e) => DragMove();
        private void ButtonClose_Click(object sender, RoutedEventArgs e) => Close();
    }
}
