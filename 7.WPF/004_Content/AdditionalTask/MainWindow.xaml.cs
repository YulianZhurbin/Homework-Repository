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
        public MainWindow()
        {
            InitializeComponent();

            eventCheckBox.Checked += OnCheckBoxChecked;
            eventCheckBox.Unchecked += OnCheckBoxUnchecked;

            textBoxName.MouseDoubleClick += OnMouseDoubleClick;
            textBoxName.SizeChanged += OnSizeChanged;
            textBoxName.TextChanged += OnTextChanged;
        }

        private void OnCheckBoxChecked(object sender, RoutedEventArgs e)
        {
            panel.Visibility = Visibility.Visible;
        }
        private void OnCheckBoxUnchecked(object sender, RoutedEventArgs e)
        {
            panel.Visibility = Visibility.Collapsed;
        }

        private void OnMouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            eventTextBlock.Text += "OnMouseDoubleClick \n";
        }
        private void OnSizeChanged(object sender, SizeChangedEventArgs e)
        {
            eventTextBlock.Text += "OnSizeChanged \n";
        }
        private void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            eventTextBlock.Text += "OnTextChanged \n";
        }
    }
}
