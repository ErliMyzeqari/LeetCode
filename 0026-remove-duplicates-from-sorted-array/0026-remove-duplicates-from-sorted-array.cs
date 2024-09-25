public class Solution {
    public int RemoveDuplicates(int[] nums) {
        
        if(nums.Length <=1){
            return nums.Length;
        }

        int j = 1;

        for(int i = 1; i < nums.Length; i++){
            
            if(nums[i] != nums[i-1]){
                nums[j] = nums[i];
                j++;
            }
            
        }

        return j;       

    }
}