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
        public bool visited;
        public List<int> states = new List<int>();
        public int stateNumber;
    }

    public class DFA
    {
        public List<DFAState> states = new List<DFAState>();
        public int allVisited(List<DFAState> States)
        {
            foreach(DFAState state in States)
            {
                if (state.visited == true)
                    return state.stateNumber;
            }
            return -1;
        }
    }
}
