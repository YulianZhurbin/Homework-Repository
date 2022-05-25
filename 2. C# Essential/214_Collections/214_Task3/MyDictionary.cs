using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _214_Task3
{
	public class MyDictionary<TKey, TValue>
	{
		TKey[] keys;
		TValue[] values;

		public MyDictionary()
		{
			keys = new TKey[0];
			values = new TValue[0];
		}

		public TValue this[TKey index]
		{
			get
			{
				for (int i = 0; i < values.Length; i++)
				{
					if ((object)index == (object)keys[i])
					{
						return values[i];
					}
				}

				return default(TValue);
			}
		}

		public TValue this[int index]
		{
			get
			{
				return values[index];
			}
		}

		public int Count
		{
			get
			{
				return keys.Length;
			}
		}

		public void Add(TKey key, TValue value)
		{
			TKey[] tempKeys = new TKey[keys.Length + 1];
			for (int i = 0; i < keys.Length; i++)
			{
				tempKeys[i] = keys[i];
			}
			tempKeys[keys.Length] = key;
			keys = tempKeys;

			TValue[] tempValues = new TValue[values.Length + 1];
			for (int i = 0; i < values.Length; i++)
			{
				tempValues[i] = values[i];
			}
			tempValues[values.Length] = value;
			values = tempValues;
		}

		public IEnumerable<TKey> GetCollection()
		{
			for (int i = 0; i < keys.Length; i++)
			{
				yield return keys[i];
			}
		}
	}
}
