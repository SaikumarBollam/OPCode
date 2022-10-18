
namespace Optimize
{
    // Time : O(n) Space : O(1)
    public class ReverseLinkedLists
    {   
        public static LinkedLists<int> ReverseList(LinkedLists<int> head,int startNodeCount,int endNodeCount)
        {
            LinkedLists<int> prev = null,current,tempHead,tempTail=null,next=null;
            current = tempHead = head;
            int currentCount=1;
           
            while (currentCount < startNodeCount)
            {
                prev = tempHead;
                tempHead = prev.next;
                currentCount++;
            }
            

            if (prev == null)
            {   
                prev = head;
                tempHead = prev;
            }
            current = tempTail = prev.next;
            
            while ((currentCount <= endNodeCount))
            {
                next = current.next;
                current.next = prev;
                prev = current;
                current = next; 
                currentCount++;
            }
            if (startNodeCount>0)
                tempHead.next = prev;
            if(endNodeCount>0)
                tempTail.next = next;
            return head;
        }
        private static LinkedLists<int> CreateLinkedList(int maxCount)
        {
            int start = 10;
            LinkedLists<int> head = new LinkedLists<int>(start);
            LinkedLists<int> tempHead = head;
            Console.Write("The Element are : {0}", tempHead.Data);
            while (start<=maxCount)
            {
                start += 10;
                tempHead.next = new LinkedLists<int>(start);
                tempHead = tempHead.next;
                Console.Write(" {0} ", tempHead.Data);
            }
            Console.WriteLine();
            tempHead.next = null;
            return head;
        }

        private static void ReadLinkedList(LinkedLists<int> head)
        {
            Console.Write("The Element are :");
            while (head != null)
            {
                Console.Write(" {0} ", head.Data);
                head = head.next;
            }
            Console.WriteLine();
        }

        // private static LinkedLists<int> ReverseListWithMandN(LinkedLists<int> head,int start,int end)
        // {
        //     int currentPosition = 1;
        //     LinkedLists<int> currentNode=head,startNode=head,endNode=null;
        //     while (currentPosition<start)
        //     {
        //         startNode = currentNode.next;
        //         currentPosition++;  
        //         currentNode = startNode;          
        //     }
        //     List<LinkedLists<int>> firstAndLast = ReverseList(currentNode,end-start);
            
        //     while (currentPosition<end)
        //     {
        //         endNode = currentNode.next;
        //         currentNode = endNode;       
        //         currentPosition++;     
        //     }
        //     startNode = firstAndLast.First();
        //     endNode = firstAndLast.Last();
        //     return head;
        // }
        public static void Solution()
        {
            // LinkedLists<int> reverseLinkedList = CreateLinkedList(100);
            // ReadLinkedList(ReverseList(reverseLinkedList, 0,0));
            // LinkedLists<int> reverseLinkedListWithMandN = CreateLinkedList(150);
            // ReadLinkedList(ReverseList(reverseLinkedListWithMandN,3,8));
            LinkedLists<int> reverseLinkedListWithMandN2 = CreateLinkedList(160);
            ReadLinkedList(ReverseList(reverseLinkedListWithMandN2,1,16));
        }
    }
}
