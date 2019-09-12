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
        T[] temporaryCustomList;
        // member variables
        public int ItemCount { get { return ItemCount; } private set { ItemCount = value; } }
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
            ItemCount = 0;
            indexPosition = 0;
            capacity = 2;
            listClass = new T[capacity];
        }
        // member methods
        public void Add(T value)
        {
            AddValueToArray(value);
            DoubleCapacityOfArrayIfNecessary();
            CopyOldArrayToNew();
            IncrementArray();
        }
        public void AddValueToArray(T value)
        { 
            listClass[indexPosition] = value;

            if (ItemCount == capacity)
            {
                DoubleCapacityOfArrayIfNecessary();
            }
        }
        public void DoubleCapacityOfArrayIfNecessary()
        {
            int newArraylength = capacity * 2;
            capacity = newArraylength;
            temporaryCustomList = new T[capacity];
        }
        public T[] CopyOldArrayToNew()
        {
            for (int i = 0; i < ItemCount; i++)
            {
                temporaryCustomList[i] = listClass[i];
                listClass = temporaryCustomList;
            }
            return listClass;
        }
        public void IncrementArray()
        {
            indexPosition++;
            ItemCount++;
        }
        public void Remove(T value)
        {

        }
    }
}
