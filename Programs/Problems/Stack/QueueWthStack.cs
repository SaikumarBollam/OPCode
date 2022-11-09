
namespace Programs.Problems.Stack
{
    public class QueueWthStack<T>
    {
        Stack<T> insertStack =  new Stack<T>();
        Stack<T> deleteStack = new Stack<T>();
       
        public void Enqueue(T data) {
            this.deleteStack.Push(data);
        }
    
        public T Dequeue() {
            if (this.deleteStack.Count == 0)
            {
                while (this.insertStack.Count == 0)
                this.deleteStack.Push(this.insertStack.Pop());
            }
            return this.deleteStack.Pop();
        }
    
        public T Peek() {
            if (this.deleteStack.Count==0)
            {
                while (this.insertStack.Count == 0)
                {
                    this.deleteStack.Push(this.insertStack.Pop());
                }
            }
            return this.deleteStack.ElementAt(this.deleteStack.Count-1);
        }
    
        public bool Empty() {
            return insertStack.Count == 0 && deleteStack.Count == 0 ;
        }

        public static void Solution()
        {

        }
    }
}