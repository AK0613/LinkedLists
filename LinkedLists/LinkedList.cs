using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    public class Node
    {
        public int data;
        public Node next;
        public Node prev;

        public Node(int data)
        {
            this.data = data;
            this.next = null;
            this.prev = null;
        }
    }
    internal class LinkedList
    {
        public Node head;
        public Node tail;
        int count;

        public LinkedList()
        {
            head = null;
            tail = null;
            count = 0;
        }

        public void insert_back(int data)
        {
            Node newNode = new Node(data);

            if(this.head == null)
            {
                this.head = newNode;
                this.tail = newNode;
            }
            else
            {
                Node current = this.tail;
                current.next = newNode;
                newNode.prev = current;
                this.tail = newNode;
            }
            this.count++;
        }

        public void insert_front(int data)
        {
            Node newNode = new Node(data);
            if(this.head == null)
            {
                this.head = newNode;
                this.tail = newNode;
            }
            else
            {
                Node temp = this.head;
                this.head = newNode;
                newNode.next = temp;
                temp.prev = newNode;
            }
            this.count++;
        }

        public void insert_at(int data, int index)
        {
            Node newNode = new Node(data);
            Node current = this.head;

            if(this.count >= index)
            {
                if(index == 0)
                    insert_front(data);
                if(index == this.count)
                    insert_back(data);

                else
                {
                    for (int i = 0; i < index - 1; i++)
                        current = current.next;

                    Node temp = current.next;
                    current.next = newNode;
                    newNode.prev = current;
                    newNode.next = temp;
                    temp.prev = newNode;
                    this.count++;
                }
            }
        }

        public void print_recursive(Node node)
        {
            if (node != null)
            {
                while (node != null)
                {
                    Console.WriteLine(node.data);
                    node = node.next;
                }
            }
            else
                return;
        }

        public int dequeue()
        {
            Node current = this.head;
            int val = -1;
            if(this.count >1)
            {
                val = current.data;
                current = current.next;
                this.head = current;
                current.prev = null;
                this.count--;
            }
            else if(this.count == 1)
            {
                val = current.data;
                this.head = null;
                this.tail = null;
                this.count = 0;
            }
            return val;
        }

        public int pop()
        {
            Node current = this.tail;
            int val = -1;
            if(this.count > 1)
            {
                val = current.data;
                current = current.prev;
                this.tail = current;
                current.next = null;
            }
            if(this.count == 1)
            {
                val = current.data;
                this.tail = null;
                this.head = null;
                this.count = 0;
            }
            return val;
        }

        public int find_index(int value)
        {
            int index = -1;
            Node current = this.head;
            if(this.count > 0)
            {
                for(int i = 0; i < this.count; i++)
                {
                    if(current.data == value)
                        index = i;
                    current = current.next;
                }
            }
            return index;
        }

        public int delete_value(int data)
        {
            int value = -1, index = -1;
            Node current = this.head;

            index = find_index(data);
            if(index != -1)
            {
                if (index == count - 1)
                {
                    value = pop();
                    return value;
                }
                if(index == 0)
                    value = dequeue();
                else
                {
                    for (int j = 0; j < index - 1; j++)
                        current = current.next;

                    value = current.next.data;
                    current.next = current.next.next;
                    current.next.prev = current;
                }
            }
            return value;
        }

        public int delete_index(int index)
        {
            Node current = this.head;
            int data = -1;
            if(this.count>0)
            {
                if (index == count)
                {
                    data = pop();
                    return data;
                }
                    
                if (index == 0)
                    data = dequeue();
                else
                {
                    for (int j = 0; j < index - 1; j++)
                        current = current.next;

                    data = current.next.data;
                    current.next = current.next.next;
                    current.next.prev = current;
                }
            }
            return data;
        }
    }

    
}
