using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T> 
    {
        public T[] listClass;
        // member variables
        public int ItemCount { get { return itemCount; } private set { itemCount = value; } }
        private int itemCount;
        public int capacity;
        public int indexPosition;

        public T this[int i]
        {
            get { return listClass[i]; }
            set { listClass[i] = value; }
        }
        // constructor
        public CustomList()
        {
            itemCount = 0;
            indexPosition = 0;
            capacity = 2;
            listClass = new T[capacity];
        }
        // member methods
        public void Add(T value)
        {
            AddValueToArray(value);
            if (itemCount == capacity)
            {
                T[] temporaryArray = DoubleCapacityOfArray();
                CopyOldArrayToNew(temporaryArray);
            }
        }
        public void AddValueToArray(T value)
        { 
            listClass[indexPosition] = value;
            IncrementArray();
        }
        public T[] DoubleCapacityOfArray()
        {
            T[] temporaryCustomList;
            int newArraylength = capacity * 2;
            capacity = newArraylength;
            return temporaryCustomList = new T[capacity];
        }
        public T[] CopyOldArrayToNew(T[] temporaryCustomList)
        {
            for (int i = 0; i < itemCount; i++)
            {
                temporaryCustomList[i] = listClass[i];
            }
            return listClass = temporaryCustomList;
        }
        public void IncrementArray()
        {
            indexPosition++;
            itemCount++;
        }
        public void Remove(T value)
        {

        }
    }
}
