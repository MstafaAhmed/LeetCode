public class Solution {
    public int HeightChecker(int[] heights) {
         var heightsSorted = (int[])heights.Clone();
        Array.Sort(heightsSorted);
        int answer=0;
        for(int i=0;i<heights.Length;i++)
        {
            if(heightsSorted[i]!=heights[i])
            {
                ++answer;
            }
        }
        return answer;

    }
}