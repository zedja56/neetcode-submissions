public class Solution 
{
    public int CountStudents(int[] students, int[] sandwiches) 
    {
        //this logic adds students array to a Queue
        Queue<int> studentQueue = new Queue<int>();
        foreach (int student in students)
        {
            studentQueue.Enqueue(student);
        }

        //cache the total number of students array
        int number = students.Length;
        //makes a dummy variable to be decremented everytime studentQueue gets Dequeued
        int remaining = number;

        //this handles the logic where the students go back to the back of the line or goes out of the line depending on the sandwich on top
        foreach (int sandwich in sandwiches)
        {
            //counter for the number of student checked for the sandwich and ensure that the loop is not infinite
            int counter = 0;
            while (counter < number && studentQueue.Peek() != sandwich)
            {
                //this handles the logic where the students move back to the back of the line
                studentQueue.Enqueue(studentQueue.Dequeue());
                counter++;
            }

            //this handles the logic where the student have the sandwhich they want
            if (studentQueue.Peek() == sandwich)
            {
                studentQueue.Dequeue();
                remaining--;
            }
            else 
            {
                break;
            }

        }
        return remaining;
    }
}