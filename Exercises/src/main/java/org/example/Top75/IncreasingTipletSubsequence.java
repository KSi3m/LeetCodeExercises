package org.example.Top75;

public class IncreasingTipletSubsequence {

    public boolean increasingTriplet(int[] nums) {
        if(nums.length < 3) return false;
        int lowest = Integer.MAX_VALUE;
        int secondLowest = Integer.MAX_VALUE;
        for(int i =0;i<nums.length;i++)
        {
            if(nums[i] <= lowest)
            {
                lowest = nums[i];
                continue;
            }
            if(nums[i] <= secondLowest)
            {
                secondLowest = nums[i];
                continue;
            }

            if(nums[i] > lowest && nums[i]>secondLowest) return true;
        }
        return false;
    }

}

/*Given an integer array nums, return true if there exists a
triple of indices (i, j, k) such that i < j < k and nums[i] < nums[j] < nums[k].
 If no such indices exists, return false.



Example 1:

Input: nums = [1,2,3,4,5]
Output: true
Explanation: Any triplet where i < j < k is valid.
Example 2:

Input: nums = [5,4,3,2,1]
Output: false
Explanation: No triplet exists.
Example 3:

Input: nums = [2,1,5,0,4,6]
Output: true
Explanation: The triplet (3, 4, 5) is valid because nums[3] == 0 < nums[4] == 4 < nums[5] == 6.

 */