package org.example.Top75;

public class ContainerWithMostWater {
    public int maxArea(int[] height) {
        int l = 0;
        int r = height.length -1;
        int currentArea = 0;

        while(l!=r)
        {
            int tempArea;
            if(height[l] < height[r])
            {
                tempArea = Math.abs(r-l)*height[l];
                l++;
            }
            else{
                tempArea = Math.abs(r-l)*height[r];
                r--;
            }
            if(tempArea > currentArea) currentArea = tempArea;
        }
        return currentArea;
    }
}
/*
You are given an integer array height of length n.
There are n vertical lines drawn such that the two
endpoints of the ith line are (i, 0) and (i, height[i]).

Find two lines that together with the x-axis form a container,
such that the container contains the most water.
Return the maximum amount of water a container can store.
Notice that you may not slant the container.



Example 1:
Input: height = [1,8,6,2,5,4,8,3,7]
Output: 49
Explanation: The above vertical lines are represented by array [1,8,6,2,5,4,8,3,7].
In this case, the max area of water (blue section) the container can contain is 49.
Example 2:

Input: height = [1,1]
Output: 1
 */