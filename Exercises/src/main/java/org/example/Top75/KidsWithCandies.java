package org.example.Top75;

import java.util.ArrayList;
import java.util.List;

public class KidsWithCandies {
    public static void main(String[] args) {

        kidsWithCandies(new int[]{2,3,5,1,3},3).forEach(System.out::println);
    }
    public static List<Boolean> kidsWithCandies(int[] candies, int extraCandies) {
        List<Boolean> output = new ArrayList<>();
        int max = -1;
        for(int i=0;i<candies.length;i++)
        {
            if(candies[i] > max)
            {
                max = candies[i];
            }
        }

        for(int i=0;i<candies.length;i++)
        {
            if(candies[i]+extraCandies >= max )
                output.add(true);
            else
                output.add(false);
        }
        return output;
    }
}
