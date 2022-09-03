using System;

class Solution
{
    public int solution(int[] nums)
    {
        int answer = 0;
        for(int i = 0; i < nums.Length - 2; ++i)
        {
            for(int j = i +1; j < nums.Length - 1; ++j)
            {
                for(int k = j + 1; k < nums.Length; ++k)
                {
                    int sum = nums[i] + nums[j] + nums[k];
                    if(isPrime(sum))
                    {
                        answer++;
                    }
                }
            }
        }
       

        return answer;
    }
    bool isPrime(int num)
    {
        
        for(int i = 2; i < num; ++i)
        {
            if(num % i == 0){return false;}
            
        }
        return true;
        
    }
}

//각 자리수만큼 for문을 돌려서 세 수를 더한 값을 isPrime함수를 사용하여 소수인지 구분하였음
