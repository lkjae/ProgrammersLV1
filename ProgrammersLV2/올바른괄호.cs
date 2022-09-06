/*문제 설명
괄호가 바르게 짝지어졌다는 것은 '(' 문자로 열렸으면 반드시 짝지어서 ')' 문자로 닫혀야 한다는 뜻입니다. 예를 들어

"()()" 또는 "(())()" 는 올바른 괄호입니다.
")()(" 또는 "(()(" 는 올바르지 않은 괄호입니다.
'(' 또는 ')' 로만 이루어진 문자열 s가 주어졌을 때, 문자열 s가 올바른 괄호이면 true를 return 하고, 올바르지 않은 괄호이면 false를 return 하는 solution 함수를 완성해 주세요.*/


using System;
using System.Text;

public class Solution {
    public bool solution(string s) {
        bool answer = true;
        int cnt_q = 0;
        int cnt_w = 0;
        char[] charArr = s.ToCharArray();
        for(int i = 0; i < charArr.Length; i++)
        {
            if(charArr[i] == '(')
            {
                cnt_q++;
            }
            if(charArr[i] == ')')
            {
                cnt_w++;
            }
            if(cnt_q < cnt_w)answer = false;
            
        }
        
        if(cnt_q != cnt_w)
        {
            answer = false;
        }
        
        
        return answer;
    }
}


채점 결과
정확성: 69.5
효율성: 30.5
합계: 100.0 / 100.0
