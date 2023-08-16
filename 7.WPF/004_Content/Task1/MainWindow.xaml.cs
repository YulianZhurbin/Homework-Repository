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

namespace Task1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            englishRadioButton.Checked += OnEnglishRadioButtonChecked;
            russianRadioButton.Checked += OnRussianRadioButtonChecked;
        }
        private void OnEnglishRadioButtonChecked(object sender, RoutedEventArgs e)
        {
            file.Content = "File";
            edit.Content = "Edit";
            view.Content = "View";
            git.Content = "Git";
            project.Content = "Project";
            build.Content = "Build";
            debug.Content = "Debug";
        }
        private void OnRussianRadioButtonChecked(object sender, RoutedEventArgs e)
        {
            file.Content = "Файл";
            edit.Content = "Редактировать";
            view.Content = "Вид";
            git.Content = "Гит";
            project.Content = "Проект";
            build.Content = "Билд";
            debug.Content = "Дебаг";
        }
    }
}
