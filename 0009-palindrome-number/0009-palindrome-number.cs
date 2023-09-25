public class Solution {
    public bool IsPalindrome(int x) {
        if(x>=0){
            string s = x.ToString();
            int f =0;
            int i=0;
            int l=s.Length-1;
            while(i<= s.Length/2){
                if(s[f]==s[l]){
                    i++;
                    f++;
                    l--;
                    if(f>=s.Length/2){
                        return true;
                    }
                }
                else{
                    break;
                }
            }
        }
        return false;
    }
}