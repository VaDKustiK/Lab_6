using System;

struct Student
{
    public string Name;
    public double[] Scores;
    public double AverageScore;
}

class Program
{
    static void Main(string[] args)
    {
        Student[] student = new Student[3];

        student[0].Name = "Masha"; // у меня не работает кодировка UTF-8 поэтому пишу на английском
        student[0].Scores = new double[] { 5, 5, 3, 4 };
        student[0].AverageScore = Result(student[0].Scores);

        student[1].Name = "Vova";
        student[1].Scores = new double[] { 5, 4, 5, 4 };
        student[1].AverageScore = Result(student[1].Scores);

        student[2].Name = "Oleg";
        student[2].Scores = new double[] { 3, 4, 4, 5 };
        student[2].AverageScore = Result(student[2].Scores);

        int count = 0;
        Student[] Sort = new Student[student.Length];
        for (int i = 0; i < student.Length; i++)
        {
            if (student[i].AverageScore >= 4)
            {
                Sort[count] = student[i];
                count++;
            }
        }

        for (int i = 0; i < count - 1; i++)
        {
            for (int j = i + 1; j < count; j++)
            {
                if (Sort[j].AverageScore > Sort[i].AverageScore)
                {
                    Student temp = Sort[i];
                    Sort[i] = Sort[j];
                    Sort[j] = temp;
                }
            }
        }

        Console.WriteLine("Name\t\tAverage Score");

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"{Sort[i].Name}\t\t{Sort[i].AverageScore}");
        }
    }

    static double Result(double[] scores)
    {
        if (scores.Length > 0)
        {
            double sum = 0;
            for (int i = 0; i < scores.Length; i++)
            {
                sum += scores[i];
            }
            return sum / scores.Length;
        }
        else
        {
            return 0;
        }
    }
}