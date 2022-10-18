
namespace Optimize
{
    public class LinkedLists<T>
    {
        public  LinkedLists(T data)
        {   
                Data = data;
        }
        public LinkedLists<T>? next;
        public T Data {get;set;}
    }
}