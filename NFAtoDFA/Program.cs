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
            DFA dfa = new DFA();
            constructDFA(nfa, dfa);
            Console.ReadLine();
        }
        static void readFile(NFA nfa)
        {
            string fileName;
            string line;
            List<string> lineList;

            //Console.WriteLine("Enter your NFA files full location");
            //fileName = Console.ReadLine();
            fileName = "E:\\Project Files\\NFAtoDFA\\NFAtoDFA\\NFA.txt";
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
                    nfa.finalStates.Add(int.Parse(finalStatesString[i]));
            }

            nfa.initialState = int.Parse(file.ReadLine());
            while ((line = file.ReadLine()) != null && line != "")
            {
                lineList = line.Split().ToList();
                NFAState nfaState = new NFAState();
                nfaState.newState(lineList[0], lineList[1], lineList[2]);
                nfa.states.Add(nfaState);
            }
        }
        static void constructDFA(NFA nfa, DFA dfa)
        {
            int currentDFAState = 0;
            List<int> initialDFAState = new List<int>();
            initialDFAState.Add(nfa.initialState);

        }
        //static void constructDFA(NFA nfa, DFA dfa)
        //{
        //    int dfaStateCount = 0;

        //    dfa.initialState = nfa.initialState;
        //    dfa.alphabet = nfa.alphabet;
        //    DFAState dfaState = new DFAState();
        //    dfaState.state.Add(dfa.initialState);
        //    dfaState.stateNumber = dfaStateCount;
        //    dfa.states.Add(dfaState);
        //    List<string> transitionState = new List<string>();
        //    for (int i = 0; i < nfa.states.Count(); i++)
        //    {
        //        for (int j = 0; j < nfa.alphabet.Count(); j++)
        //        {

        //            if (nfa.states[i].transition == nfa.alphabet[j])
        //            {
        //                transitionState.Add(nfa.states[i].transitionState);
        //            }

        //        }
        //        for (int j = 0; j < dfa.states.Count(); j++)
        //        {
        //            if (!transitionState.All(s => dfa.states[j].state.Contains(s)))
        //            {
        //                DFAState newdfaState = new DFAState();
        //                dfaStateCount++;
        //                newdfaState.stateNumber = dfaStateCount;
        //                for (int k = 0; k < transitionState.Count(); k++)
        //                {
        //                    newdfaState.state.Add(transitionState[k]);
        //                }
        //                dfa.states.Add(newdfaState);
        //            }
        //        }
        //    }
        //}
    }
}
