public class Solution {
    public bool IsValid(string s) {
        
        string t ="";
        Stack f = new Stack();
        for(int i = 0 ; i< s.Length; i++){
            if(s[i] == '(' || s[i] == '{' || s[i] == '['){
                f.Push(s[i]);
                t= s[i].ToString();
            }else{
                if(f.Count == 0){
                    return false;
                }
                if((s[i] == ')') && (t== "(")){
                    f.Pop();
                    t= f.Count>0?f.Peek().ToString():"";
                }
                else if(s[i] == '}' && t== "{"){
                    f.Pop();
                    t= f.Count>0?f.Peek().ToString():"";
                }
                else if(s[i] == ']' && t== "["){
                    f.Pop();
                    t= f.Count>0?f.Peek().ToString():"";
                }else{
                    return false;
                }
            }
        }
        if(f.Count == 0){
            return true;
        }else{
            return false;
        }
    }
}