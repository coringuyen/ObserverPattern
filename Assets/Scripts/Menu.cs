using UnityEngine;
using System;
using System.Collections;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Button Paused;
    public Button Exit;

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

        _fsm.current_state = State.Init;
        _fsm.addTransition(State.Init, State.Running, init_to_run);
        _fsm.addTransition(State.Running, State.Paused, run_to_pause);
        //_fsm.addTransition(State.Paused, State.Running,);
        //_fsm.addTransition(State.Paused, State.Exit,);

        auto();
    }

    void auto()
    {
        _fsm.ChangeState(State.Running);
    }

    public void onclick_run_to_paused()
    {
        _fsm.ChangeState(State.Paused);
    }
         
    void init_to_run()
    {
        Paused.gameObject.SetActive(true);
        Exit.gameObject.SetActive(true);
    }

    void run_to_pause()
    {
        print("Pausing");
    }
}
