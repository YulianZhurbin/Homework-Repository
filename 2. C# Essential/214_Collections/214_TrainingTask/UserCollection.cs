using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _214_TrainingTask
{
	class UserCollection : IEnumerable, IEnumerator
	{
		int[] array;

		public UserCollection(int n)
		{
			array = new int[n];
		}

		public void Fill()
		{
			Random rand = new Random();

			for (int i = 0; i < array.Length; i++)
			{
				array[i] = rand.Next(0, 10);
			}
		}

		public IEnumerator GetEnumerator()
		{
			return this as IEnumerator;
		}

		public int position = -1;

		public bool MoveNext()
		{
			if (position < array.Length - 1)
			{
				position++;
				return true;
			}
			else
			{
				Reset();
				return false;
			}
		}

		public object Current
		{
			get
			{
				return array[position];
			}
		}

		public void Reset()
		{
			position = -1;
		}
	}
}
