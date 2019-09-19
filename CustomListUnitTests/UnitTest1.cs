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
            actual = testList.Count;

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
            actual = testList.Capacity;

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

            Assert.AreEqual(expected0, actual0);
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);
            Assert.AreEqual(expected4, actual4);
        }
        // SUBTRACT TEST METHODS
        [TestMethod]
        public void Remove_RemoveFirstInstanceOfValue_FollowingElementShiftsDownOneIndex()
        {
            CustomList<int> testList = new CustomList<int>();
            testList.Add(1);
            testList.Add(2);
            int expected0 = 2;
            int actual0;

            testList.Remove(1);
            actual0 = testList[0];

            Assert.AreEqual(expected0, actual0);
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
            actual = testList.Count;

            Assert.AreEqual(expected, actual);
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
            actual = testList.Count;

            Assert.AreEqual(expected, actual);
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

            Assert.AreEqual(expected0, actual0);
            Assert.AreEqual(expected1, actual1);
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

            Assert.AreEqual(expected, actual1);
            Assert.AreEqual(expected, actual2);
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

            Assert.AreEqual(expected, actual);
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

            Assert.AreEqual(expected0, actual0);
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);
            Assert.AreEqual(expected4, actual4);
        }
        [TestMethod]
        public void Stringify_StringifyAList_EntireListReturnedAsString()
        {
            CustomList<int> testList = new CustomList<int>();
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);

            string expected0 = "12345";
            string actual0;

            actual0 = testList.ToString();

            Assert.AreEqual(expected0, actual0);
        }

        [TestMethod]
        public void Add_AddTwoCustomListsTogether_ReturnNewCombinedList()
        {
            CustomList<int> testListOne = new CustomList<int>();
            CustomList<int> testListTwo = new CustomList<int>();
            CustomList<int> combinedList = new CustomList<int>();
            int actual0;
            int actual1;
            int actual2;
            int actual3;
            int actual4;
            int actual5;

            testListOne.Add(1);
            testListOne.Add(2);
            testListOne.Add(3);

            testListTwo.Add(4);
            testListTwo.Add(5);
            testListTwo.Add(6);
            int expected0 = 1;
            int expected1 = 2;
            int expected2 = 3;
            int expected3 = 4;
            int expected4 = 5;
            int expected5 = 6;

            combinedList = testListOne + testListTwo;
            actual0 = combinedList[0];
            actual1 = combinedList[1];
            actual2 = combinedList[2];
            actual3 = combinedList[3];
            actual4 = combinedList[4];
            actual5 = combinedList[5];

            Assert.AreEqual(expected0, actual0);
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);
            Assert.AreEqual(expected4, actual4);
            Assert.AreEqual(expected5, actual5);
        }
        [TestMethod]
        public void Subtract_SubtractListFromList_ReturnRemainingValues()
        {
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> remainingList = new CustomList<int>();
            int actual0;

            listOne.Add(1);
            listOne.Add(3);
            listOne.Add(5);

            listTwo.Add(1);
            listTwo.Add(3);
            listTwo.Add(6);

            int expected0 = 5;

            remainingList = listOne - listTwo;
            actual0 = remainingList[0];

            Assert.AreEqual(expected0, actual0);
        }

        [TestMethod]
        public void Zip_TakeTwoListsAndZipper_NewListShouldAlternateValuesFromOtherTwoLists()
        {
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> zipList = new CustomList<int>();
            int expected0 = 1;
            int expected1 = 2;
            int expected2 = 3;
            int expected3 = 4;
            int actual0;
            int actual1;
            int actual2;
            int actual3;

            listOne.Add(1);
            listOne.Add(3);
            listOne.Add(5);

            listTwo.Add(2);
            listTwo.Add(4);
            listTwo.Add(6);

            zipList.Zipper(listOne, listTwo);

            actual0 = zipList[0];
            actual1 = zipList[1];
            actual2 = zipList[2];
            actual3 = zipList[3];

            Assert.AreEqual(expected0, actual0);
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);
        }
        [TestMethod]
        public void Zip_ZipUnequalListsTogether_ShouldOnlyAddDefinedValues()
        {
            CustomList<int> listOne = new CustomList<int>();
            CustomList<int> listTwo = new CustomList<int>();
            CustomList<int> zipList = new CustomList<int>();
            int expected0 = 1;
            int expected1 = 2;
            int expected2 = 3;
            int expected3 = 5;
            int actual0;
            int actual1;
            int actual2;
            int actual3;

            listOne.Add(1);
            listOne.Add(3);
            listOne.Add(5);

            listTwo.Add(2);

            zipList.Zipper(listOne, listTwo);

            actual0 = zipList[0];
            actual1 = zipList[1];
            actual2 = zipList[2];
            actual3 = zipList[3];

            Assert.AreEqual(expected0, actual0);
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
            Assert.AreEqual(expected3, actual3);
        }
    }
}
