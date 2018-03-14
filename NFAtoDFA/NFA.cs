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
        public string initialState;
        public List<string> alphabet = new List<string>();
        public List<string> finalStates = new List<string>();
        public List<NFAState> states = new List<NFAState>();

    }
}
