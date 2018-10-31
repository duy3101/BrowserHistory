//NGOC DEWEY NGUYEN, BIT43, 2017 FALL, ASSIGNMENT #2, VER. A2.0
//Using two linked lists (history and future) to store webpages
//historyCount and futureCount updates whenever MoveBackwards and MoveForwards are called.
//revised

using System;
using System.Collections.Generic;
using System.Text;

namespace Helpdesk
{

	

    class History
    {
        StringLL history = new StringLL();
        StringLL future = new StringLL();

		int historyCount;
		int futureCount;
        

        public void PrintAll()
        {
            Console.WriteLine("Previously visited pages:");
            history.PrintAll();
            Console.WriteLine("Pages in your 'future': ");
            future.PrintAll();
        }

        public void MoveBackwards()
        {

            if (history.IsEmpty())
            {
                return;
            }
            else
            {               
                future.AddToFront(history.RemoveFromFront());
                historyCount--;
                futureCount++;

            }
        }

        public void MoveForwards()
        {
            if (future.IsEmpty())
            {
                return;
            }
            else
            {           
                history.AddToFront(future.RemoveFromFront());
                historyCount++;
                futureCount--;

            }
        }

        public void VisitPage(String desc)
        {
            history.AddToFront(desc);
            future.RemoveAll();
            historyCount++;
            futureCount = 0;

        }
    }

    public class StringLL
    {
        protected LinkedListNode front;

        public class LinkedListNode
        {
            private String data;
            private LinkedListNode next;

            public LinkedListNode(String website)
            {
                data = website;
            }

            public String GetData() {
                return this.data;
            }

            public LinkedListNode GetNext() {
                return this.next;
            }

            public void SetData(String data) {
                this.data = data;
                
            }

            public void SetNext(LinkedListNode next) {
                this.next = next;
            }

        }
        public void AddToFront(String desc)
        {
            if (front == null)
            {
                LinkedListNode newNode = new LinkedListNode(desc);
                AddToFront(newNode);
            }

            else
            {
                LinkedListNode newNode = new LinkedListNode(desc);
                AddToFront(newNode);
            }

        }

        public void AddToFront(LinkedListNode node)
        {
            if (front == null)
            {

                node.SetNext(null);
                front = node;
            }

            else
            {

                node.SetNext(front);
                front = node;
            }


        }


        public void PrintAll()
        {
            
            LinkedListNode current = front;
            while (current != null)
            {
                Console.WriteLine(current.GetData());
                current = current.GetNext();
                
            }

            
            

        }


        public LinkedListNode RemoveFromFront()
        {
            
            LinkedListNode node = front;
            front = front.GetNext();
            return node;



        }

        public void RemoveAll()
        {
            front = null;

        }

        public bool IsEmpty()
        {

            return front == null;
            //boolean method returns either true or false, if false this return statement return false, else true;


        }

                
       
    }
}
