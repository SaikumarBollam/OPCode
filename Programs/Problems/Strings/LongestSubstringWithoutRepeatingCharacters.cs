   namespace Optimize
    {
class LongestSubstringWithoutRepeatingCharacters
{
    public static int findMaxLength(string str)
    {
        if(str.Length<=1) return str.Length;
        int maxCount = 0,left=0;
        Dictionary<char, int> seen = new Dictionary<char, int>();

        for (int right = 0; right < str.Length; right++)
        {  
            char current = str[right];
            if (seen.ContainsKey(current)&&seen[current]>=left)
             left =  seen[current]+1;
            seen[current]=right;
            maxCount = Math.Max(maxCount,right-left+1);
        }
        return maxCount;
    }

    public static int findMaxLengthHashSet(string s)
    {
        HashSet<int> tempSet = new HashSet<int>();
        int leftPtr = 0;
        int rightPtr = 0;
        int maxCount = 0;
        
        while (rightPtr < s.Length)
        {
            if (!tempSet.Add(s[rightPtr]))
            {
                while (s[leftPtr] != s[rightPtr])
                {
                    tempSet.Remove(s[leftPtr]);
                    leftPtr++;
                }
                
                tempSet.Remove(s[leftPtr]);
                leftPtr++;
                tempSet.Add(s[rightPtr]);
            }
            else maxCount = Math.Max(maxCount, rightPtr - leftPtr + 1);
            rightPtr++;
        }
        
        return maxCount;
    }

    public static void Solution()
    {
        Console.WriteLine("The max Sub String Length of 'abcacdfbac': " + findMaxLength("abcacdfbac"));
        Console.WriteLine("The max Sub String Length of 'abcacdfbac': " + findMaxLength("abcacdfbacefgpqwe"));

        Console.WriteLine("The max Sub String Length of 'abcacdfbac': " + findMaxLengthHashSet("abcacdfbac"));
        Console.WriteLine("The max Sub String Length of 'abcacdfbacefgpqwe': " + findMaxLengthHashSet("abcacdfbacefgpqwe"));
    }
}
    }