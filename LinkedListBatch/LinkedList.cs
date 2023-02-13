using System;
using System.Collections.Generic;
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
        public void Add(int data)
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
           // Console.WriteLine("{0} inserted into Linked List", node.data);
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
