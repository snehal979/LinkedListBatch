using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedListBatch
{
    public class LinkedList
    {
        public Node head;
        /// <summary>
        /// Uc1 Add Data On Linked List
        /// </summary>
        /// <param name="data"></param>
        public int Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = this.head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into Linked List", node.data);
            return node.data;
            
        }
        /// <summary>
        /// Uc2 Add Data In Reverse Order
        /// </summary>
        /// <param name="data"></param>
        public void AddInReverseOrder(int data)
        {
            Node newNode = new Node(data);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node temp = this.head;
                head = newNode;
                head.next= temp;
            }
           // Console.WriteLine("{0} inserted into Linked List", newNode.data);
        }
        /// <summary>
        /// Uc3 Appending data
        /// </summary>
        /// <param name="data"></param>
        public void Appending(int data)
        {
            AddInReverseOrder(data);
        }
        /// <summary>
        /// Uc4-Insert data in particular position
        /// </summary>
        /// <param name="position"></param>
        /// <param name="data"></param>
        public void InsertedAtParticularPosition(int position, int data)
        {
            Node newestNode = new Node(data);
            if (this.head == null)
            {
                Console.WriteLine(newestNode);
            }
            if (position==0)
            {
                newestNode.next = this.head;
                this.head = newestNode;
                Console.WriteLine(this.head);
            }
            else
            {
                Node prev = null;
                Node current = this.head;
                int count = 0;
                while (current != null && count < position)
                {
                    prev = current;
                    current = current.next;
                    count++;
                }
                newestNode.next  = prev.next;
                prev.next =newestNode;
                Console.WriteLine(this.head);
            }
        }
        /// <summary>
        /// uc5 First data delect
        /// </summary>
        public void RemoveFirstData()
        {
            if (this.head == null)
            {
                Console.WriteLine("linked list is empty");
            }
            else
            {
                this.head = this.head.next;
            }
        }
        /// <summary>
        /// uc6 Remove last data
        /// </summary>
        public void RemoveLastData()
        {
            if (this.head == null)
            {
                Console.WriteLine("linked list is empty");
            }
            else if (this.head.next == null)
            {
                this.head = null;
            }
            else
            {
                Node newNode = this.head;
                while (newNode.next.next != null)
                {
                    newNode = newNode.next;
                }
                newNode.next = null;
            }
        }
        /// <summary>
        /// Uc7-Search Data present in linked list
        /// </summary>
        /// <param name="value"></param>
        
        //public int Search(int value)
        //{
        //    Node temp = this.head;

        //    if (temp.data == value)
        //    {
        //        return 1;
        //    }
        //    else
        //    {
        //        return -1;
        //    }
        //}
        public int SearchNew(int data)
        {
            Node temp = head;
            int count = 0;
            if (temp == null)
            {
                return -1;
            }
            else
            {
                while (temp!=null)
                {
                    if (temp.data==data)
                    {
                        count++;
                        break;
                    }
                    temp =temp.next;
                }
                return count;
            }
        }
        /// <summary>
        /// Uc9 Delect and count size
        /// </summary>
        /// <returns></returns>
        public int Size()
        {
            Node temp = this.head;
            int count = 0;
            if (temp == null)
            {
                Console.WriteLine("linked list is empty");
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data+" ");
                temp = temp.next;
                count++;
            }
            return count;
        }
        /// <summary>
        /// Uc9_Delect at particular position
        /// </summary>
        /// <param name="position"></param>
        public void DelectAtParticularPosition(int position)
        {
            if (this.head == null)
            {
                Console.WriteLine("linked list is empty");
            }
            Node temp = this.head;
            if (position == 0)
            {
                this.head = temp.next;
            }
            int count = 0;
            while (temp != null && count < position)
            {
                temp = temp.next;
                count++;
            }
            Node next = temp.next.next;
            temp.next = next;
            Size();
        }
        /// <summary>
        /// Uc10 Sort Data
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public void SortOrderLinkedList()
        {
            if (this.head == null)
            {
                Console.WriteLine("n");
            }
            else
            {
                int temp; //variable for swapping
                Node current = this.head;
                Node index = null;
                while (current != null)
                {
                    index = current.next;
                    while (index != null)
                    {
                        if (current.data.CompareTo(index.data)>0)
                        {
                            temp = current.data;
                            current.data = index.data;
                            index.data = temp;
                        }
                        index = index.next;
                    }
                    current = current.next;
                }
            }
        }
        /// <summary>
        /// Display Linked List
        /// </summary>
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("linked list is empty");
            }
            else
            {
                while (temp != null)
                {
                    Console.WriteLine(temp.data +" ");
                    temp = temp.next;
                }
            }
        }
    }
}
