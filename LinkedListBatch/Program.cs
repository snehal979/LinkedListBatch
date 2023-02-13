namespace LinkedListBatch
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Linked list Data structure");
            LinkedList linkedList = new LinkedList();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Hint 1.Add data\n2.Reverse Add Data\n3Appending\n4.Insert data at particular position\n" +
                    "5.Remove First 6.Exit");
                int choice = Convert.ToInt16(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        linkedList.Add(30);
                        linkedList.Add(56);
                        linkedList.Add(70);
                        linkedList.Display();
                        break;
                    case 2:
                        linkedList.AddInReverseOrder(30);
                        linkedList.AddInReverseOrder(56);
                        linkedList.AddInReverseOrder(70);
                        linkedList.Display();
                        break;
                    case 3:
                        linkedList.Appending(30);
                        linkedList.Appending(56);
                        linkedList.Appending(70);
                        linkedList.Display();
                        break;
                    case 4:
                        linkedList.Add(56);
                        linkedList.Add(70);
                        linkedList.InsertedAtParticularPosition(1, 30);
                        linkedList.Display();
                        break;
                    case 5:
                        linkedList.RemoveFirstData();
                        linkedList.Display();
                        break;
                    case 6:
                        flag = false;
                        Console.WriteLine("Exist");
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}