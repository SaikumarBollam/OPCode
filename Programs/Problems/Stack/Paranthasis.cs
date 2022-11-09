namespace Optimize 
{
    class Paranthasis
    {
       static Dictionary < char, char > paranthasis = new Dictionary < char, char> ();
        
      public  static bool isValid(string str)
        {
            Stack<char> dataHolder = new Stack<char>();
            foreach (char item in str)
            {
                if (paranthasis.ContainsKey(item))
                {
                    dataHolder.Push(item);
                }
                else
                {
                    char leftPar = dataHolder.Pop();
                    if(!item.Equals(paranthasis[leftPar])) return false;
                }
            }
            return dataHolder.Count == 0;
        }

        public static void Solution()
        {
            paranthasis.Add('{','}');
            paranthasis.Add('[',']');
            paranthasis.Add('(',')');

            Console.WriteLine("[{()}] is " + isValid("[{()}]"));
            Console.WriteLine("[{}()] is " + isValid("[{()}]"));
            Console.WriteLine("[{()]] is " + isValid("[{()]]"));
        }
    }
}