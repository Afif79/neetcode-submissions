public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> set = new HashSet<int>(nums);
        int maximum = 0;
        foreach (int n in nums)
        {
            if (set.Contains(n - 1)) continue;
            int length = 1;
            while (set.Contains(n + length))
            {
                length++;
            }
            maximum = Math.Max(length, maximum);
        }
        return maximum;
    }
}
