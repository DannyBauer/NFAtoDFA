using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace NFAtoDFA
{
    class Program
    {
        static void Main(string[] args)
        {
            NFA nfa = new NFA();
            readFile(nfa);
            Console.ReadLine();
        }
        static void readFile(NFA nfa)
        {
            string fileName;
            string line;
            List<string> lineList;

            //Console.WriteLine("Enter your NFA files full location");
            //fileName = Console.ReadLine();
            fileName = "C:\\Users\\dbaue\\source\\repos\\NFA-to-DFA-Conversion\\NFA.txt";
            StreamReader file = new StreamReader(@fileName);

            nfa.numberOfStates = int.Parse(file.ReadLine());

            string alphabet = file.ReadLine();

            foreach (char ch in alphabet)
            {
                nfa.alphabet.Add(ch.ToString());
            }

            string finalStates = file.ReadLine();
            List<string> finalStatesString = finalStates.Split().ToList();
            for (int i = 0; i < finalStatesString.Count(); i++)
            {
                if (finalStatesString[i] != "")
                    nfa.finalStates.Add(finalStatesString[i]);
            }

            nfa.initialState = file.ReadLine();
            while ((line = file.ReadLine()) != null && line != "")
            {
                lineList = line.Split().ToList();
                NFAState nfaState = new NFAState();
                nfaState.newState(lineList[0], lineList[1], lineList[2]);
                nfa.states.Add(nfaState);
            }
        }
    }
}
