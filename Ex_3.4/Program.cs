using System;

struct Race
{
    public string Name;
    public int Result;

    public Race(string name, int result)
    {
        Name = name;
        Result = result;
    }
}

class Program
{
    static void Main()
    {
        Race[] group1 = new Race[3];
        group1[0] = new Race("Ivanov", 53);
        group1[1] = new Race("Volkov", 41);
        group1[2] = new Race("Sidorov", 46);

        Race[] group2 = new Race[3];
        group2[0] = new Race("Kashin", 42);
        group2[1] = new Race("Babkin", 49);
        group2[2] = new Race("Bobrov", 36);

        Sort(group1);
        Sort(group2);

        Race[] allracers = new Race[6];
        AllRacers(group1, group2, allracers);

        Sort(allracers);

        Console.WriteLine("Place\tName\tResult");
        int count = 1;
        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine($"{count})\t{allracers[i].Name}\t{allracers[i].Result} min");
            count++;
        }
    }

    static void AllRacers(Race[] group1, Race[] group2, Race[] allgroups)
    {
        int ind = 0;
        for (int i = 0; i < 3; i++)
        {
            allgroups[ind] = group1[i];
            ind++;
        }
        for (int i = 0; i < 3; i++)
        {
            allgroups[ind] = group2[i];
            ind++;
        }
    }

    static void Sort(Race[] results)
    {
        for (int i = 0; i < results.Length - 1; i++)
        {
            for (int j = i + 1; j < results.Length; j++)
            {
                if (results[i].Result > results[j].Result)
                {
                    Race temp = results[i];
                    results[i] = results[j];
                    results[j] = temp;
                }
            }
        }
    }
}