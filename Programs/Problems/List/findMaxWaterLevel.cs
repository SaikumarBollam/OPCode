   namespace Optimize
    {
class FindMaxWaterLevel
{
  public static  int findMaxWaterLevelFlow(int[] wallHights)
    {
        int ptr1=0,ptr2= wallHights.Length-1,maxArea=0;
        while (ptr1<ptr2)
        {
            int heightWall = Math.Min(wallHights[ptr1],wallHights[ptr2]);
            int wallWidth = ptr2- ptr1;
            int area = heightWall * wallWidth;
            maxArea = Math.Max(maxArea,area);
            if (wallHights[ptr1] <= wallHights[ptr2])
                ptr1++;
            else
            ptr2--;
        }
        return maxArea;
    }

    public static void solution()
    {
        int[] inputs = new int[]{6,4,3,7,11,9};
        Console.WriteLine(findMaxWaterLevelFlow(inputs));
    }
}
    }