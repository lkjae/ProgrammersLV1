/*배열 array의 i번째 숫자부터 j번째 숫자까지 자르고 정렬했을 때, k번째에 있는 수를 구하려 합니다.

예를 들어 array가 [1, 5, 2, 6, 3, 7, 4], i = 2, j = 5, k = 3이라면

array의 2번째부터 5번째까지 자르면 [5, 2, 6, 3]입니다.
1에서 나온 배열을 정렬하면 [2, 3, 5, 6]입니다.
2에서 나온 배열의 3번째 숫자는 5입니다.
배열 array, [i, j, k]를 원소로 가진 2차원 배열 commands가 매개변수로 주어질 때, 
commands의 모든 원소에 대해 앞서 설명한 연산을 적용했을 때 나온 결과를 배열에 담아 return 하도록 solution 함수를 작성해주세요.*/

using System;

public class Solution {
    public int[] solution(int[] array, int[,] commands) {
        int[] answer = new int[commands.GetLength(0)];
        
        
        for(int i = 0; i <  commands.GetLength(0);i++)
        {
            int start_idx = commands[i,0];
            int end_idx = commands[i,1];
            int check_num = commands[i,2];
            int length = end_idx - start_idx + 1;
            
            int[] res_arr = new int[length];
            
            Array.Copy(array, start_idx-1, res_arr, 0, length);               
            Array.Sort(res_arr);
            
            answer[i] = res_arr[check_num-1];
                        
        }
        
        return answer;
    }
}

//array배열을 복사 후 정렬하고, commands[i,2]-1에 있는 값을 answer[i]에 대입
//배열은 0부터 시작하기 때문에 -1을 해주어야 한다.
//배열 index를 올바르게 잘라서 사용할 수 있는가가 
