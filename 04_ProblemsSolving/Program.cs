namespace _04_ProblemsSolving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Problems Solving CodeForce
            #region Problem 1
            /*
             * Mahmoud has n line segments, the i-th of them has length ai. Ehab challenged him to use exactly 3 line segments to form a non-degenerate triangle. Mahmoud doesn't accept challenges unless he is sure he can win, so he asked you to tell him if he should accept the challenge. Given the lengths of the line segments, check if he can choose exactly 3 of them to form a non-degenerate triangle.
             * 
             *  Mahmoud should use exactly 3 line segments, he can't concatenate two line segments or change any length. A non-degenerate triangle is a triangle with positive area.
             */

            //int sz = int.Parse(Console.ReadLine());
            // double[] arr = new double[sz];
            // arr= Array.ConvertAll(Console.ReadLine().Split(' '), double.Parse);// read array from single line
            // Array.Sort(arr); // sort the array in ascending order [Built-in Method]
            // bool flag = false;
            // for (int i = 0; i < sz-2; i++) // 1 2 3 4 5  
            // {
            //     if (arr[i] + arr[i+1] > arr[i + 2])
            //     {
            //         flag = true; 
            //         break;
            //     }
            // }
            // Console.WriteLine(flag ? "YES" : "NO");




            #endregion
            #region Problem 2
            /*
             * Trippi Troppi resides in a strange world. The ancient name of each country consists of three strings. The first letter of each string is concatenated to form the country's modern name.

            Given the country's ancient name, please output the modern name.

            Input
                The first line contains an integer t
         – the number of independent test cases (1≤t≤100).

                  The following t
                lines each contain three space-separated strings. Each string has a length of no more than 10
                , and contains only lowercase Latin characters.
             */

            //=======================================
            //int sz = int.Parse(Console.ReadLine());
            //string[] ancientName = new string[sz];
            //for (int i = 0; i < sz; i++)
            //{
            //    string strCountry = "";
            //    string[] arr = Console.ReadLine().Split(' ');
            //    char fristChar = arr[0][0];
            //    char secondChar = arr[1][0];
            //    char thirdChar = arr[2][0];
            //    strCountry = strCountry + fristChar + secondChar + thirdChar;

            //    ancientName[i] =strCountry ;
            //}
            //for (int i = 0; i < sz; i++)
            //{
            //    Console.WriteLine(ancientName[i]);
            //}

            #endregion
            #region Problem 3
            /*
             * Skibidus lands on a foreign planet, where the local Amog tribe speaks the Amog'u language. In Amog'u, there are two forms of nouns, which are singular and plural.

                Given that the root of the noun is transcribed as S
                , the two forms are transcribed as:

                Singular: S
                 +
                 "us"
                Plural: S
                 +
                 "i"
                Here, +
                 denotes string concatenation. For example, abc +
                def =
                    abcdef.

                For example, when S
                is transcribed as "amog", then the singular form is transcribed as "amogus", and the plural form is transcribed as "amogi". Do note that Amog'u nouns can have an empty root — in specific, "us" is the singular form of "i" (which, on an unrelated note, means "imposter" and "imposters" respectively).

                Given a transcribed Amog'u noun in singular form, please convert it to the transcription of the corresponding plural noun.
             */


            //==========================================================


            //int sz = int.Parse(Console.ReadLine());
            //string[] singularNames = new string[sz];
            //for (int i = 0; i < sz; i++)
            //{
            //    string singularName = Console.ReadLine();

            //    string root = singularName.Substring(0, singularName.Length - 2);
            //    string pluralName = root + "i";
            //    singularNames[i] = pluralName;
            //}
            //for (int i = 0; i < sz; i++)
            //{
            //    Console.WriteLine(singularNames[i]);
            //}

            #endregion
            #region Problem 4
            /*
             * You are given three integers a
                , b
                , and c
                 such that exactly one of these two equations is true:

                a+b=c
                a−b=c
                Output + if the first equation is true, and - otherwise.
                Input
                The first line contains a single integer t
                 (1≤t≤162
                ) — the number of test cases.

                The description of each test case consists of three integers a
                , b
                , c
                 (1≤a,b≤9
                , −8≤c≤18
                ). The additional constraint on the input: it will be generated so that exactly one of the two equations will be true.

                        Output
                        For each test case, output either + or - on a new line, representing the correct equation.
             */

            //==========================================================
            //int tests = int.Parse(Console.ReadLine());
            //int[] arr = new int[3];
            //while(tests-- > 0)
            //{
            //    arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            //    if (arr[0] + arr[1] == arr[2])
            //    {
            //        Console.WriteLine("+");
            //    }
            //    else
            //    {
            //        Console.WriteLine("-");
            //    }

            //}

            #endregion
            #region Problem 5
            /*
             * You are given three integers a
                , b
                , and c
                . Determine if one of them is the sum of the other two.

                Input
                The first line contains a single integer t
                 (1≤t≤9261
                ) — the number of test cases.

                The description of each test case consists of three integers a
                , b
                , c
                 (0≤a,b,c≤20
                ).

                Output
                For each test case, output "YES" if one of the numbers is the sum of the other two, and "NO" otherwise.

                You can output the answer in any case (for example, the strings "yEs", "yes", "Yes" and "YES" will be recognized as a positive answer).
             */
            //=====================
            //int t= int.Parse(Console.ReadLine());
            //int[] arr = new int[3];
            //while (t-- != 0)
            //{
            //    arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            //    Array.Sort(arr);
            //    if (arr[0] + arr[1] == arr[2])
            //    {
            //        Console.WriteLine("YES");
            //    }
            //    else
            //    {
            //        Console.WriteLine("NO");
            //    }
            //}

            #endregion
            #region Problem 6
            /*
                             * In an ICPC contest, balloons are distributed as follows:

                Whenever a team solves a problem, that team gets a balloon.
                The first team to solve a problem gets an additional balloon.
                A contest has 26 problems, labelled A
                , B
                , C
                , ..., Z
                . You are given the order of solved problems in the contest, denoted as a string s
                , where the i
                -th character indicates that the problem si
                 has been solved by some team. No team will solve the same problem twice.
                Determine the total number of balloons that the teams received. Note that some problems may be solved by none of the teams.

                Input
                The first line of the input contains an integer t
                 (1≤t≤100
                ) — the number of testcases.

                The first line of each test case contains an integer n
                 (1≤n≤50
                ) — the length of the string.

                The second line of each test case contains a string s
                 of length n
                 consisting of uppercase English letters, denoting the order of solved problems.

                Output
                For each test case, output a single integer — the total number of balloons that the teams received.
           *** Note
                In the first test case, 5
                 balloons are given out:

                Problem A
                 is solved. That team receives 2
                 balloons: one because they solved the problem, an an additional one because they are the first team to solve problem A
                .
                Problem B
                 is solved. That team receives 2
                 balloons: one because they solved the problem, an an additional one because they are the first team to solve problem B
                .
                Problem A
                 is solved. That team receives only 1
                 balloon, because they solved the problem. Note that they don't get an additional balloon because they are not the first team to solve problem A
                .
                The total number of balloons given out is 2+2+1=5
                .
                In the second test case, there is only one problem solved. The team who solved it receives 2
                 balloons: one because they solved the problem, an an additional one because they are the first team to solve problem A
.
             */
            //=========================================

            //int t = int.Parse(Console.ReadLine());
            //while (t-- != 0)
            //{
            //    int sz = int.Parse(Console.ReadLine());
            //    string s = Console.ReadLine();
            //    char[] ch = s.ToCharArray();
            //    Array.Sort(ch);
            //    int count = 2;
            //    char c = ch[0];
            //    for (int i = 1; i < sz; i++)
            //    {
            //        if (ch[i] == c)
            //        {
            //            count++;
            //        }
            //        else
            //        {
            //            count += 2;
            //            c = ch[i];
            //        }
            //    }
            //    Console.WriteLine(count);



            //}
            #endregion
            #endregion
        }
    }
}
