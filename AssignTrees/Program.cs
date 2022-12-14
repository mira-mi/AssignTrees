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
            DictionaryNode root = new DictionaryNode();

            public void AddNumber(string value)
            {
                DictionaryNode current = this.root;
                for (int i = 0; i < value.Length; i++)
                {
                    current = current.Add(value[i]);
                }
                // We can set the current number
                current.SetNumber(value);
            }

            public string ContainsNumber(string value)
            {
                bool isNumberPresent;
                // This method allows us to enter a string and then see if the characters are contained in the tree in order
                DictionaryNode current = this.root;
                for (int i = 0; i < value.Length; i++)
                {
                    current = current.Get(value[i]);
                    if (current == null)
                    {
                        isNumberPresent = false;
                        return MakeConclusion(isNumberPresent, value);
                    }
                }
                isNumberPresent = current != null && current.GetNumber() != null;
                return MakeConclusion(isNumberPresent, value);
            }

            // This method formulates the final sentence
            public string MakeConclusion(bool value, string number)
            {
                string trueOrFalse;
                if (value)
                {
                    trueOrFalse = "";
                }
                else
                {
                    trueOrFalse = "not";
                }
                string conclusion = "The number " + number + " is " + trueOrFalse + "found in the tree.";
                return conclusion;
            }
        }

    }

    class DictionaryNode
    {
        string number;
        Dictionary<char, DictionaryNode> node;

        // adds character to dictionary
        public DictionaryNode Add(char value)
        {
            if (this.node == null)
            {
                this.node = new Dictionary<char, DictionaryNode>();
            }

            DictionaryNode result;
            if (this.node.TryGetValue(value, out result))
            {
                return result;
            }

            result = new DictionaryNode();
            this.node[value] = result;
            return result;
        }

        public DictionaryNode Get(char value)
        {
            // This way we can get the individual child node
            if (this.node == null)
            {
                return null;
            }
            DictionaryNode result;
            if (this.node.TryGetValue(value, out result))
            {
                return result;
            }
            return null;
        }

        public void SetNumber(string num)
        {
            this.number = num;
        }

        public string GetNumber()
        {
            return this.number;
        }


    }
}
