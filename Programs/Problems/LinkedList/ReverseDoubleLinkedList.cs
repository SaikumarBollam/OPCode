namespace Optimize
{
    class ReverseDoubleLinkedList
    {
        private static DoubleLinkedList CreateLinkedList(int maxCount)
        {
            int start = 10;
            DoubleLinkedList head = new DoubleLinkedList(start);
            DoubleLinkedList prev = head;
            head.Prev = null;
            DoubleLinkedList tempHead = head;
            Console.Write("The Element are : {0}", tempHead.Data);
            while (start<maxCount)
            {
                start += 10;
                tempHead.Next = new DoubleLinkedList(start);
                tempHead = tempHead.Next;
                tempHead.Prev = prev;
                prev = tempHead;
                Console.Write(" {0} ", tempHead.Data);
            }
            Console.WriteLine();
            tempHead.Next = null;
            return head;
        }
        private static void ReadLinkedList(DoubleLinkedList head)
        {
            Console.Write("The Element are :");
            while (head != null)
            {
                Console.Write(" {0} ", head.Data);
                head = head.Next;
            }
            Console.WriteLine();
        }
        public static DoubleLinkedList Reverse(DoubleLinkedList head,int startNodeCount,int endNodeCount)
        {
            DoubleLinkedList   prev = null,current,tempHead,tempTail=null,next=null;
            current = tempHead = head;
            int currentCount=1;
           
            while (currentCount < startNodeCount)
            {
                prev = tempHead;
                tempHead = prev.Next;
                currentCount++;
            }
            

            if (prev == null)
            {   
                prev = head;
                tempHead = prev;
            }
            current = tempTail = prev.Next;
            
            while ((currentCount <= endNodeCount))
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next; 
                currentCount++;
            }
            if (startNodeCount>0)
                tempHead.Next = prev;
            if(endNodeCount>0)
                tempTail.Next = next;
            return head;
        }
        public static void Solution()
        {
           DoubleLinkedList dsLink =  CreateLinkedList(100);
           DoubleLinkedList rsLink = Reverse(dsLink,3,8);
           ReadLinkedList(rsLink);
        }
    }
    
}