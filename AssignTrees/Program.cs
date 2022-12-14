using System.Collections;
using System.Collections.Generic;
using static System.Console;
using System.IO;

namespace AssignTrees
{

    class Program
    {
        static void Main(string[] arg)
        {
            string textFilePath = "score.txt";
            string[] stringScores = File.ReadAllLines(textFilePath);
            int[] scores = Array.ConvertAll(stringScores, int.Parse);
            int[] sortedScores = BubbleSort(scores, 0, scores.Length - 1);

            DictionaryNodeRoot tree = new DictionaryNodeRoot();

            foreach (int score in sortedScores)
            {
                tree.AddNumber(score.ToString());
            }

            WriteLine(tree.ContainsNumber("64"));
            WriteLine(tree.ContainsNumber("48"));

        }


        static int[] BubbleSort(int[] array, int v, int v1)
        {
            bool notSorted = true;
            while (notSorted)
            {
                notSorted = false;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        var temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;

                        notSorted = true;
                    }
                }
            }

            return array;
        }


        class DictionaryNodeRoot
        {

        }


    }
}