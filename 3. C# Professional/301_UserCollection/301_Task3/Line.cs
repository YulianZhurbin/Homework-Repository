using System;
using System.Collections;

namespace _301_Task3
{
	class Line : IEnumerable, IEnumerator
	{
		private Citizen[] queue = new Citizen[] { };

		public Citizen this[int index]
		{

			get
			{
				if (index >= 0 && index < queue.Length)
				{
					return queue[index];
				}
				else
				{
					return null;
				}
			}
		}

		#region Реализация методов IEnumerable, IEnumerator
		int position = -1;

		IEnumerator IEnumerable.GetEnumerator()
		{
			return this;
		}

		object IEnumerator.Current
		{
			get
			{
				return queue[position];
			}
		}

		bool IEnumerator.MoveNext()
		{
			if (position < queue.Length - 1)
			{
				position++;
				return true;
			}
			else
			{
				((IEnumerator)this).Reset();
				return false;
			}
		}

		void IEnumerator.Reset()
		{
			position = -1;
		}
		#endregion

		public int? Add(Citizen one)
		{
			for (int i = 0; i < queue.Length; i++)
			{
				if (one == queue[i])
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("\nSuch a person is already in the queue");
					Console.ForegroundColor = ConsoleColor.Gray;
					return null;
				}
			}

			Citizen[] tempArr = new Citizen[queue.Length + 1];

			queue.CopyTo(tempArr, 0);

			if (one is Retired)
			{
				for (int i = tempArr.Length - 2; i >= 0; i--)
				{
					if (tempArr[i] is Retired)
					{
						for (int j = tempArr.Length - 1; j > i + 1; j--)
						{
							tempArr[j] = tempArr[j - 1];
						}

						tempArr[i + 1] = one;

						queue = tempArr;

						return i + 2;
					}
				}

				tempArr[0] = one;

				Array.Copy(queue,0,tempArr,1,queue.Length);

				queue = tempArr;

				return 1;
			}

			tempArr[tempArr.Length - 1] = one;

			queue = tempArr;

			return tempArr.Length;
		}

		public Citizen Service()
		{
			Citizen servicedMan = queue[0];
			Remove();
			return servicedMan;
		}

		public void Remove()
		{
			RemoveAt(0);
		}

		public void RemoveAt(int index)
		{
			for (int i = index; i < queue.Length - 1; i++)
			{
				queue[i] = queue[i + 1];
			}

			Citizen[] tempArr = new Citizen[queue.Length - 1];

			for (int i = 0; i < tempArr.Length; i++)
			{
				tempArr[i] = queue[i];
			}

			queue = tempArr;
		}

		public (bool isContained, int? place) Contains(Citizen one)
		{
			for (int i = 0; i < queue.Length; i++)
			{
				if (one == queue[i])
				{
					return (true, i + 1);
				}
			}

			return (false, null);
		}

		public (Citizen lastOne, int place) ReturnLast()
		{
			return (queue[queue.Length - 1], queue.Length);
		}

		public void Clear()
		{
			queue = new Citizen[] { };
		}
	}
}
