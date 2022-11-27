using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndSearches
{
    internal class SortList
    {
        public class SortingList<T> where T : IComparable<T>
        {
            public Node<T> head = null;
            public Node<T> tail = null;
            public void AddNode(T data)
            {
                Node<T> newNode = new Node<T>(data);
                if (head == null)
                {
                    head = newNode;
                    tail = newNode;
                }
                else
                {
                    tail.next = newNode;
                    tail = newNode;
                }
            }
            public void SortedList()
            {
                Node<T> current = head, index = null;
                T temp;
                if (head == null)
                {
                    Console.WriteLine("LinkedList is Empty");
                    return;
                }
                else
                {
                    while (current != null)
                    {
                        index = current.next;
                        while (index != null)
                        {
                            if (current.data.CompareTo(index.data) > 0)
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
            public void Display()
            {
                Node<T> current = head;
                if (head == null)
                {
                    Console.WriteLine("LinkedList is Empty");
                    return;
                }
                while (current != null)
                {
                    Console.WriteLine(current.data + " ");
                    current = current.next;
                }
            }
        }
    }
}

