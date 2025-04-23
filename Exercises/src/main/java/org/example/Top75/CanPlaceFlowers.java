package org.example.Top75;

public class CanPlaceFlowers {
    public static void main(String[] args) {

        System.out.println(canPlaceFlowers(new int[]{1,0,1,0,1,0,0},1));
    }
    public static boolean canPlaceFlowers(int[] flowerbed, int n) {

        if(n == 0) return true;
        if(flowerbed.length == 1 && flowerbed[0] == 0)
        {
            flowerbed[0] = 1;
            n--;
        }
        for(int i = 0;i<flowerbed.length-1 && n>0;i++)
        {
            if(i==0)
            {
                if(flowerbed[1] == 0 && flowerbed[0] == 0)
                {
                    flowerbed[0]=1;
                    n--;
                }
                continue;
            }
            if(i==flowerbed.length-2)
            {
                if(flowerbed[i] == 0 && flowerbed[i+1] == 0)
                {
                    flowerbed[i+1]=1;
                    n--;
                }
                continue;
            }
            if(flowerbed[i-1] == 0 && flowerbed[i+1] == 0 && flowerbed[i]==0)
            {
                flowerbed[i]=1;
                n--;
            }
        }
        return n==0;
    }
}

/*You have a long flowerbed in which some of the plots are planted,
and some are not. However, flowers cannot be planted in adjacent plots.

Given an integer array flowerbed containing 0's and 1's,
where 0 means empty and 1 means not empty, and an integer n,
return true if n new flowers can be planted in the flowerbed
without violating the no-adjacent-flowers rule and false otherwise.


Example 1:

Input: flowerbed = [1,0,0,0,1], n = 1
Output: true
Example 2:

Input: flowerbed = [1,0,0,0,1], n = 2
Output: false

 */
