using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Task2
{
    class MyFirstControl : FrameworkElement
    {
        //static FrameworkPropertyMetadata metadata = new FrameworkPropertyMetadata(new PropertyChangedCallback(ChangedCallbackMethod), new CoerceValueCallback(CoerceValueCallbackMethod));

        public static DependencyProperty DataProperty;

        static MyFirstControl()
        {
            DataProperty = DependencyProperty.Register("Data", typeof(int), typeof(MyFirstControl));

            //DataProperty = DependencyProperty.Register("Data", typeof(int), typeof(MyFirstControl), metadata, new ValidateValueCallback(ValidateValueCallbackMethod));
        }


        public int Data
        {
            get { return (int)GetValue(DataProperty); }
            set { SetValue(DataProperty, value); }
        }

        //private static void ChangedCallbackMethod(DependencyObject d, DependencyPropertyChangedEventArgs e)
        //{
        //    throw new NotImplementedException();            
        //}

        //private static object CoerceValueCallbackMethod(DependencyObject d, object baseValue)
        //{
        //    throw new NotImplementedException();
        //}

        //private static bool ValidateValueCallbackMethod(object value)
        //{
        //    throw new NotImplementedException();
        //}

    }
}
