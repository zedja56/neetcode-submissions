public class Solution {
    public bool IsValid(string s) 
    {
        Stack<char> stack = new Stack<char>();

        for (int i = 0; i < s.Length; i++)
        {
            char current = s[i];
            if (current == '(' || current == '{' || current == '[')
            {
                stack.Push(current);
            }
            else
            {
                if(stack.Count == 0) return false;
                char top = stack.Pop();
                if (current == ')' && top != '(') return false;
                if (current == '}' && top != '{') return false;
                if (current == ']' && top != '[') return false;
            }
        }
        return stack.Count == 0;
    }
}