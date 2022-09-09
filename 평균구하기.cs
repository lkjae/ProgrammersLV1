/*문제 설명
정수를 담고 있는 배열 arr의 평균값을 return하는 함수, solution을 완성해보세요.*/


using System.Linq;

public class Solution {
    public double solution(int[] arr) {
        double answer = 0;
        
        double sum = arr.Sum();
        
        answer = sum/arr.Length;
        
        return answer;
    }
}
