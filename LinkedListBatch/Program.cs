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
                Console.WriteLine("Hint 1.Add data 2.Reverse Add Data 3.Exit");
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
                        flag = false;
                        Console.WriteLine("Exist");
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}