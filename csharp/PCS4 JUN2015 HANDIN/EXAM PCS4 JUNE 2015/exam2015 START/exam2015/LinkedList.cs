using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam2015
{
    public class TimeNode
    {
        public int Time { get; set; }
        public TimeNode Next { get; set; }

        public TimeNode(int time)
        {
            Time = time;
            Next = null;
        }
    }


    public class LinkedTimeList
    {
        public TimeNode First { get; set; }
        public TimeNode Last { get; set; }

        public LinkedTimeList()
        {
            First = null;
            Last = null;
        }
        public void ConvertBest5ToLinkedList(int[] best5)
        {
            foreach (int t in best5)
            {
                if (t != 1000)
                {
                    TimeNode tnode = new TimeNode(t);

                    if (First != null)
                    {
                        //there are 1 or more items already in the linked list
                        Last.Next = tnode;
                        Last = tnode;
                    }
                    else
                    {// there are no items in the linked list              
                        First = tnode;
                        Last = First;
                    }
                }
            }
        }
        public List<int> GetAll()
        {
            List<int> templist = new List<int>();
            int counter = 0;
            TimeNode current;
            current = First;
            while (current != null )
            {
                templist.Add(current.Time);
                current = current.Next;
                counter++;
            }
            return templist;
        }

    }
}
