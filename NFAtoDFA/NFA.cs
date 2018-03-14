using System;
using System.Collections.Generic;
using System.Text;

namespace NFAtoDFA
{
    public class NFAState
    {
        public string state, transition, transitionState;
        public void newState(string State, string Transition, string TransitionState)
        {
            state = State;
            transition = Transition;
            transitionState = TransitionState;
        }
    }
    public class NFA
    {
        public int numberOfStates;
        public int initialState;
        public List<string> alphabet = new List<string>();
        public List<int> finalStates = new List<int>();
        public List<NFAState> states = new List<NFAState>();

    }
    public class DFAState
    {
        bool visited
        public List<string> states = new List<string>();
        public int stateNumber;
    }

    public class DFA
    {
     
    }
}
