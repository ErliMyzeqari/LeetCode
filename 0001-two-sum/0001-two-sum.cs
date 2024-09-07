public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        Dictionary<int,int> numb = new Dictionary<int,int>();


        for(int i = 0; i < nums.Length; i++)
        {
           int diff = target- nums[i];
           if(numb.ContainsKey(diff))
           {
            return new int[2] {i,numb[diff]};
           } 

            if(!numb.ContainsKey(nums[i])) 
            {
                numb.Add(nums[i],i);
            }          
                      
        }

        return new int[2] {-1, -1};
    }
}