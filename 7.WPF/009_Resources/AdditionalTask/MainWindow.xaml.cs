using LocalizatorHelper;
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

namespace AdditionalTask
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BitmapImage[] images;
        int currentImageIndex = 0;

        public MainWindow()
        {
            InitializeComponent();

            ResourceManagerService.RegisterManager("MainWindowRes", MainWindowRes.ResourceManager, true);

            images = new BitmapImage[] { new BitmapImage(new Uri("Images/Arrow.png", UriKind.Relative)),
                                             new BitmapImage(new Uri("Images/Circle.png", UriKind.Relative)),
                                             new BitmapImage(new Uri("Images/Square.png", UriKind.Relative)),
                                             new BitmapImage(new Uri("Images/Star.png", UriKind.Relative)),
                                             new BitmapImage(new Uri("Images/Triangle.png", UriKind.Relative))};
        }

        private void nextButton_Click(object sender, RoutedEventArgs e)
        {
            currentImageIndex++;

            if(currentImageIndex >= images.Length)
            {
                currentImageIndex = 0;
            }

            img.Source = images[currentImageIndex];
        }

        private void previousButton_Click(object sender, RoutedEventArgs e)
        {
            currentImageIndex--;

            if (currentImageIndex < 0)
            {
                currentImageIndex = images.Length-1;
            }

            img.Source = images[currentImageIndex];
        }

        private void RuMenuItem_Click(object sender, RoutedEventArgs e)
        {
            ResourceManagerService.ChangeLocale("ru-RU");
        }        
        
        private void EnMenuItem_Click(object sender, RoutedEventArgs e)
        {
            ResourceManagerService.ChangeLocale("en-US");
        }
    }
}
