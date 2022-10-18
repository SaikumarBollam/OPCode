   namespace Optimize
    {
class TypedOutOfStrings
{
    public static bool findMatch(string first, string second)
    {
        Stack<char> firstResult = BuildArray(first);
        Stack<char> secondResult = BuildArray(second);

        while (firstResult.Count > 1)
        {
            if (firstResult.Count != secondResult.Count)
                return false;
            if (!secondResult.Pop().Equals(firstResult.Pop()))
                return false;
        }
        return true;
    }

    private static Stack<char> BuildArray(string first)
    {
        Stack<char> firstResult = new Stack<char>();
        if (string.IsNullOrEmpty(first))
        {
            throw new ArgumentException($"'{nameof(first)}' cannot be null or empty.", nameof(first));
        }
        for (int i = 0; i < first.Length; i++)
        {
            if (i < first.Length - 1 && first[i].Equals('#'))
            { if (firstResult.Count != 0) firstResult.Pop(); }
            else if (i < first.Length - 1)
            { firstResult.Push(first[i]); }
        }
        return firstResult;
    }

    private static bool findMatchOptimal(string first, string second)
    {
        int firstAshCount = 0, secondAshCount = 0, firstStartPtr = first.Length - 1, seconStartdPtr = second.Length - 1;
        while (firstStartPtr >= 0 || seconStartdPtr >= 0)
        {
            if ((firstStartPtr >= 0 && seconStartdPtr >= 0) && (first[firstStartPtr].Equals('#') || second[seconStartdPtr].Equals('#')))
            {
                if (first[firstStartPtr].Equals('#'))
                {
                    firstAshCount++;
                    firstStartPtr--;
                }
                if (second[seconStartdPtr].Equals('#'))
                {
                    secondAshCount++;
                    seconStartdPtr--;
                }
            }
            else
            {
                firstStartPtr -= firstAshCount;
                seconStartdPtr -= secondAshCount;
                if (firstStartPtr >= 0 && seconStartdPtr >= 0)
                {
                    if (first[firstStartPtr].Equals(second[seconStartdPtr]))
                    {
                        firstStartPtr--;
                        seconStartdPtr--;
                        firstAshCount = 0;
                        secondAshCount = 0;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        return true;
    }
    public static void Solutions()
    {
        Console.WriteLine("Two string aavv##cd & aacd are " + (findMatch("aavv##cd", "aacd") ? "Equal" : "Not Equal"));
        Console.WriteLine("Two string abc & cdf are " + (findMatch("abc", "cdf") ? "Equal" : "Not Equal"));

        Console.WriteLine("Two string aavv##cd & aacd (OP) are " + (findMatchOptimal("aavv##cd", "aacd") ? "Equal" : "Not Equal"));
        Console.WriteLine("Two string abc & cdf (OP) are " + (findMatchOptimal("abc", "cdf") ? "Equal" : "Not Equal"));

        Console.WriteLine("Two string abc & cdf (OP) are " + (findMatchOptimal("ab##", "c#d#") ? "Equal" : "Not Equal"));
    }

}
    }