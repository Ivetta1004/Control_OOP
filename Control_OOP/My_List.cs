using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_OOP
{
    public class My_List
    {
        private object[] _array;
        private int _index;
        private int _capacity = 3;

        public int Count
        {
            get { return _index; }
        }
        public object this[int index]
        {
            get => _array[index];
            set => _array[index] = value;
        }
        public My_List(int capacity)
        {
            _capacity = capacity;
            _array = new object[capacity];
        }
        public My_List() => InitArray();

        private void InitArray()
        {
            _array = new object[_capacity];
        }
        private void ReInitArray()
        {
            object[] tempArr = _array;
            _array = new object[_capacity];

            if (_array != null)
            {
                for (int i = 0; i < tempArr.Length; i++)
                {
                    _array[i] = tempArr[i];
                }
            }
        }
        public void Add(object obj)
        {
            if (_index == _capacity)
            {
                _capacity *= 2;
                ReInitArray();
            }
            _array[_index] = obj;
            _index++;
        }
        public void Insert(int index, object obj)
        {
            object[] tempArr = new object[_array.Length + 1];
            for (int i = 0; i < index; i++)
            {
                tempArr[i] = _array[i];
            }
            for (int i = index; i < _array.Length; i++)
            {
                tempArr[i + 1] = _array[i];
            }
            tempArr[index] = obj;
            _array = tempArr;
        }
        public void Remove(object obj)
        {
            int index = IndexOf(obj);
            if (index >= 0)
                RemoveAt(index);
        }
        public void RemoveAt(int index)
        {
            object[] tempArr = new object[_array.Length - 1];
            for (int i = 0; i < index; i++)
            {
                tempArr[i] = _array[i];
            }
            for (int i = index; i < _array.Length; i++)
            {
                tempArr[i] = _array[i + 1];
            }
            _array = tempArr;
        }
        public void Clear()
        {
            InitArray();
        }
        public bool Contains(object obj)
        {
            foreach (object ar in _array)
            {
                if (ar.Equals(obj))
                    return true;
            }
            return false;
        }
        public int IndexOf(object obj)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i].Equals(obj))
                    return i;
            }
            return -1;
        }
        public object[] ToArray()
        {
            object[] tempArr = new object[_array.Length];
            for (int i = 0; i < tempArr.Length; i++)
            {
                tempArr[i] = _array[i];
            }
            return tempArr;
        }
        public void Reverse()
        {
            object[] tempArr = new object[_array.Length];
            for (int i = _array.Length - 1, j = 0; i >= 0; i--, j++)
            {
                tempArr[j] = _array[i];
            }
            _array = tempArr;
        }
    }
}
