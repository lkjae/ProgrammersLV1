using System;

public class Solution {
    public int solution(int[,] sizes) {
        int answer = 0;
        int max_W = 0;
        int max_H = 0;
        
        for(int i = 0; i < sizes.GetLength(0); i++)
        {
            
            int w = sizes[i,0];
            int h = sizes[i,1];
            
            if(h > w)
            {
                sizes[i,0] = h;
                sizes[i,1] = w;
            }
            if(sizes[i,0] > max_W)
            {
                max_W = sizes[i,0];
            }
            if(sizes[i,1] > max_H)
            {
                max_H = sizes[i,1];
            }
        }
        return max_W * max_H;
    }
}
//2차원 배열에서 두 값을 비교하여 큰 값을 세로로 하고, 작은 값을 가로로 설정하여 
//세로중 큰 값과 가로중 큰값을 곱하면 답이 나옴
