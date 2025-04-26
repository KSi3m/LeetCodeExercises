package org.example.Top75;

public class MaximumAverageSubarray {

    public double findMaxAverage(int[] nums, int k) {
        int left = 0;
        int right = k-1;
        int sum =  0;
    
        for(int i = 0;i<k;i++)
        {
            sum += nums[i];
        }
        int tempSum = sum;
        while(right<nums.length-1)
        {
            tempSum -= nums[left++];
            tempSum += nums[++right];
            if(tempSum > sum) sum = tempSum;
        }
        return (double)sum/k;
    }
}

/*You are given an integer array nums consisting of n elements, and an integer k.
Find a contiguous subarray whose length is equal to k that has the maximum average 
value and return this value. Any answer with a calculation error less than 10-5 will be accepted.
 
Example 1

Input: nums = [1,12,-5,-6,50,3], k = 4
Output: 12.75000
Explanation: Maximum average is (12 - 5 - 6 + 50) / 4 = 51 / 4 = 12.75
Example 2:

Input: nums = [5], k = 1
Output: 5.00000
*/