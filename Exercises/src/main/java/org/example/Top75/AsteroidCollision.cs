public class AsteroidCollision {
    public int[] AsteroidCollision(int[] asteroids) {
        Stack<int> stack = new Stack<int>();

        for(int i = 0;i<asteroids.Length;i++)
        {
            if(stack.Count == 0 || asteroids[i] > 0){
                stack.Push(asteroids[i]);
                continue;
            }

            if(asteroids[i] < 0 && stack.Peek() > 0 ){
                bool isCurrentAsteroidValid = true;
                while(stack.Count > 0 && stack.Peek() > 0)
                {
                    if(Math.Abs(stack.Peek()) == Math.Abs(asteroids[i]))
                    {
                        stack.Pop();
                        isCurrentAsteroidValid = false;
                        break;
                    }
                    else if(Math.Abs(stack.Peek()) > Math.Abs(asteroids[i]))
                    {
                       isCurrentAsteroidValid = false;;
                       break;
                    }
                    else{
                        stack.Pop();
                    }
                }
                if(isCurrentAsteroidValid) stack.Push(asteroids[i]);
                
            }
            else{
                stack.Push(asteroids[i]);
            }
            
        }
        return stack.Reverse().ToArray();


    }
}

/*We are given an array asteroids of integers representing asteroids in a row. The indices of the asteriod in the array represent their relative position in space.
For each asteroid, the absolute value represents its size, and the sign represents its direction (positive meaning right, negative meaning left).
Each asteroid moves at the same speed.
Find out the state of the asteroids after all collisions. If two asteroids meet, the smaller one will explode. If both are the same size, 
both will explode. Two asteroids moving in the same direction will never meet.

 

Example 1:

Input: asteroids = [5,10,-5]
Output: [5,10]
Explanation: The 10 and -5 collide resulting in 10. The 5 and 10 never collide.
Example 2:

Input: asteroids = [8,-8]
Output: []
Explanation: The 8 and -8 collide exploding each other.
Example 3:

Input: asteroids = [10,2,-5]
Output: [10]
Explanation: The 2 and -5 collide resulting in -5. The 10 and -5 collide resulting in 10.
 */