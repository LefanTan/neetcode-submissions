public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> occurenceHash = new();
        
        if(s.Length != t.Length) {
            return false;
        }

        for(var i = 0; i < s.Length; i++) {
            if(occurenceHash.ContainsKey(s[i])) {  
                occurenceHash[s[i]] = occurenceHash[s[i]] + 1; 
            }else {
                occurenceHash[s[i]] = 1;
            }
        }

        for(var i = 0; i < t.Length; i++) {
            if(occurenceHash.TryGetValue(t[i], out var tChar)) {
                if(tChar > 0) {
                    occurenceHash[t[i]]--;
                    continue;
                }else {
                    return false;
                }
            }
            return false;
        }

        return true;
    }
}
