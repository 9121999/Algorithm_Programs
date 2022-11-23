using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndSearches
{
    internal class Generics
    {
        public class LinkedListGeneric<T>
        {
            public Node<T> head;
            public void Add(T data)
            {
                Node<T> node = new Node<T>(data);
                if (this.head == null)
                {
                    this.head = node;

                }
                else
                {
                    Node<T> temp = head;
                    while (temp.next != null)
                    {
                        temp = temp.next;
                    }
                    temp.next = node;
                }
                Console.WriteLine("{0} inserted into linked list", node.data);
            }

            public void Delete()
            {
                if (this.head == null)
                {
                    Console.WriteLine("LinkedList is empty");
                }
                if (head.next == null)
                {
                    head = null;
                }
                Node<T> lastNode = this.head;
                while (lastNode.next.next != null)
                {
                    lastNode = lastNode.next;
                }
                lastNode.next = null;
                Console.WriteLine("Last element is deleted successfully");
            }
            public void Display()
            {
                Node<T> temp = this.head;
                if (temp == null)
                {
                    Console.WriteLine("Linked list empty");
                    return;
                }
                while (temp != null)
                {
                    Console.WriteLine(temp.data + "");
                    temp = temp.next;
                }
            }

        }
    }
}
