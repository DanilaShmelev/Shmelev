using System;

namespace DynamicArray.Tests
{
    public class ForTestDispose : IDisposable
    {
        public bool isDisposed = false;

        public void Dispose()
        {
            isDisposed = true;
        }
    }

    [TestClass]
    public class DynamicArrayTests
    {
        private DynamicArray<int> test;

        [TestInitialize]
        public void Initialize()
        {
            test = new();
        }

        [TestMethod]
        public void ConstructorTest8Capacity()
        {
            int expectedCapacity = 8;
            int expectedLength = 0;

            test = new();

            Assert.AreEqual(expectedCapacity, test.Capacity);
            Assert.AreEqual(expectedLength, test.Length);
        }

        [DataTestMethod]
        [DataRow(0)] 
        [DataRow(5)]
        [DataRow(3)]
        [DataRow(15)]
        public void ConstructorGoodCapacityTests(int expectedCapacity)
        {
            int expectedLength = 0;

            test = new(expectedCapacity);

            Assert.AreEqual(expectedCapacity, test.Capacity);
            Assert.AreEqual(expectedLength, test.Length);
        }

        [DataTestMethod]
        [DataRow(-5)]
        [DataRow(-500)] 
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ConstructorBadCapacityTests(int capacity)
        {
            test = new(capacity);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))] 
        public void ConstructorNullTest()
        {
            test = new(null);
        }

        [TestMethod]
        public void ConstructorCollectionArrayTest() 
        {
            int expectedCapacity = 5; 
            int expectedLength = 5; 
            int[] expected = { 1, 2, 3, 5, 8 };

            test = new(expected);

            CollectionAssert.AreEqual(expected, test);
            Assert.AreEqual(expectedCapacity, test.Capacity); 
            Assert.AreEqual(expectedLength, test.Length); 
        }

        [TestMethod]
        public void AddRangeTest() 
        {
            int expectedCapacity = 32; 
            int expectedLength = 30; 
            int[] array = { 2, 3, 5, 8, 95, 11, 82, 123, 16, 76, 34, 33, 1, 7, 45, 86, 45, 2345, 8658, 9687, 16, 76, 34, 33, 1, 7, 45, 86, 45 };
            int[] expected = { 1, 2, 3, 5, 8, 95, 11, 82, 123, 16, 76, 34, 33, 1, 7, 45, 86, 45, 2345, 8658, 9687, 16, 76, 34, 33, 1, 7, 45, 86, 45 };

            test = new(0); 
            test.Add(1);

            test.AddRange(array);

            CollectionAssert.AreEqual(expected, test);
            Assert.AreEqual(expectedCapacity, test.Capacity); 
            Assert.AreEqual(expectedLength, test.Length); 
        }

        [TestMethod]
        public void RemoveTest() 
        {
            int expectedCapacity = 13; 
            int expectedLength = 6; 
            int[] array = { 1, 3, 4, 5, 3, 3, 5, 5, 3, 3, 3, 7, 3 };
            int[] expected = { 1, 4, 5, 5, 5, 7 };

            test = new(array);
            test.Remove(3);

            CollectionAssert.AreEqual(expected, test);
            Assert.AreEqual(expectedCapacity, test.Capacity); 
            Assert.AreEqual(expectedLength, test.Length); 
        }

        [TestMethod]
        public void InsertGoodTest() 
        {
            int expectedCapacity = 12; 
            int expectedLength = 7; 
            int[] array = { 1, 3, 5, 7, 1, 2 };
            int[] expected = { 1, 3, 5, 7, 8, 1, 2 };

            test = new(array);
            test.Insert(8, 4);

            CollectionAssert.AreEqual(expected, test);
            Assert.AreEqual(expectedCapacity, test.Capacity);
            Assert.AreEqual(expectedLength, test.Length);
        }

        [DataTestMethod]
        [DataRow(-1)]
        [DataRow(16)]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void InsertBadTests(int index) 
        {
            int[] array = { 1, 3, 5, 7, 1, 2 };

            test = new(array);
            test.Insert(1, index);
        }

        [TestMethod]
        public void ForEachTest() 
        {
            int[] expected = { 1, 5, 8, 1, 3, 9, 2 };
            int[] result = new int[expected.Length];

            test = new(expected);

            int i = 0;
            foreach (var item in test)
            {
                result[i] = item;
                i++;
            }

            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void IndexatorGoodTest() 
        {
            int index = 2;
            int expected = 5;
            int[] array = { 1, 5, 8, 1, 3, 9, 2 };

            test = new(array);

            test[index] = expected;

            Assert.AreEqual(expected, test[index]);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void IndexatorBadTest() 
        {
            int index = 18;
            int expected = 5;
            int[] array = { 1, 5, 8, 1, 3, 9, 2 };

            test = new(array);

            test[index] = expected;
        }

        [TestMethod]
        public void EqualsGoodTest() 
        {
            int[] array = { 1, 5, 8, 1, 3, 9, 2 };

            test = new(array);
            DynamicArray<int> obj = new(array);

            bool result = test.Equals(obj);

            Assert.IsTrue(result); 
        }

        [TestMethod]
        public void FirstEqualsBadTest() 
        {
            int[] array = { 1, 5, 8, 1, 3, 9, 2 };

            test = new(array);
            DynamicArray<int> obj = new(array);
            obj.Add(1);

            bool result = test.Equals(obj);

            Assert.IsFalse(result); 
        }

        [TestMethod]
        public void SecondEqualsBadTest() 
        {
            int[] array = { 1, 5, 8, 1, 3, 9, 2 };

            test = new(array);

            bool result = test.Equals(null);

            Assert.IsFalse(result); 
        }

        [TestMethod]
        public void EqualComparisonOperatorGoodTest() 
        {
            int[] array = { 1, 5, 8, 1, 3, 9, 2 };

            test = new(array);
            DynamicArray<int> obj = new(array);

            bool result = (obj == test);

            Assert.IsTrue(result); 
        }

        [TestMethod]
        public void EqualComparisonOperatorBadTest() 
        {
            int[] array = { 1, 5, 8, 1, 3, 9, 2 }; 

            test = new(array);
            DynamicArray<int> obj = new(array);
            obj.Add(1);

            bool result = (obj == test);

            Assert.IsFalse(result); 
        }

        [TestMethod]
        public void NoEqualComparisonOperatorGoodTest() 
        {
            int[] array = { 1, 5, 8, 1, 3, 9, 2 }; 

            test = new(array);
            DynamicArray<int> obj = new(array);

            bool result = (null != test); ; ;

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void NoEqualComparisonOperatorBadTest() 
        {
            int[] array = { 1, 5, 8, 1, 3, 9, 2 };

            test = new(array);
            DynamicArray<int> obj = new(array);
            obj.Add(1);

            bool result = (obj != test);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void ExplicitOperatorTest() 
        {
            int[] array = { 1, 5, 8, 1, 3, 9, 2 };

            test = new(array);
            int[] result = (int[])test;

            CollectionAssert.AreEqual(array, result);
        }

        [TestMethod]
        public void ImplicitOperatorTest() 
        {
            int[] array = { 1, 5, 8, 1, 3, 9, 2 };

            DynamicArray<int> obj = array;

            CollectionAssert.AreEqual(obj, array);
        }

        [TestMethod]
        public void FirstAddTest() 
        {
            int expectedCapacity = 8; 
            int expectedLength = 1; 
            int[] expected = { 1 };

            test.Add(1);

            CollectionAssert.AreEqual(expected, test);
            Assert.AreEqual(expectedCapacity, test.Capacity); 
            Assert.AreEqual(expectedLength, test.Length); 
        }

        [TestMethod]
        public void SecondAddTest()
        {
            int expectedCapacity = 8; 
            int expectedLength = 3; 
            int[] expected = { 1, 2, 3 };

            test.Add(1);
            test.Add(2);
            test.Add(3);

            CollectionAssert.AreEqual(expected, test);
            Assert.AreEqual(expectedCapacity, test.Capacity); 
            Assert.AreEqual(expectedLength, test.Length); 
        }

        [TestMethod]
        public void ThirdAddTest() 
        {
            int expectedCapacity = 4; 
            int expectedLength = 3; 
            int[] expected = { 1, 2, 3 };

            test = new(0);

            test.Add(1);
            test.Add(2);
            test.Add(3);

            CollectionAssert.AreEqual(expected, test);
            Assert.AreEqual(expectedCapacity, test.Capacity); 
            Assert.AreEqual(expectedLength, test.Length);
        }

        [TestMethod]
        public void DisposeTest()
        {
            int expectedCapacity = 0;
            int expectedLength = 0;
            DynamicArray<ForTestDispose> obj = new DynamicArray<ForTestDispose>();

            obj.Add(new ForTestDispose());
            obj.Add(new ForTestDispose());
            obj.Add(new ForTestDispose());

            ForTestDispose dis = new ForTestDispose();

            obj.Add(dis); 
            obj.Dispose();

            Assert.AreEqual(expectedCapacity, obj.Capacity);
            Assert.AreEqual(expectedLength, obj.Length);
            Assert.IsTrue(obj.isDisposed);
            Assert.IsTrue(dis.isDisposed);
        }

        [TestMethod]
        public void FirstEventTest()
        {
            int oldCapacity = 2;
            int newCapactiy = 4;
            bool isWorked = false;

            void NotificationMessage(object sender, DynamicArrayEventArgs e)
            {
                Assert.AreEqual(oldCapacity, e.OldCapacity);
                Assert.AreEqual(newCapactiy, e.NewCapacity);
                isWorked = true;
            }

            test = new(2);
            test.Notify += NotificationMessage;

            test.Add(1);
            test.Add(2);
            test.Add(3);
            test.Add(4);

            Assert.IsTrue(isWorked);
        }

        [TestMethod]
        public void SecondEventTest()
        {
            int oldCapacity = 2;
            int newCapactiy = 4;
            bool isWorked = false;
            int[] array = { 1, 2 };

            void NotificationMessage(object sender, DynamicArrayEventArgs e)
            {
                Assert.AreEqual(oldCapacity, e.OldCapacity);
                Assert.AreEqual(newCapactiy, e.NewCapacity);
                isWorked = true;
            }

            test = new(array);
            test.Notify += NotificationMessage;

            test.Insert(1, 1);

            Assert.IsTrue(isWorked);
        }
    }
}