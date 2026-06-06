public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var result = new List<List<string>>();
        var occurenceDictionaryToResultIndex = new Dictionary<string, int>();
        
        for(int strIndex = 0; strIndex < strs.Length; strIndex++) {
            var str = strs[strIndex];
            
            var charOccurence = new int[26];
            Array.Fill(charOccurence, 0);
            // Get number of occurence for each char for current str
            for(var cIndex = 0 ; cIndex < str.Length; cIndex++){
                var c = str[cIndex];
                var alphabetPosition = char.ToLower(c) - 'a';
               charOccurence[alphabetPosition] = charOccurence[alphabetPosition] + 1;
            }

            var key = string.Join("#", charOccurence);

            if(occurenceDictionaryToResultIndex.TryGetValue(key, out var resultIndex)) {
                result[resultIndex].Add(str);
            }else {
                occurenceDictionaryToResultIndex[key] = result.Count;
                result.Add([str]);
            }       
        }

        return result;
    }
}
