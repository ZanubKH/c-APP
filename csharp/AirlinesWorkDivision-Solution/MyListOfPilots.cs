using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlinesWorkDivision
{
        /// <summary>
        /// Represents one node in a linked list. 
        /// Contains two properties:
        ///     1. Reference to a pilot object.
        ///     2. Reference to the next Node in the list.
        /// </summary>
        public class Node
        {
            private Pilot pilot; // reference to a pilot object.
            private Node next;       // refernce to the next Node in the list. 

            public Pilot Pilot
            {
                get { return pilot; }
            }
            public Node Next
            {
                get { return next; }
                set { next = value; }
            }

            public Node(Pilot pilot)
            {
                this.pilot = pilot;
                this.next = null;
            }

        }

        /// <summary>
        /// Represents a linked list of pilots.
        /// </summary>
        public class MyListOfPilots
        {
            private Node first; // The first node in the list.

            public Node First
            {
                get { return first; }
            }

            public MyListOfPilots()
            {
                first = null; // the list is empty.
            }


            //******************************* WRITE YOUR OWN CODE UNDER THIS LINE ***************************

            /// <summary>
            /// Adds a pilot AT THE BEGINNING of the list.
            /// </summary>
            /// <param name="Flight"></param>
            public void Add(Pilot pilot)
            {
                Node node = new Node(pilot);
                if (first == null)
                {
                    first = node;
                }
                else
                {
                    node.Next = first;
                    first = node;
                }
            }
        }
}
