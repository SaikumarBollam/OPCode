using System.Text.RegularExpressions;
   namespace Optimize
    {
    class PalindromeDataStructure
    {
    public static bool checkPalindrome(string str)
        {   
            if(str.Length<2) return true;

            int length= str.Length,left=0,right=0;
            str = new Regex("([^a-zA-Z0-9])").Replace(str,"").ToLower();

            bool even = (length%2)==0;
            left  = (length/2)+(even?-1:0);
            right = even?left+1:left;
        
            while (left>=0&&right<length)
            {
                if (!str[left].Equals(str[right]))
                    return false;
                left--; right++;
            }
            return true;
        }

    public static bool checkPalindromeAfterCorrection(string str)
    {
        if(str.Length<2) return true;

        int left=0,right=0,misCount=0;
        str = new Regex("([^a-zA-Z0-9])").Replace(str,"").ToLower();

        left  = 0;
        right = str.Length-1;
        
        while (left<=right)
        {
            if (!str[left].Equals(str[right]))
            {
                misCount++;
                if(misCount>1)
                    return false;
            }
            left++; right--;
        }
        return true;
    }
     public static void Solution()
    {
        // checkPalindromeResult();
        checkPalindromeAfterCorrectionResult();
    }

    private static void checkPalindromeAfterCorrectionResult()
    {
        Console.WriteLine("abba is Palindrome " + checkPalindromeAfterCorrection("aabba"));
        Console.WriteLine("abbba is Palindrome " + checkPalindromeAfterCorrection("abbcba"));
        Console.WriteLine("aa is Palindrome " + checkPalindromeAfterCorrection("ac"));
        Console.WriteLine(" is Palindrome " + checkPalindromeAfterCorrection("c"));
        Console.WriteLine("aba is Palindrome " + checkPalindromeAfterCorrection("aba"));
    }

    private static void checkPalindromeResult()
    {
        Console.WriteLine("abc is Palindrome " + checkPalindrome("abc"));
        Console.WriteLine("abba is Palindrome " + checkPalindrome("abba"));
        Console.WriteLine("abbba is Palindrome " + checkPalindrome("abbba"));
        Console.WriteLine("aa is Palindrome " + checkPalindrome("aa"));
        Console.WriteLine(" is Palindrome " + checkPalindrome(""));
        Console.WriteLine("aba is Palindrome " + checkPalindrome("aba"));
        Console.WriteLine("abcdeffedcba is Palindrome" + checkPalindrome("abcdeffedcba"));
        Console.WriteLine("A man, a plan, a canal: Panama is Palindrome" + checkPalindrome("A man, a plan, a canal: Panama"));
    }
}
    }