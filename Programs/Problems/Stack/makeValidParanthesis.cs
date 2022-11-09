namespace Optimize
{
    // Minimum brakets to remove.
    // Given a string only containing round brackets
    // '(' and ')' and lowercase characters, remove the
    // least amount of brackets so the string is valid.
    // A string is considered valid if it is empty or if there
    // are brackets, they all close.
    // Eg : a)bc(d) , (ab(c))
    class makeValidParanthesis
    {
        public static string ValidParanthesis(string str)
        {
            char left = '(',right = ')';
            Stack<int> holder = new Stack<int>();
            for (int index = 0; index < str.Length; index++)
            {
                char item = str[index];
                if (item != left)
                {
                    if (item == right && holder.Count <= 0)
                    {
                        str = str.Remove(index,1);
                        index--;
                    }
                    else if (item == right && holder.Count > 0)
                        holder.Pop();
                }
                else
                    holder.Push(index);
            }
            foreach (int index in holder)
                str = str.Remove(index,1);
            return str;
        }

        public static void Solution()
        {
           //Console.WriteLine("sa(ks)( is "+ValidParanthesis("sa(ks)("));
           //Console.WriteLine("))(( is "+ValidParanthesis("))(("));
           //Console.WriteLine("(())( is "+ValidParanthesis("(())("));
           Console.WriteLine(")(())( is "+ValidParanthesis(")(())("));
           //Console.WriteLine("((())( is "+ValidParanthesis(")(()))("));
        }
       
    }
    
}