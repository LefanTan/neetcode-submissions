public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        // Diff value to index
        Dictionary<int, int> diffHash = new();

        for(int i = 0; i < nums.Length; i++) {
            var diff = target - nums[i];
            
            if(diffHash.TryGetValue(nums[i], out var diffIndex)) {
                return new[] { diffIndex, i };
            }else {
                diffHash[diff] = i;
            }
        }

        return new int[] {};
    }
}
