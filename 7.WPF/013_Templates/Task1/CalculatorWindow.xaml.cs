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

namespace Task1
{
    /// <summary>
    /// Interaction logic for CalculatorWindow.xaml
    /// </summary>
    public partial class CalculatorWindow : Window
    {
        Status status = Status.Simple;

        public CalculatorWindow()
        {
            InitializeComponent();
        }

        public CalculatorWindow(Status status)
        {
            InitializeComponent();
            this.status = status;
            SetVisualStyle();
        }

        private void SetVisualStyle()
        {
            string path;
            ResourceDictionary resourceDictionary;

            if (status == Status.Premium)
            {
                path = "TemplateResources/TextBoxPremium.xaml";
                resourceDictionary = new ResourceDictionary() { Source = new Uri(path, UriKind.Relative) };
                this.Resources.MergedDictionaries.Add(resourceDictionary);

                path = "TemplateResources/ButtonPremium.xaml";
                resourceDictionary = new ResourceDictionary() { Source = new Uri(path, UriKind.Relative) };
                this.Resources.MergedDictionaries.Add(resourceDictionary);

                path = "TemplateResources/LabelPremium.xaml";
                resourceDictionary = new ResourceDictionary() { Source = new Uri(path, UriKind.Relative) };
                this.Resources.MergedDictionaries.Add(resourceDictionary);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double radius = Convert.ToDouble(radiusTextBox.Text);
            double area = Math.PI * Math.Pow(radius, 2);
            areaResultLabel.Content = String.Format("{0:F2}", area);
        }
    }
}
