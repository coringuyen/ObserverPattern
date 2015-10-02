using UnityEngine;
using System;
using System.Collections;

public class Menu : MonoBehaviour
{

    enum State { Init, Running, Paused, Exit }
    FSM<State> _fsm;

	void Start()
    {
        _fsm = new FSM<State>();
        State[] states = (State[])Enum.GetValues(typeof(State));
        
        foreach(State s in states)
        {
            _fsm.addState(s);
        }

        //_fsm.addTransition(State.Init, State.Running,);
        //_fsm.addTransition(State.Running, State.Paused,);
        //_fsm.addTransition(State.Paused, State.Running,);
        //_fsm.addTransition(State.Paused, State.Exit,);

    }
}
