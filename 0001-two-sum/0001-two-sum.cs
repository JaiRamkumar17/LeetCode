public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] n = new int[2];
        for(int i = 0; i < nums.Length; i++ ){
        for(int j = 0; j < nums.Length; j++ ){
            if (i!=j){
                if(nums[i]+nums[j] == target){
                    n[0]= i;
                    n[1] = j;
                    return n;
                }
            }
        }

        }
        return n;
    }
}