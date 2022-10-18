   namespace Optimize
    {
class TappingRainWater
{
   public static int findMaxWaterTapped(int[] heights)
    {
        int maxLeft = 0,maxRight =0,left=0,right= heights.Length-1,totalWaterTapped=0;
      while(left<right)
      {
            if(heights[left]<=heights[right])
            {
                if(heights[left]>=maxLeft)
                  {  maxLeft = heights[left];
                   }
                else
                  {  totalWaterTapped += maxLeft-heights[left];}
                     left++;
            }
            else
            {
                if(heights[right]>=maxRight)
                    {maxRight = heights[right];
                    }
                else
                    {totalWaterTapped +=  maxRight-heights[right];}
                    right--;
            }
      }
        return totalWaterTapped;
    }

    public static  void Solution()
    {
        int[] heightOfWalls = new int[]{0,1,0,2,1,0,3,1,0,1,2};
        Console.WriteLine("Max water Hold is "+findMaxWaterTapped(heightOfWalls));

    }
    
}
    }