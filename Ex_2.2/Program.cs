using System;

struct Student
{
    public string Name;
    public double Maths;
    public double Phys;
    public double Rus;

    public double AverageScore()
    {
        return (Maths + Phys + Rus) / 3;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student[] students = new Student[4];

        students[0].Name = "Masha";
        students[0].Maths = 5;
        students[0].Phys = 4;
        students[0].Rus = 5;

        students[1].Name = "Oleg";
        students[1].Maths = 3;
        students[1].Phys = 3;
        students[1].Rus = 5;

        students[2].Name = "Vova";
        students[2].Maths = 3;
        students[2].Phys = 5;
        students[2].Rus = 4;

        students[3].Name = "Pasha";
        students[3].Maths = 3;
        students[3].Phys = 2;
        students[3].Rus = 5;

        int count = 0;

        for (int i = 0; i < 4; i++)
        {
            if (students[i].Maths != 2 && students[i].Phys != 2 && students[i].Rus != 2)
            {
                count++;
            }
        }

        Student[] goodstudent = new Student[count];

        int ind = 0;
        for (int i = 0; i < 4; i++)
        {
            if (students[i].Maths != 2 && students[i].Phys != 2 && students[i].Rus != 2)
            {
                goodstudent[ind] = students[i];
                ind++;
            }
        }

        for (int i = 0; i < goodstudent.Length - 1; i++)
        {
            for (int j = i + 1; j < goodstudent.Length; j++)
            {
                if (goodstudent[j].AverageScore() > goodstudent[i].AverageScore())
                {
                    Student temp = goodstudent[i];
                    goodstudent[i] = goodstudent[j];
                    goodstudent[j] = temp;
                }
            }
        }
        for (int i = 0; i < goodstudent.Length; i++)
        {
            Console.WriteLine($"Student: {goodstudent[i].Name}, Average score: {goodstudent[i].AverageScore()}");
        }
    }
}