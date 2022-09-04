//어떤 정수들이 있습니다. 이 정수들의 절댓값을 차례대로 담은 정수 배열 absolutes와 이 정수들의 부호를 차례대로 담은 불리언 배열 signs가 매개변수로 주어집니다.
//실제 정수들의 합을 구하여 return 하도록 solution 함수를 완성해주세요.

using System;
using System.Linq;

public class Solution {
    public int solution(int[] absolutes, bool[] signs) {
        
        int answer = 123456789;
        int[] result = new int[absolutes.Length];
        for(int i = 0; i < absolutes.Length; i++)
        {
            if(signs[i]) 
            {
                result[i] = absolutes[i];
            }
            else{
                result[i] = absolutes[i] * (-1);
            } 
            
        }
        answer = result.Sum();
        return answer;
    }
}

//if-else문을 사용하여 signs값을 비교해 음과 양을 분리
//Linq네임스페이스 using, Sum()함수를 사용하여 result[]에 있는 값을 모두 더해서 answer출력
