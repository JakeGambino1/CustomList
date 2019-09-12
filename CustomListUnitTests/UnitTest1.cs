using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListProject;
namespace CustomListUnitTests
{
    [TestClass]
    public class UnitTest1
    {

        // ADD TEST METHODS
        [TestMethod]
        public void Add_AddItemToEmptyList_ItemGoesToIndexZero()
        {
            CustomList<string> testList = new CustomList<string>();
            string expected = "Murdock";
            string actual;

            testList.Add("Murdock");
            actual = testList[0];

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddItemToEmptyList_CountIncrementsByOne()
        {
            CustomList<int> testList = new CustomList<int>();
            int expected = 1;
            int actual;

            testList.Add(82);
            actual = testList.indexPosition;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddMultipleItemsToList_CountIncrementsByOne()
        {
            CustomList<int> testList = new CustomList<int>();
            int expected = 2;
            int actual;

            testList.Add(1);
            testList.Add(2);
            actual = testList.ItemCount;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddItemsToList_DoubleCapacityOfArray()
        {
            CustomList<int> testList = new CustomList<int>();
            int expected = 4;
            int actual;

            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            actual = testList.capacity;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddItemsToFullArray_IndicesCopiedOver()
        {
            CustomList<int> testList = new CustomList<int>();
            int expected0 = 1;
            int expected1 = 2;
            int expected2 = 3;
            int expected3 = 4;
            int expected4 = 5;

            int actual0;
            int actual1;
            int actual2;
            int actual3;
            int actual4;

            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);

            actual0 = testList[0];
            actual1 = testList[1];
            actual2 = testList[2];
            actual3 = testList[3];
            actual4 = testList[4];

            Assert.AreEqual(actual0, expected0);
            Assert.AreEqual(actual1, expected1);
            Assert.AreEqual(actual2, expected2);
            Assert.AreEqual(actual3, expected3);
            Assert.AreEqual(actual4, expected4);
        }

        // SUBTRACT TEST METHODS
        [TestMethod]
        public void Remove_RemoveFirstInstanceOfValue_FollowingElementShiftsDownOneIndex()
        {
            CustomList<int> testList = new CustomList<int>();
            testList.Add(1);
            testList.Add(2);
            int expected0 = 2;
            int expected1 = 0;
            int actual0;
            int actual1;

            testList.Remove(1);
            actual0 = testList[0];
            actual1 = testList[1];

            Assert.AreEqual(expected0, actual0);
            Assert.AreEqual(expected1, actual1);
        }
        [TestMethod]
        public void Remove_RemoveInstanceOfValue_ReduceItemCountByOne()
        {
            CustomList<int> testList = new CustomList<int>();
            testList.Add(1);
            testList.Add(2);
            int expected = 1;
            int actual;

            testList.Remove(1);
            actual = testList.ItemCount;

            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void Remove_RemoveMultipleItems_UpdateItemCountToReflectNumberRemoved()
        {
            CustomList<int> testList = new CustomList<int>();
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            int expected = 2;
            int actual;

            testList.Remove(2);
            testList.Remove(3);
            actual = testList.ItemCount;

            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void Remove_RemoveMultipleItems_UpdateArrayIndexPosition()
        {
            CustomList<int> testList = new CustomList<int>();
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            int expected0 = 2;
            int expected1 = 4;
            int actual0;
            int actual1;

            testList.Remove(1);
            testList.Remove(3);
            actual0 = testList[0];
            actual1 = testList[1];

            Assert.AreEqual(actual0, expected0);
            Assert.AreEqual(actual1, expected1);
        }
        [TestMethod]
        public void Remove_RemoveItemThatDoesntExist_ThrowException()
        {
            CustomList<int> testList = new CustomList<int>();
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            int expected0 = 1;
            int expected1 = 2;
            int expected2 = 3;
            int expected3 = 4;

            int actual0;
            int actual1;
            int actual2;
            int actual3;

            testList.Remove(5);
            actual0 = testList[0];
            actual1 = testList[1];
            actual2 = testList[2];
            actual3 = testList[3];

            Assert.AreEqual(expected0, actual0);
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);

        }
        public void Remove_RemoveItemValue_OnlyRemovesFirstInstanceOfValue()
        {
            CustomList<int> testList = new CustomList<int>();
            testList.Add(1);
            testList.Add(2);
            testList.Add(2);
            testList.Add(2);
            int expected = 2;
            int actual1;
            int actual2;

            testList.Remove(2);
            actual1 = testList[1];
            actual2 = testList[2];

            Assert.AreEqual(actual1, expected);
            Assert.AreEqual(actual2, expected);
        }

        // TOSTRING OVERRIDE METHOD TESTS
        [TestMethod]
        public void Convert_ConvertToString_ListInformationBecomesString()
        {
            CustomList<int> testList = new CustomList<int>();
            testList.Add(1);
            string expected = "1";
            string actual;

            testList.ConvertCustomTListToStringList();
            actual = $"{testList[0]}";

            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void Convert_ConvertMultipleItemsToString_ListInformationBecomesString()
        {
            CustomList<int> testList = new CustomList<int>();
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);

            string expected0 = "1";
            string expected1 = "2";
            string expected2 = "3";
            string expected3 = "4";
            string expected4 = "5";
            string actual0;
            string actual1;
            string actual2;
            string actual3;
            string actual4;


            testList.ConvertCustomTListToStringList();
            actual0 = $"{testList[0]}";
            actual1 = $"{testList[1]}";
            actual2 = $"{testList[2]}";
            actual3 = $"{testList[3]}";
            actual4 = $"{testList[4]}";

            Assert.AreEqual(actual0, expected0);
            Assert.AreEqual(actual1, expected1);
            Assert.AreEqual(actual2, expected2);
            Assert.AreEqual(actual3, expected3);
            Assert.AreEqual(actual4, expected4);
        }
    }
}
