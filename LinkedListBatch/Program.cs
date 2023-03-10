using System.ComponentModel;

namespace LinkedListBatch
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Linked list Data structure");
            try
            {


                LinkedList linkedList = new LinkedList();
                bool flag = true;
                while (flag)
                {
                    Console.WriteLine("Hint 1.Add data\n2.Reverse Add Data\n3Appending\n4.Insert data at particular position\n" +
                        "5.Remove First \n 6.Remove Last data \n 7.Search\n8.Data add At Postion\n9.Size \n" +
                        "10.Delect at particular position\n11.Sort Data \n12Exit");
                    int choice = Convert.ToInt16(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            linkedList.Add(80);
                            linkedList.Add(30);
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
                            linkedList.RemoveLastData();
                            linkedList.Display();
                            break;
                        case 7:
                            //int a =linkedList.Search(40);
                            int a = linkedList.SearchNew(40);
                            Console.WriteLine(a);
                            if (a >= 1)
                            {
                                Console.WriteLine("Data is present");
                            }
                            else
                            {
                                Console.WriteLine("Data is not present");
                            }
                            break;
                        case 8:
                            linkedList.InsertedAtParticularPosition(1, 40);
                            linkedList.Display();
                            break;
                        case 9:
                            int size = linkedList.Size();
                            Console.WriteLine("size of the linked list"+size);
                            break;
                        case 10:
                            linkedList.DelectAtParticularPosition(1);
                            break;
                        case 11:
                            linkedList.SortOrderLinkedList();
                            linkedList.Display();
                            break;
                        case 12:
                            flag = false;
                            Console.WriteLine("Exist");
                            break;
                    }
                }
                Console.ReadLine();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}