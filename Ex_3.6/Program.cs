using System;
using System.Text.RegularExpressions;

struct Answer
{
    public string Answer1;
    public string Answer2;
    public string Answer3;
}

class Program
{
    private static void Main()
    {
        int i, j;
        Answer[] answers = new Answer[500];
        for (i = 0; i < answers.Length; i++)
        {
            answers[i].Answer1 = Question1(Random());
            answers[i].Answer2 = Question2(Random());
            answers[i].Answer3 = Question3(Random());
        }

        for (i = 0; i < 3; i++)
        {
            Console.WriteLine($"{i + 1} question:");
            string[] s = new string[answers.Length];
            for (j = 0; j < answers.Length; j++)
            {
                s[j] = Answer(i, j, answers);
            }
            string[,] ans = Matrix(s); // ans
            int count = 0;
            for (j = 0; j < ans.Length/2; j++)
            {
                count += int.Parse(ans[1, j]);
            }

            if (ans.Length/2 > 5)
            {
                for (j = 0; j < 5; j++)
                {
                    Console.WriteLine($"Answer: {ans[0, j]} {double.Parse(ans[1, j]) / count * 100:f1}%");
                }
            }
            else
            {
                for (j = 0; j < ans.Length/2; j++)
                {
                    Console.WriteLine($"Answer: {ans[0, j]} {double.Parse(ans[1, j]) / count * 100:f1}%");
                }
            }
            Console.WriteLine();
        }

    }

    static int Random()
    {
        Random r = new Random();
        return r.Next(0, 7);
    }

    static string[,] Matrix(string[] s)
    {
        string[] str = new string[s.Length];
        int[] amounts = new int[s.Length];
        int num = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == "нет ответа")
            {
                continue;
            }
            bool flag = false;
            for (int j = 0; j < num; j++)
            {
                if (str[j] == s[i])
                {
                    amounts[j]++;
                    flag = true;
                    break;
                }
            }
            if (flag == true)
            {
                continue;
            }
            str[num] = s[i];
            amounts[num] = 1;
            num++;
        }
        for (int i = 0; i < num-1; i++)
        {
            int max = amounts[i];
            int maxind = i;
            for (int j = i + 1; j < num; j++)
            {
                if (amounts[j] > max)
                {
                    max = amounts[j];
                    maxind = j;
                }
            }
            amounts[maxind] = amounts[i];
            amounts[i] = max;
            string temp = str[maxind];
            str[maxind] = str[i];
            str[i] = temp;
        }
        string[,] matrix = new string[2, num];
        for (int i = 0; i < num; i++)
        {
            matrix[0, i] = str[i];
            matrix[1, i] = $"{amounts[i]}";
        }
        return matrix;
    }

    static string Answer(int n, int j, Answer[] answers)
    {
        if (n == 0)
        {
            return answers[j].Answer1;
        }
        else if (n == 1)
        {
            return answers[j].Answer2;
        }
        else if (n == 2)
        {
            return answers[j].Answer3;
        }
        else
        {
            return "";
        }
    }

    static string Question1(int n)
    {
        if (n == 0)
        {
            return "карп кои";
        }
        else if (n == 1)
        {
            return "журавли";
        }
        else if (n == 2)
        {
            return "лягушка";
        }
        else if (n == 3)
        {
            return "собака";
        }
        else if (n == 4)
        {
            return "рыба фугу";
        }
        else if (n == 5)
        {
            return "стрекоза";
        }
        else
        {
            return "нет ответа";
        }
    }
    static string Question2(int n)
    {
        if (n == 0)
        {
            return "сдержанность";
        }
        else if (n == 1)
        {
            return "трудолюбие";
        }
        else if (n == 2)
        {
            return "эстетизм";
        }
        else if (n == 3)
        {
            return "утонченность";
        }
        else if (n == 4)
        {
            return "вежливость";
        }
        else if (n == 5)
        {
            return "скромность";
        }
        else
        {
            return "нет ответа";
        }
    }
    static string Question3(int n)
    {
        if (n == 0)
        {
            return "сакура";
        }
        else if (n == 1)
        {
            return "суши";
        }
        else if (n == 2)
        {
            return "кимоно";
        }
        else if (n == 3)
        {
            return "гора Фудзи";
        }
        else if (n == 4)
        {
            return "солнце";
        }
        else if (n == 5)
        {
            return "катана";
        }
        else
        {
            return "нет ответа";
        }
    }
}