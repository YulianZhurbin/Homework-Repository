using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _214_AdditionalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7 };

			int[] evenArray = new int[0];

			foreach (int iterationElement in UserCollection.Power(array))
			{
				int[] tempArray = new int[evenArray.Length + 1];
				for (int i = 0; i < evenArray.Length; i++)
				{
					tempArray[i] = evenArray[i];
				}
				tempArray[evenArray.Length] = iterationElement;
				evenArray = tempArray;
			}

			for (int i = 0; i < evenArray.Length; i++)
			{
				Console.Write(evenArray[i] + "  ");
			}

			//Delay
			Console.ReadKey();
        }
    }
}
