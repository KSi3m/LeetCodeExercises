package org.example.Top75;

public class MaximumNumberOfVowels {

    public int maxVowels(String s, int k) {
        Set<Character> set = Set.of('a','e','i','o','u');
        int left = 0;
        int right = k-1;
        int count =0;
        for(int i=0;i<k;i++)
        {
            if(set.contains(s.charAt(i))) count++;
        }
        int tempCount = count;
        while(right<s.length()-1)
        {
            if(set.contains(s.charAt(left++))) tempCount--;
            if(set.contains(s.charAt(++right))) tempCount++;
            if(tempCount>count) count = tempCount;
        }
        return count;
    }
}

/*Given a string s and an integer k, return the maximum number of vowel letters in any substring of s with length k.
Vowel letters in English are 'a', 'e', 'i', 'o', and 'u'.

Example 1:

Input: s = "abciiidef", k = 3
Output: 3
Explanation: The substring "iii" contains 3 vowel letters.
Example 2:

Input: s = "aeiou", k = 2
Output: 2
Explanation: Any substring of length 2 contains 2 vowels.
Example 3:

Input: s = "leetcode", k = 3
Output: 2
Explanation: "lee", "eet" and "ode" contain 2 vowels.
*/