/*문제 설명
임의의 양의 정수 n에 대해, n이 어떤 양의 정수 x의 제곱인지 아닌지 판단하려 합니다.
n이 양의 정수 x의 제곱이라면 x+1의 제곱을 리턴하고, n이 양의 정수 x의 제곱이 아니라면 -1을 리턴하는 함수를 완성하세요.*/

using System;
public class Solution {
    public long solution(long n) {
        long answer = 0;
        double x = Math.Sqrt(n);

        if(x%1==0) 
            return (long)((x+1)*(x+1));
        else 
            return -1;
    
        return answer;
    }
}
채점 결과
정확성: 100.0
합계: 100.0 / 100.0
//정수는 1로나눈 나머지가 1이다.
