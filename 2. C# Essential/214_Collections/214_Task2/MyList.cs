using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _214_Task2
{
	class MyList<T>
	{
		private T[] collection;

		public MyList()
		{
			collection = new T[0];
		}

		public T this[int index]
		{
			get
			{
				return collection[index];
			}
		}

		public void Add(T element)
		{
			T[] tempArray = new T[collection.Length + 1];
			for (int i = 0; i < collection.Length; i++)
			{
				tempArray[i] = collection[i];
			}
			tempArray[collection.Length] = element;
			collection = tempArray;
		}

		public int Count
		{
			get
			{
				return collection.Length;
			}
		}

		public IEnumerable<T> GetCollection()
		{
			for (int i = 0; i < collection.Length; i++)
			{
				yield return collection[i];
			}
		}


	}
}
