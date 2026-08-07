public class Solution {
    public int[] GetConcatenation(int[] array) 
    {
        int size = array.Length;
        int[] newArray = new int[size*2];
        for (int i = 0; i < array.Length; i++)
        {
            newArray[i] = array[i];
            newArray[i+size] = array[i];
        }
        return newArray;
    }
}