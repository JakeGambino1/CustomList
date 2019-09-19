using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T> : IEnumerable
    {
        public T[] list;
        public T[] combinedList;
        // member variables
        public int Count { get { return count; } private set { count = value; } }
        private int count;
        public int Capacity { get { return capacity; } private set { capacity = value; } }
        private int capacity;
        public int indexPosition;

        public T this[int i]
        {
            get {
                if (i < 0 || i >= count)
                {
                    throw new ArgumentOutOfRangeException("You fool, do something else.");
                }
                return list[i]; }
            set {
                if (i >= 0 || i < count)
                {
                    list[i] = value;
                }
            }
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
            CustomList<T> AddedList = new CustomList<T>();
            AddedList.AddLists(listOne);
            AddedList.AddLists(listTwo);
            return AddedList;
        }
        public void AddLists(CustomList<T> list)
        {
            for (int i = 0; i < list.count; i++)
            {
                Add(list[i]);
            }
        }
        // - OPERATOR OVERLOAD
        public static CustomList<T> operator -(CustomList<T> listOne, CustomList<T> listTwo)
        {
            for (int i = 0; i < listOne.count; i++)
            {
                for (int j = 0; j < listTwo.count; j++)
                {
                    if (listOne[i].Equals(listTwo[j]))
                    {
                        listOne.Remove(listOne[i]);
                    }
                }
            }
            return listOne;
        }
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
            StringBuilder stringBuilder = new StringBuilder();
            foreach (T value in list)
            {
                return "";
            }
            return "Nope";
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
        public CustomList<T> Zipper(CustomList<T> listOne, CustomList<T> listTwo)
        {
            CustomList<T> list = new CustomList<T>();
            list.Capacity = listOne.count + listTwo.count;
            for (int i = 0; i < listOne.count + listTwo.count; i++)
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
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return list[i];
            }
            yield return "The list done gone and ran out of things.";
        }
    }
}
