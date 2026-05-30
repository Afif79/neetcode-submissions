public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> dic = new HashSet<int>();
        foreach(int i in nums)
        {
            if(dic.Contains(i))
            {
                return true;
            }
            dic.Add(i);
        }

        return false;
    }
}