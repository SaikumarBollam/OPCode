   namespace Optimize
    {
class SumOfTwoIntergerIndex
{
        public static int[] findNumber(int[] list,int targetNum)
        {
            Dictionary<int,int> hm = new Dictionary<int, int>();
            for (int i = 0; i < list.Length; i++)
            {
              try
              {
                  var ConstMap = hm[list[i]];
                if(ConstMap>=0)
                    return new int[]{ConstMap,i};
              }
              catch (System.Exception)
              {
                    hm[targetNum-list[i]] = i;
              }
            }
            return null;
        }

      public static void solution()
        {
          int[] result =  findNumber(new int[]{2,5,6,7,9,11},13);
          if(result!=null)
              Console.WriteLine(" [ "+result[0]+" , " + result[1]+" ] ");
          else
            Console.WriteLine("Data don't find...");
        }
                  
      }
    }