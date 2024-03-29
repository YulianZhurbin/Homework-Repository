﻿using System;
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
using System.Windows.Ink;

namespace Task2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void inkCanvas_Gesture(object sender, InkCanvasGestureEventArgs e)
        {
            //string gestures = "";

            //foreach (GestureRecognitionResult res in e.GetGestureRecognitionResults())
            //    gestures += res.ApplicationGesture.ToString() + "; ";

            //gestureName.Text = gestures;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //foreach (InkCanvasEditingMode mode in Enum.GetValues(typeof(InkCanvasEditingMode)))
            //    editingMode.Items.Add(mode);

            editingMode.Items.Add(InkCanvasEditingMode.Ink);
            editingMode.Items.Add(InkCanvasEditingMode.EraseByStroke);
            editingMode.SelectedItem = inkCanvas.EditingMode;
        }
    }
}
