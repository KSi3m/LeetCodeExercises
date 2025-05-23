package org.example.Top75;

import java.util.ArrayList;
import java.util.List;

public class ReverseWordsInString {
    public static void main(String[] args) {

        String test = "  hello world  ";
        System.out.println(reverseWords(test));

    }

    public static String reverseWordsTwoPointers(String s) {

        var stringArray = s.trim().split("\\s+");
        int l = 0;
        int r = stringArray.length - 1;
        while (l < r) {
            String temp = stringArray[l];
            stringArray[l] = stringArray[r];
            stringArray[r] = temp;
            l++;
            r--;
        }
        return String.join(" ", stringArray);
    }
        public static String reverseWords(String s) {
        var x = s.split(" ");
        List<String> sb = new ArrayList<>();
        for(int i =x.length-1;i>=0;i--)
        {
            if(!x[i].isBlank()) sb.add(x[i]);
        }
        return String.join(" ",sb);
    }
}

/*Given an input string s, reverse the order of the words.

A word is defined as a sequence of non-space characters. The words in s will be separated by at least one space.

Return a string of the words in reverse order concatenated by a single space.

Note that s may contain leading or trailing spaces or multiple spaces between two words.
The returned string should only have a single space separating the words. Do not include any extra spaces.


Example 1:

Input: s = "the sky is blue"
Output: "blue is sky the"
Example 2:

Input: s = "  hello world  "
Output: "world hello"
Explanation: Your reversed string should not contain leading or trailing spaces.
Example 3:

Input: s = "a good   example"
Output: "example good a"
Explanation: You need to reduce multiple spaces between two words to a single space in the reversed string.

 */