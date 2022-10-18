// Given a doubly linked list, list nodes also have a child
// property that can point to a separate doubly linked list.
// These child lists can also have one or more child doubly >
// linked lists of their own, and so on.
// Return the list as a single level flattened doubly linked list.

namespace Optimize
{
    class MultiLevelDoublyLinkedList<T>
    {
        public T Data;
        public MultiLevelDoublyLinkedList<T>? Previous;
        public MultiLevelDoublyLinkedList<T>? Next;
        public MultiLevelDoublyLinkedList<T>? Child;
    }
}
