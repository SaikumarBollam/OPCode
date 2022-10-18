namespace Optimize
{
    class DoubleLinkedList
    {
        public int Data;
        public DoubleLinkedList(int data)
        {
            Data = data;
        }
        public DoubleLinkedList? Prev;
        public DoubleLinkedList? Next;
    }
}