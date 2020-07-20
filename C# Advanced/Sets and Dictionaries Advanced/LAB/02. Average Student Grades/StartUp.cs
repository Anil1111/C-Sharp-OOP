﻿namespace _02._Average_Student_Grades
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            var marks = new Dictionary<string, List<double>>();

            int totalMarks = int.Parse(Console.ReadLine());

            for (int i = 0; i < totalMarks; i++)
            {
                var markParts = Console.ReadLine().Split();
                var name = markParts[0];
                var mark = double.Parse(markParts[1]);

                if (!marks.ContainsKey(name))
                {
                    marks[name] = new List<double>();
                }

                marks[name].Add(mark);
            }

            foreach (var kvp in marks)
            {
                var name = kvp.Key;
                var currentMarks = kvp.Value;
                var averageMark = currentMarks.Average();

                Console.Write($"{name} -> ");
                foreach (var mark in currentMarks)
                {
                    Console.Write($"{mark:f2} ");

                }

                Console.WriteLine($"(avg: {averageMark:f2})");

                //Console.WriteLine($"{name} -> {string.Join(" ", currentMarks):f2} (avg: {averageMark:F2})");
            }
        }
    }
}