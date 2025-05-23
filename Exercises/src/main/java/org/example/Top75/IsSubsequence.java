package org.example.Top75;

public class IsSubsequence {
    public boolean isSubsequence(String s, String t) {
        if(s.length() == 0) return true;
        if(t.length() == 0) return false;
        int ptr1= 0;
        int ptr2 = 0;
        while(ptr2<t.length())
        {
            if(s.charAt(ptr1) == t.charAt(ptr2))
            {
                ptr1++;
            }
            if(ptr1==s.length()) return true;
            ptr2++;
        }
        return false;
    }
}
/*
Given two strings s and t, return true if s is a subsequence of t, or false otherwise.

A subsequence of a string is a new string that is formed from the original
string by deleting some (can be none) of the characters without disturbing
the relative positions of the remaining characters. (i.e., "ace" is a subsequence of
"abcde" while "aec" is not).

Example 1:
Input: s = "abc", t = "ahbgdc"
Output: true
Example 2:

Input: s = "axc", t = "ahbgdc"
Output: false
 */