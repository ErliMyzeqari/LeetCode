public class Solution {
    public bool IsValid(string s) {
        
        Stack<char> staku = new Stack<char>();  

        for(int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            if(c == '(' || c == '[' || c == '{')
                staku.Push(c);

            if(c==')')
            {
                if(!staku.Any() || staku.Pop() != '(')
                {
                    return false;
                }
                 
            }
            
           if(c==']')
            {
                if(!staku.Any() || staku.Pop() != '[' )
                {
                    return false;
                }
                 
            }
            if(c== '}')
            {
                if(!staku.Any() || staku.Pop() != '{')
                {
                    return false;
                }
                 
            }
            
            

        }
        if(staku.Any()){
            return false;
        }
        
        return true;
    }
}