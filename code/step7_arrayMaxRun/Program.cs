int[] grades = { 5, 4, 5, 3, 4 };
int max = grades[0];
for (int i = 1; i < grades.Length; i++)
    {
        if (grades[i] > max)
        {
            max = grades[i];
        }
    }
Console.WriteLine("Максимальная оценка: " + max);