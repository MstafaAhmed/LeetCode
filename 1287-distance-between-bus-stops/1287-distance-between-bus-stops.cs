public class Solution 
{
    public int DistanceBetweenBusStops(int[] distance, int start, int destination) 
    {
        int cw = 0;
        int ccw = 0;

        int cur = start;
        while(cur != destination)
        {
            cw += distance[cur];
            cur = (cur + 1) % distance.Length;
        }

        cur = start;
        while(cur != destination)
        {
            cur = cur - 1;
            if (cur < 0) { cur += distance.Length; }
            ccw += distance[cur];
        }

        return cw < ccw ? cw : ccw;
    }
}