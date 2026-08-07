public class Solution {
    public int CalPoints(string[] operations) 
    {
        Stack<int> stack = new Stack<int>();
        int recordedScore = 0;
        foreach (var operation in operations)
        {
            int.TryParse(operation, out int score);
            switch (operation)
            {
                case "+":
                    int top = stack.Pop(); //n
                    int newTop = stack.Peek();//n-1
                    int sum = top + newTop; // n + n-1
                    stack.Push(top); //bring back top
                    stack.Push(sum); //add sum
                    recordedScore += sum;
                    continue;
                case "D":
                    int doubleTop = stack.Peek();
                    stack.Push(doubleTop*2);//previous*2
                    recordedScore += (doubleTop*2);
                    continue;
                case "C":
                    int noTop = stack.Pop();
                    recordedScore -= noTop;
                    continue;
                default:
                    stack.Push(score);
                    recordedScore += score;
                    continue;
            }
        }
        return recordedScore;
    }
}