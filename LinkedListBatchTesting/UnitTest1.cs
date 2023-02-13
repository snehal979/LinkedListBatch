using LinkedListBatch;
namespace LinkedListBatchTesting
{
    [TestClass]
    public class UnitTest1
    {
        LinkedList linkedList = new LinkedList();
        /// <summary>
        /// Uc7 Search data Testing
        /// </summary>
        [TestMethod]
        public void TestMethod1()
        {
            //Add Data into the linkedlist
            linkedList.Add(30);
            linkedList.Add(56);
            linkedList.Add(70);
            //AAA test method
            int b = linkedList.Search(30);

            int actual = 1; // 40 at 1 position
            Assert.AreEqual(actual, b);
        }
    }
}