public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int currentCount = 0;
        int maxCount = 0;

        foreach (int num in nums) {
            if (num == 1) {
                ++currentCount;
                maxCount = Math.Max(currentCount, maxCount);
            } else if (num != 1) {
                currentCount = 0; // Reset counter
            }
        }
        return maxCount;
    }
}