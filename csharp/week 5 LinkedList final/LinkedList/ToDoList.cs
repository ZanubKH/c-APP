using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedList
{
    public class ToDoList
    {
        private String name;
        private Node first;
        private Node last;
        //In this example we implement it as a queue, which acts according to "first in first out".
        //For ease of use we register two nodes: the first node and the last node.

        public ToDoList(String name)
        {
            this.name = name;
            this.first = null;
            this.last = null;
        }

        public String GetName() { return this.name; }

        public String GetInfoFirstItem()
        {
            if (first != null)
            {
                return first.getItem().ToString();
            }
            else
            {
                return "there is no first item in the list"; ;
            }
        }

        public String GetInfoSecondItem()
        {
            if (first != null)
            {
                Node second = first.getNext();
                if (second != null)
                {
                    return second.getItem().ToString();
                }
                else
                {
                    return "there is no second item in the list"; ;
                }
            }
            else
            {
                return "there is no second item in the list"; ;
            }
        }

        public String GetInfoThirdItem()
        {
            if (first != null)
            {
                Node second = first.getNext();
                if (second != null)
                {
                    Node third = second.getNext();
                    if (third != null)
                    {
                        return third.getItem().ToString();
                    }
                    else
                    {
                        return "there is no third item in the list"; ;
                    }
                }
                else
                {
                    return "there is no third item in the list"; ;
                }
            }
            else
            {
                return "there is no third item in the list"; ;
            }
        }

        /// <summary>
        /// Adds item i to the end of the linked list
        /// </summary>
        /// <param name="i"></param>
        public void AddItem(Item i)
        {
            if (first != null)
            {
                //there are 1 or more items already in the linked list
                Node tempNode;
                tempNode = new Node(i);
                last.setNext(tempNode);
                last = tempNode;
            }
            else
            {// there are no items in the linked list              
                first = new Node(i);             
                last = first;
            }
        }

        /// <summary>
        /// If the list is not empty,
        /// it removes the first item from the linked list and returns this item,
        /// else it returns null and the list is not changed
        /// </summary>
        /// <returns></returns>
        public Item removeItem()
        {
            if (first == null)
            { //there are no items in the linked list
                return null;
            }
            else
            {
                if (first != last)
                {//there are  2 or more items in the linked list
                    Node tempNode;
                    tempNode = first;
                    first = first.getNext();
                    return tempNode.getItem();
                }
                else
                {//there is exactly 1 item in the linked list
                    Node tempNode;
                    tempNode = first;
                    first = null;
                    last = null;
                    return tempNode.getItem();
                }
            }
            
        }

    }
}
