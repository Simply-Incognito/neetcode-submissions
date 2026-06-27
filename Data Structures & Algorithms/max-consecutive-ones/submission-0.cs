public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int n = 0;
        int max = 0;

        for (int i = 0; i < nums.Count(); i++) {
            if (nums[i] == 1) {
                if (++n > max) max = n;
            } else if (nums[i] != 1) {
                n = 0;
            }
        }
        return max;
    }
}