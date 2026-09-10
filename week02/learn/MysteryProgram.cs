// using System;
// using System.Collections.Generic;
// // prediction: there are four to five total objects that you can see within the first function and the last funciton, this is going to show a random output for each object, and 
// // the last function is a type of calculation tool for how many 'points' in a sense each number contributes based on the random selection results
// class D
// {
//     static void Main()
//     {
//         int[] d = R(5);
//         Array.Sort(d);
//         Console.WriteLine("Values: " + string.Join(", ", d));
//         int s = C(d);
//         Console.WriteLine("Total: " + s);
//     }

//     static int[] R(int n)
//     {
//         Random r = new Random();
//         int[] d = new int[n];
//         for (int i = 0; i < n; i++)
//         {
//             d[i] = r.Next(1, 7);
//         }
//         return d;
//     }

//     static int C(int[] d)
//     {
//         int s = 0;
//         Dictionary<int, int> c = new Dictionary<int, int>();
//         foreach (int x in d)
//         {
//             if (c.ContainsKey(x))
//             {
//                 c[x]++;
//             }
//             else
//             {
//                 c[x] = 1;
//             }
//         }
//         foreach (int v in c.Values)
//         {
//             switch (v)
//             {
//                 case 2:
//                     s += 10;
//                     break;
//                 case 3:
//                     s += 20;
//                     break;
//                 case 4:
//                     s += 30;
//                     break;
//                 case 5:
//                     s += 40;
//                     break;
//             }
//         }
//         return s;
//     }
// }
// // solution
// // This program rolls a set of 5 standard six-sided dice. It then calculates displays a score based on number number of pairs, triples, and so forth.

// // If the list of values were 2, 2, 3, 3, 3, the program would display a score of 30.