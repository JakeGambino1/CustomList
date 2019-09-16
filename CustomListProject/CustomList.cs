using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T>
    {
        public T[] list;
        public T[] combinedList;
        // member variables
        public int Count { get { return count; } private set { count = value; } }
        private int count;
        public int capacity;
        public int indexPosition;

        public T this[int i]
        {
            get { return list[i]; }
            set { list[i] = value; }
        }
        // constructor
        public CustomList()
        {
            count = 0;
            indexPosition = 0;
            capacity = 2;
            list = new T[capacity];
        }
        // member methods
        // + OPERATOR OVERLOAD
        public static CustomList<T> operator +(CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> combinedList = new CustomList<T>();
            combinedList.AddLists(listOne);
            combinedList.AddLists(listTwo);
            return combinedList;
        }
        public void AddLists(CustomList<T> list)
        {
            for (int i = 0; i < list.count; i++)
            {
                Add(list[i]);
            }
        }
        // - OPERATOR OVERLOAD
        //public static CustomList<T> operator -(CustomList<T> listOne, CustomList<T> listTwo)
        //{

        //}
        // ADD METHOD
        public void Add(T value)
        {
            AddValueToArray(value);
            if (count == capacity)
            {
                T[] temporaryArray = DoubleCapacityOfArray();
                CopyItemsToArray(temporaryArray);
            }
        }
        public void AddValueToArray(T value)
        { 
            list[indexPosition] = value;
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
            for (int i = 0; i < count; i++)
            {
                temporaryCustomList[i] = list[i];
            }
            return list = temporaryCustomList;
        }
        public void IncrementArray()
        {
            indexPosition++;
            count++;
        }
        // REMOVE METHOD
        public void Remove(T value)
        {
            int valueIfFound = SearchArray(value, list);

            if (valueIfFound >= 0) {
                ShiftListItems(valueIfFound);
                count--;
            }
        }
        public int SearchArray(T inputValue, T[] listClass)
        {
            for (int i = 0; i < Count; i++)
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
            for (int i = valueFound; i < Count; i++)
            {
                list[i] = list[i + 1];
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
            for (int i = 0; i < count; i++)
            {
                stringList.Add($"{list[i]}");
            }
        }
        // ZIPPER METHOD
        public T[] Zipper(CustomList<T> listOne, CustomList<T> listTwo)
        {
            list = new T[listOne.count + listTwo.count];
            for (int i = 0; i < capacity; i++)
            {
                if (listOne.count > i)
                {
                    Add(listOne[i]);
                }
                if (listTwo.count > i)
                {
                    Add(listTwo[i]);
                }
            }
            return list;
        }
    }
}
