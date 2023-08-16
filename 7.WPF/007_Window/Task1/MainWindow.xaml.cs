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
        private readonly string[] ballAnswers;
        private readonly Random randomAnswerGiver;

        public MainWindow()
        {
            InitializeComponent();

            ballAnswers = new string[] {"It is certain", "It is decidedly so", "Without a doubt", "Yes — definitely", "You may rely on it",
                                        "As I see it, yes", "Most likely", "Outlook good", "Signs point to yes", "Yes",
                                        "Reply hazy, try again", "Ask again later", "Better not tell you now", "Cannot predict now", "Concentrate and ask again",
                                        "Dont't count on it", "My reply is no", "My sources say no", "Outlook not so good", "Very doubtful" };

            randomAnswerGiver = new Random();
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void sendQuestionButton_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = ballAnswers[randomAnswerGiver.Next(0, ballAnswers.Length)];
        }

        private void textBox_MouseEnter(object sender, MouseEventArgs e)
        {
            textBox.Text = string.Empty;
        }
    }
}
