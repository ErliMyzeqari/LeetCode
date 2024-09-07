public class Solution {
    public bool IsPalindrome(int x) {
        
        string myString = x.ToString();

        int i = 0;
        int j = myString.Length - 1;

        while(i<j)
        {
            if(myString[i] == myString[j]){
                i++;
                j--;
            }
            else{
                return false;
            }
            
        }

        return true;

    }
}