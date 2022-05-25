using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _214_AdditionalTask
{
    class UserCollection
    {
        public static IEnumerable Power(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0 && array[i] != 0)
                {
                    yield return array[i];
                }
            }
        }
    }
}
