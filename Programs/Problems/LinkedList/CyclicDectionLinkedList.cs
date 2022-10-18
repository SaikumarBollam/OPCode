namespace Optimize
{
    class CyclicDectionLinkedList
    {
      static  T FindCycle<T>(LinkedLists<T> head)
        {
            LinkedLists<T> tempPtr = head,hare=head.next.next,tortoise = head.next;
            while (!hare.Data.Equals(tortoise.Data))
            {
                if(hare.next == null || tortoise.next == null)
                {
                    return default(T);
                }
                hare = hare.next.next; 
                tortoise = tortoise.next;
            }
            Console.Write(tortoise.Data);
            while (!tempPtr.Data.Equals(hare.Data))
            {
                hare = hare.next; 
                tempPtr = tempPtr.next;
            }
            return tempPtr.Data;
        }

       public static void Solution()
        {
          LinkedLists<int> head = getLinkedList<int>(new int[]{1,2,3,4,5,6,7,8,9});
          Console.WriteLine(FindCycle<int>(head));
        }

        private static LinkedLists<T> getLinkedList<T>(T[] arr)
        {
            LinkedLists<T> head = new LinkedLists<T>(arr[0]);
            LinkedLists<T> node = new LinkedLists<T>(arr[1]);
            head.next = node;
            LinkedLists<T> node1 = new LinkedLists<T>(arr[2]);
            node.next = node1;
            LinkedLists<T> node2 = new LinkedLists<T>(arr[3]);
            node1.next = node2;
            LinkedLists<T> node3 = new LinkedLists<T>(arr[4]);
            node2.next = node3;
            LinkedLists<T> node4 = new LinkedLists<T>(arr[5]);
            node3.next = node4;
            LinkedLists<T> node5 = new LinkedLists<T>(arr[6]);
            node4.next = node5;
            LinkedLists<T> node6 = new LinkedLists<T>(arr[7]);
            node5.next = node6;
            LinkedLists<T> node7 = new LinkedLists<T>(arr[8]);
            node6.next = node7;
            node7.next = node3;
            return head;
        }
    }
}