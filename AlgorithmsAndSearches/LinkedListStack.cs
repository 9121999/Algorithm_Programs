using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsAndSearches
{
    public class LinkListStack<T>
    {
        public Node<T> top;
        public LinkListStack()
        {
            this.top = null;
        }
        public void Push(T value)
        {
            Node<T> node = new Node<T>(value);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
           // Console.WriteLine(value);
        }
        public bool Peek()//will return top value but not delete it
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is Empty");
                return true;
            }
            Console.WriteLine(this.top.data);
            return false;
        }
        public void Pop()//will delete top data nd return
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
         //   Console.WriteLine(this.top.data);
            this.top = this.top.next;
        }
        public void Display()
        {
            Node<T> temp = this.top;
            Console.WriteLine("Stack is as:");
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
