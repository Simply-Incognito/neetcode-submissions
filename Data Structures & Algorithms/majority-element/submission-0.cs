public class Solution {
    public int MajorityElement(int[] nums) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        foreach (int num in nums) {
           if (!dict.ContainsKey(num)) {
            dict.Add(num, 1);
           } else {
            dict[num]++;
           }
        }
    int maxCount = 0;
        foreach (var kvp in dict) {
            if (kvp.Value > (nums.Length / 2)) {
                maxCount = kvp.Key;
                break;
            }
        }
        return maxCount;
        
    }
}