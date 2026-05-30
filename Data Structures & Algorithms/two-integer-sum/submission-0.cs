public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> map = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++)
        {
            var res = target - nums[i];
            if (map.ContainsKey(res))
            {
                return new[] {map[res], i};
            }
            map[nums[i]] = i; 
        }
        return new[] {-1, -1};
    }
}
