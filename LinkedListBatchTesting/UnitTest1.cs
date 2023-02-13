using LinkedListBatch;
namespace LinkedListBatchTesting
{
    [TestClass]
    public class UnitTest1
    {
        LinkedList linkedList = new LinkedList();
        /// <summary>
        ///  Add Data
        /// </summary>
        [TestMethod]
        public void AddData_WhenAnalyse_ShouldAddDataLinkedList()
        {
            //Add Data into the linkedlist
            linkedList.Add(30);
            linkedList.Add(56);
            linkedList.Add(70);
        }
        /// <summary>
        /// Uc7 Search data Testing
        /// </summary>
        [TestMethod]
        public void SearchData_WhenAnalyse_ShouldAddDataLinkedList()
        {
            AddData_WhenAnalyse_ShouldAddDataLinkedList();
            //AAA test method
            int b = linkedList.SearchNew(30);

            int actual = 1; // 30 at 1 position
            Assert.AreEqual(actual, b);
        }
        /// <summary>
        /// Uc8-Data add at particular position
        /// </summary>
        [TestMethod]
        public void InsertData_WhenAnalyse_ShouldAddDataLinkedList_AtParticularPosition()
        {
            AddData_WhenAnalyse_ShouldAddDataLinkedList();
            linkedList.InsertedAtParticularPosition(1, 40);
            //linkedList.Display();
            //AAA test method
            int SearchData = linkedList.SearchNew(40);

            int actual = 1; // 40 at 1 position
            Assert.AreEqual(actual, SearchData);
        }

    }
}