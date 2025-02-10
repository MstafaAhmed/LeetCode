public class Solution {
    public bool Check(int[] nums) {
        int countBreaks = 0;
       

        for (int i = 0; i < nums.Length; i++) {
            if (nums[i] > nums[(i + 1) % nums.Length]) {
                countBreaks++;
            }
            if (countBreaks > 1) {
                return false;
            }
        }
        return true;
    }
}