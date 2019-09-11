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
        public int ItemCount;
        public int Capacity;
        public int IndexPosition;

        public T this[int i]
        {
            get { return listClass[i]; }
            set { listClass[i] = value; }
        }

        // constructor
        public CustomList()
        {
            ItemCount = 1;
            IndexPosition = 0;
            Capacity = 2;
            listClass = new T[Capacity];
        }

        // member methods
        public void Add(T value)
        {
            AddValueToArray(value);
            temporaryCustomList = DoubleCapacityOfArrayIfNecessary();
            CopyOldArrayToNew(listClass, temporaryCustomList);
            IncrementArray();
        }
        public void AddValueToArray(T value)
        { 
            listClass[IndexPosition] = value;

            if (ItemCount == Capacity)
            {
                DoubleCapacityOfArrayIfNecessary();
            }
        }
        public T[] DoubleCapacityOfArrayIfNecessary()
        {
            return temporaryCustomList = new T[Capacity * 2];
        }

        public T[] CopyOldArrayToNew(T[] listClass, T[] TemporaryCustomList)
        {
            for (int i = 0; i < ItemCount; i++)
            {
                TemporaryCustomList[i] = listClass[i];
                listClass = TemporaryCustomList;
            }
            return listClass;
        }

        public void IncrementArray()
        {
            IndexPosition++;
            ItemCount++;
        }

        public void Remove(T value)
        {

        }
    }
}
