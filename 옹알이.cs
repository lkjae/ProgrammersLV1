using System;

public class Solution {
    public int solution(string[] babbling) {
        string[] say = new string[] { "aya", "ye", "woo", "ma" };
        int answer = 0;
        int cnt = 0;
        for(int i=0; i < babbling.Length; i++)
        {
            if(babbling[i].Contains("ayaaya") || babbling[i].Contains("yeye") || babbling[i].Contains("woowoo") ||babbling[i].Contains("mama"))
                continue;
            while(1)
            {
                for(int j = 0; j < say.Length; j++)
                {
                    if(babbling[i].Contains(say[j]))
                    {
                        cnt++;
                    }
                    if(cnt == 0)
                        break;
                }   
            }
            if(babbling.Length == 0)
                answer++;
            
                
        }
        
        return answer;
    }
}


/*

indexOf를 사용하여 say에 있는 단어가 있는 index를 조사하여 cnt++를 해주고 삭제 후 다시 체크
ayaaya, yeye, woowoo, mama 안됨
중복이 안되므로 위 4가지 경우는 제외하고 탐색

bool isHave = babbling[i].Contains(say[j])

babbling[0] ~ babbling[babbling.Length]*/
