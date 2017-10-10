using System;
using System.Text;


namespace Lesson3
{
    class Program
    {
        static void FirstExample()
        {
            string[] daysOfWeek = { "Mon", "Tue", "Wed", "Thi", "Fri", "Sat", "Sun" };
            string firstOct;
            int firstOctNum = -1;
            while (firstOctNum == -1)
            {
                Console.Clear();
                Console.Write("Первое октября это:");
                firstOct = Console.ReadLine();
                /*for(int i = 0; i < daysOfWeek.Length; i++)
                {
                    if (String.Compare(firstOct,daysOfWeek[i]) == 0)
                        firstOctNum = i;
                }*/
                int i = 0;
                foreach (string name in daysOfWeek)
                {
                    if (String.Compare(firstOct, name) == 0)
                        firstOctNum = i;
                    i++;
                }
            }
            Console.WriteLine(firstOctNum);
            Console.Write("Сегодняшнее число:");
            int dayInMonth = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Сегодня {0}  октября - {1}", dayInMonth, daysOfWeek[(dayInMonth - 1 + firstOctNum) % 7]);
            Console.ReadLine();
        }
        static void Distance()
        {
            int[,] distance = new int[4, 4] {
                { 0, 2, 1, 4},
                { 2, 0,-1, 1},
                { 1,-1, 0, 3},
                { 4, 1, 3, 0}
            };
                        
            int[] route = { 2, 3, 2, 0, 3, 1 };
            int routeDistance = 0;
            for (int i = 1; i < route.Length; i++)
            {
                if (distance[route[i - 1], route[i]] == -1)
                {
                    routeDistance = -1;
                    break;
                }
                else
                {
                    routeDistance += distance[route[i - 1], route[i]];
                }

            }
            bool symectric = true;
            bool sameCityZero = true;
            for (int i = 0; i < distance.GetLength(0); i++)
            {
                if (distance[i, i] != 0)
                    sameCityZero = false;
                for (int j = i + 1; j < distance.GetLength(1); j++)
                {
                    if (distance[i, j] != distance[j, i])
                        symectric = false;
                }
            }
            Console.WriteLine("Distance:{0}", routeDistance);
            Console.ReadLine();
        }
        static void Part3()
        {
            int[] route = { 2, 3, 2, 0, 3, 1 };/*
            Array.Sort(route);
            foreach (int city in route)
                Console.WriteLine(city);
            Console.ReadLine();*/
            string st = @"string";
            string st2 = st;
            StringBuilder sb = new StringBuilder(10);
            //sb[2] = 'a';
            sb.Append("some");
            /*st2 = String.Join(",",route);
            st = String.Format("this is {0}", route);
            string[] cities = st2.Split(' ');
            Console.WriteLine(st2);*/
            Console.WriteLine(sb.Length);
            Console.WriteLine(sb.Capacity);

            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            int[][] array = new int[12][];
            array[0] = new int[] { 12, 12 };
            Console.Write("Введите выражение:");
            string expression = Console.ReadLine();
            string[] tokens = expression.Split(' ');
            int result = 0;
            int val = 0;
            char op = ' ';
            foreach(string token in tokens)
            {
                if (token.Length == 0)
                    continue;
                if (token == "+" || token == "-")
                    op = token[0];
                else
                {
                    if (Int32.TryParse(token,out val))
                    {
                        switch (op)
                        {
                            case ' ':
                                result = val;
                                break;
                            case '+':
                                result += val;
                                break;
                            case '-':
                                result -= val;
                                break;
                        }
                    }
                }
            }
            Console.WriteLine("Результат{0}",result);
            Console.ReadLine();
        }
    }
}
