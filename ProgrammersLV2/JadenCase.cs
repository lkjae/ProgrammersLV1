/*문제 설명
JadenCase란 모든 단어의 첫 문자가 대문자이고, 그 외의 알파벳은 소문자인 문자열입니다. 단, 첫 문자가 알파벳이 아닐 때에는 이어지는 알파벳은 소문자로 쓰면 됩니다. (첫 번째 입출력 예 참고)
문자열 s가 주어졌을 때, s를 JadenCase로 바꾼 문자열을 리턴하는 함수, solution을 완성해주세요.*/


using System;
using System.Text;

public class Solution {
    public string solution(string s) {
        string answer = "";
        string str2 = "";
        s.ToLower();
        string[] words  = s.Split(' ');
        var sb = new StringBuilder();
        
        for(int i = 0; i < words.Length; i++)
        {
            
            string str = words[i];
            
            char[] chars = str.ToCharArray();
            
            if(chars[0] > '0' && chars[0] <='9')
            {
                str2 = new string(chars);
            }
            else
            {
                chars[0] = char.ToUpper(chars[0]);
                str2 = new string(chars);
                
            }
            sb.Append(str2 + ' ');
            answer = sb.ToString();
        }
        
        
        return answer;
    }
}
// 런타임 에러
// 최적화 or 문법적인 요소 체크, 알고리즘 체크
