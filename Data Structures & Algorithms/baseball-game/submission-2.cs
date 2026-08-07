public class Solution {
    public int CalPoints(string[] operations) 
    {
        int[] scoreRecord = new int[operations.Length];
        int counter = 0;
        int cumScore = 0;
        for (int i = 0; i < operations.Length; i++)
        {
            if(int.TryParse(operations[i], out int score))
            {
                scoreRecord[counter] = score;
                counter++;
            }
            else
            {
                switch(operations[i])
                {
                    case "+":
                        scoreRecord[counter] = scoreRecord[counter-1] + scoreRecord[counter - 2];
                        counter++;
                        continue;
                    case "D":
                        scoreRecord[counter] = (scoreRecord[counter-1]*2);
                        counter++;
                        continue;
                    case "C":
                        scoreRecord[counter-1] = 0;
                        counter--;
                        continue;
                }
            }
        }
        for (int i = 0; i < scoreRecord.Length; i++)
        {
            cumScore += scoreRecord[i];
        }
        return cumScore;
    }
}