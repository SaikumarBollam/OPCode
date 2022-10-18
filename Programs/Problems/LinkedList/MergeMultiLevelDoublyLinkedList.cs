using System.Collections;
using System.Collections.Generic;

namespace Optimize
{
    class MergeMultiLevelDoublyLinkedList
    {
        public static MultiLevelDoublyLinkedList<T>
        Merge<T>(MultiLevelDoublyLinkedList<T> head)
        {
            MultiLevelDoublyLinkedList<T>
                tempData = head,
                prev,
                next;

            while (tempData.Next != null)
            {
                if (tempData.Child != null)
                {
                    prev = tempData;
                    next = tempData.Next;
                    Merge<T>(tempData.Child).Next = next;
                    tempData = prev;
                }
            }
            return head;
        }

        public static void Solution()
        {
            int[] arrayList = new int[] {1,2,3,7,8,9,13,14};
            int[] subList = new int[] {4,5,6}; 
            int[] subList2 = new int[] {10,11,12}; 
            int[] subList3 = new int[] {15,16,17}; 
            MultiLevelDoublyLinkedList<int> HEAD = createList<int>(arrayList);
            HEAD.Child = createList<int>(subList);
            HEAD.Next.Child  = createList<int>(subList2);
            HEAD.Next.Next.Child  = createList<int>(subList3);
            MultiLevelDoublyLinkedList<int> tail = Merge<int>(HEAD);
            Console.WriteLine(tail);
        }

        // A function to create a linked list
        // with n(size) nodes returns head pointer
        public static MultiLevelDoublyLinkedList<T> createList<T>(T[] arr)
        {
            MultiLevelDoublyLinkedList<T> head = null;
            MultiLevelDoublyLinkedList<T> tmp = null;

            // Traversing the passed array
            for (int i = 0; i < arr.Length; i++)
            {
                // Creating a node if the list
                // is empty
                if (head == null)
                {
                    tmp = head = new MultiLevelDoublyLinkedList<T>();
                }
                else
                {
                    tmp.Next = new MultiLevelDoublyLinkedList<T>();
                    tmp = tmp.Next;
                }

                // Created a node with data and
                // setting child and next pointer
                // as NULL.
                tmp.Data = arr[i];
                tmp.Next = tmp.Child = null;
            }
            return head;
        }
    }
}
