public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
        {
            return false;
        }
        Dictionary<char, int> dic1 = new Dictionary<char, int>();
        Dictionary<char, int> dic2 = new Dictionary<char, int>();
        for(int i = 0; i < s.Length; i++)
        {
            dic1.TryGetValue(s[i], out var currentCount1);
            dic1[s[i]] = currentCount1 + 1; 
            
            dic2.TryGetValue(t[i], out var currentCount2);
            dic2[t[i]] = currentCount2 + 1;
        }

        foreach (var kvp in dic1)
        {
            if (!dic2.ContainsKey(kvp.Key))
            {
                return false;
            }

            if (dic2[kvp.Key] != kvp.Value)
            {
                return false;
            }
        }

        return true;
    }
}
