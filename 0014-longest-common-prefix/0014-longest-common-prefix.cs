public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        string a = "";int count =0;
        Array.Sort(strs);
        for (int i =0; i< strs[0].Length; i++){
            count =0;
            for(int j=1; j<strs.Length; j++){
                if(strs[0][i] == strs[j][i]){
                    count++;
                }
            }
            if(count+1 == strs.Length){
                a+= strs[0][i];
            }
            else{
                return a;
            }
        }
        return a;
    }
}