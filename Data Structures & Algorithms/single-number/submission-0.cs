public class Solution {
    public int SingleNumber(int[] nums) {
        int a = 0;
        foreach(var i in nums)
        {
            a = a^i;
        }
        return a;
    }
}
