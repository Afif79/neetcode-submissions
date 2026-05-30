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
            if(dic1.ContainsKey(s[i]))
            {
                dic1[s[i]] += 1;
            }
            else
            {
                dic1[s[i]] = 1;
            }

            if(dic2.ContainsKey(t[i]))
            {
                dic2[t[i]] += 1;
            }
            else
            {
                dic2[t[i]] = 1;
            }
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
