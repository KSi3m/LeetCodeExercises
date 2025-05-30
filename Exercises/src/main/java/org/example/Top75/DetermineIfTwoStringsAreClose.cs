public class DetermineIfTwoStringsAreClose {
    public bool CloseStrings(string word1, string word2) {
        
        if(word1.Length != word2.Length ) return false;

        Dictionary<char,int> dict1 = new Dictionary<char,int>();
        Dictionary<char,int> dict2 = new Dictionary<char,int>();

        foreach(char x in word1){
            if(dict1.TryGetValue(x, out var value))
                 dict1[x]++;
            else 
                dict1[x] = 1;
        }
         foreach(char x in word2){
            if(dict2.TryGetValue(x,out int value))
                 dict2[x]++;
            else 
                dict2[x] = 1;
        }
        
        if(!new HashSet<char>(dict1.Keys).SetEquals(dict2.Keys)){
            return false;
        }

        List<int> val1 = new List<int>(dict1.Values);
        List<int> val2 = new List<int>(dict2.Values);

        val1.Sort();
        val2.Sort();

        return val1.SequenceEqual(val2);
    }
}

/*Two strings are considered close if you can attain one from the other using the following operations:

Operation 1: Swap any two existing characters.
For example, abcde -> aecdb
Operation 2: Transform every occurrence of one existing character into another existing character, and do the same with the other character.
For example, aacabb -> bbcbaa (all a's turn into b's, and all b's turn into a's)
You can use the operations on either string as many times as necessary.

Given two strings, word1 and word2, return true if word1 and word2 are close, and false otherwise.

 

Example 1:

Input: word1 = "abc", word2 = "bca"
Output: true
Explanation: You can attain word2 from word1 in 2 operations.
Apply Operation 1: "abc" -> "acb"
Apply Operation 1: "acb" -> "bca"
Example 2:

Input: word1 = "a", word2 = "aa"
Output: false
Explanation: It is impossible to attain word2 from word1, or vice versa, in any number of operations.
Example 3:

Input: word1 = "cabbba", word2 = "abbccc"
Output: true
Explanation: You can attain word2 from word1 in 3 operations.
Apply Operation 1: "cabbba" -> "caabbb"
Apply Operation 2: "caabbb" -> "baaccc"
Apply Operation 2: "baaccc" -> "abbccc"
 
 */