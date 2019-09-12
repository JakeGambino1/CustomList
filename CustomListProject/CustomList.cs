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
        // ADD METHOD
        public void Add(T value)
        {
            AddValueToArray(value);
            if (itemCount == capacity)
            {
                T[] temporaryArray = DoubleCapacityOfArray();
                CopyItemsToArray(temporaryArray);
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
            temporaryCustomList = new T[capacity];
            return temporaryCustomList;
        }
        public T[] CopyItemsToArray(T[] temporaryCustomList)
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


        // REMOVE METHOD
        public void Remove(T value)
        {
            int valueFound = SearchArray(value, listClass);

            if (valueFound >= 0) {
                ShiftListItems(valueFound);
                itemCount--;
            }
        }
        public int SearchArray(T inputValue, T[] listClass)
        {
            for (int i = 0; i < ItemCount; i++)
            {
                T arrayItemValue = listClass[i];
                if (inputValue.Equals(arrayItemValue))
                {
                    return i;
                }
            }
            return -1;
        }
        public void ShiftListItems(int valueFound)
        {
            for (int i = valueFound; i < ItemCount; i++)
            {
                listClass[i] = listClass[i + 1];
            }
        }

        // TOSTRING METHOD
        public override string ToString()
        {
            return "";
        }
        public void ConvertCustomTListToStringList()
        {
            CustomList<string> stringList = new CustomList<string>();
            for (int i = 0; i < itemCount; i++)
            {
                stringList.Add($"{listClass[i]}");
            }
        }
    }
}
