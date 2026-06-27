public class Solution {
    public bool hasDuplicate(int[] nums) {
        bool isDuplicate = false;
        int pivot;

        for (int i = 0; i < nums.Length; i++) {
            pivot = nums[i];
            for (int j = i + 1; j <= nums.Length - 1; j++) {
                if (pivot == nums[j]) {
                    isDuplicate = true;
                    break;
                }
            }
        }

        return isDuplicate;
    }
}