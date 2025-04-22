package org.example.Top75;

public class GreatestCommonDiviserOfStrings {

    public static void main(String[] args) {

        System.out.println(gcdOfStrings("ABCABC","ABC"));
    }

    public static String gcdOfStrings(String str1, String str2) {
        String base = "";
        if(str1.length() <= str2.length())
        {
            base = str1;
        } else{
            base = str2;
        }

        for(int i=0;i<base.length();i++)
        {
            String temp = base.substring(0, base.length()-i);
            if(str1.length() % temp.length() > 0 || str2.length() % temp.length() > 0)
            {
                continue;
            }

            if(str1.replace(temp,"").isEmpty() && str2.replace(temp,"").isEmpty())
            {
                return temp;
            }
        }
        return "";
    }
}
