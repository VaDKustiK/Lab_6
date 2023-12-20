using System;

struct Group
{
    public string Name;
    public int[] Scores;

    public Group(string name, int[] scores)
    {
        Name = name;
        Scores = scores;
    }

    public double Result()
    {
        double sum = 0;
        for (int i = 0; i < 5; i++)
        {
            sum += Scores[i];
        }
        return sum / 5;
    }
}

class Program
{
    static void Main()
    {
        Group[] groups = new Group[3];

        groups[0].Name = "group 1";
        groups[0].Scores = new int[] { 79, 95, 81, 75, 65 };

        groups[1].Name = "group 2";
        groups[1].Scores = new int[] { 83, 74, 99, 84, 71 };

        groups[2].Name = "group 3";
        groups[2].Scores = new int[] { 92, 88, 91, 87, 79 };

        Sort(groups);

        Console.WriteLine("Groups\t\tAverage Score");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"{groups[i].Name}:\t{groups[i].Result()}");
        }
    }

    static void Sort(Group[] groups)
    {
        for (int i = 0; i < 3 - 1; i++)
        {
            for (int j = 0; j < 3 - i - 1; j++)
            {
                if (groups[j].Result() < groups[j + 1].Result())
                {
                    Group temp = groups[j];
                    groups[j] = groups[j + 1];
                    groups[j + 1] = temp;
                }
            }
        }
    }
}