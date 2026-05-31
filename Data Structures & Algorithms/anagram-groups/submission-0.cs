public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        if(strs.Length == 0)
            return new List<List<string>>();

        Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();

        for(int s = 0; s < strs.Length; s++)
        {
            int[] arr = new int[26];
            Array.Fill(arr, 0);

            foreach(var c in strs[s])
            {
                arr[c - 'a'] += 1;
            }
            StringBuilder stringBuilder = new StringBuilder();
            for(int i = 0; i < arr.Length; i++)
            {
                stringBuilder.Append("#");
                stringBuilder.Append(arr[i]);
            }
            var key = stringBuilder.ToString();
            
            if(!map.ContainsKey(key))
            {
                map[key] = new List<string>();
            }
            map[key].Add(strs[s]);
        }
        return new List<List<string>>(map.Values);
    }
}
