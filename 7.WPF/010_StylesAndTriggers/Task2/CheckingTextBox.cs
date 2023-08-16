using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Task2
{
    class CheckingTextBox : TextBox
    {
        public bool IsContentCorrect { get; set; }

        public CheckingTextBox()
        {
            IsContentCorrect = true;
        }
    }
}
