package org.example.Top75;

public class MergeStringsAlternatively {
    public static void main(String[] args) {

        System.out.println(mergeAlternately("abcd","123456789"));
    }

    public static String mergeAlternately(String word1, String word2) {
        char[] temp = new char[word1.length()+word2.length()];
        boolean left = true;
        int x = 0; int y = 0; int k = 0;
        while(x<word1.length() && y<word2.length())
        {
            if(left)
            {
                temp[k++]=word1.charAt(x);
                x++;
                left = false;
            }
            else{
                temp[k++] = word2.charAt(y);
                y++;
                left = true;
            }
        }
        while(x<word1.length())
        {
            temp[k++]=word1.charAt(x);
            x++;
        }
        while(y<word2.length())
        {
            temp[k++]=word2.charAt(y);
            y++;
        }
        return String.valueOf(temp);

    }

    public static String mergeAlternatelySB(String word1, String word2) {

        StringBuilder sb = new StringBuilder();
        boolean left = true;
        int x = 0; int y = 0;
        while(x<word1.length() && y<word2.length())
        {
            if(left)
            {
                sb.append(word1.charAt(x));
                x++;
                left = false;
            }
            else{
                sb.append(word2.charAt(y));
                y++;
                left = true;
            }
        }
        while(x<word1.length())
        {
            sb.append(word1.charAt(x));
            x++;
        }
        while(y<word2.length())
        {
            sb.append(word2.charAt(y));
            y++;
        }
        return sb.toString();
    }

}
