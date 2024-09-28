public class Solution {
    
Dictionary<int, int> memo = new Dictionary<int, int>(); 

    public int ClimbStairs(int n) {
        
        if(n <= 2){
            return n;
        }

        if(memo.ContainsKey(n)){
              
            return memo[n];
        }

        memo.Add(n, ClimbStairs(n-1) + ClimbStairs(n-2));
        
        return memo[n];
        
    }
}