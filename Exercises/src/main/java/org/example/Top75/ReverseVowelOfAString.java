package org.example.Top75;

import java.util.*;

public class ReverseVowelOfAString {

    public static void main(String[] args) {

        System.out.println(reverseVowelsTwoPointers("IceCreAm"));
    }

    public static String reverseVowels(String s) {
        List<Character> vovels = Arrays.asList('a','e','u','i','o','A','E','U','I','O');
        List<Character> chars = new ArrayList<>();
        var charArray = s.toCharArray();
        for(int i = 0; i<charArray.length;i++)
        {
            if(vovels.contains(charArray[i]))
            {
                chars.add(charArray[i]);
                charArray[i] = '\0';
            }

        }
        var lastIndex = chars.size()-1;
        for(int i = 0; i<charArray.length && lastIndex > -1;i++)
        {
            if(charArray[i] == '\0') charArray[i]=chars.get(lastIndex--);
        }
        return String.valueOf(charArray);
    }
    public static String reverseVowelsTwoPointers(String s) {
        Set<Character> vovels = Set.of('a','e','u','i','o','A','E','U','I','O');
        var charArray = s.toCharArray();
        int l = 0;
        int r = charArray.length - 1;
        while(l<r)
        {
            while(!vovels.contains(charArray[l]) && l<r){
                l++;
            }

            while(!vovels.contains(charArray[r]) && l<r){
                r--;
            }
            if(l<r)
            {
                char temp = charArray[l];
                charArray[l] = charArray[r];
                charArray[r] = temp;
                r--;
                l++;
            }
        }

        return String.valueOf(charArray);
    }
}
/*Given a string s, reverse only all the vowels in the string and return it.

The vowels are 'a', 'e', 'i', 'o', and 'u', and they can appear in both lower and upper cases, more than once.


Example 1:

Input: s = "IceCreAm"

Output: "AceCreIm"

Explanation:

The vowels in s are ['I', 'e', 'e', 'A']. On reversing the vowels, s becomes "AceCreIm".

Example 2:

Input: s = "leetcode"

Output: "leotcede"

 */