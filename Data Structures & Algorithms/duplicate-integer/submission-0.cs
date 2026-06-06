public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int, bool> hash = new();
        
        foreach(var i in nums) {
            if(hash.TryGetValue(i, out var exists)) {
                return exists;
            }
            hash[i] = true;
        }
        return false;
    }
}