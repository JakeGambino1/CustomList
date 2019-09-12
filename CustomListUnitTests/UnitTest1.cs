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

            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);

            int expected0 = 1;
            int expected1 = 2;
            int expected2 = 3;
            int expected3 = 4;
            int expected4 = 5;

            int actual0 = testList[0];
            int actual1 = testList[1];
            int actual2 = testList[2];
            int actual3 = testList[3];
            int actual4 = testList[4];

            Assert.AreEqual(actual0, expected0);
            Assert.AreEqual(actual1, expected1);
            Assert.AreEqual(actual2, expected2);
            Assert.AreEqual(actual3, expected3);
            Assert.AreEqual(actual4, expected4);
        }

        // SUBTRACT TEST METHODS
        [TestMethod]
        public void Remove_RemoveFirstInstanceOfValueAtDefaultCapacity_IndexForPositionGoesToDefault()
        {
            // Arrange
            CustomList<int> testList = new CustomList<int>();
            testList.Add(1);
            testList.Add(2);
            int expected = 0;
            int actual = testList[0];

            // Act
            testList.Remove(1);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
