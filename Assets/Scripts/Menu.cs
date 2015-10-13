using UnityEngine;
using System;
using System.Collections;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{

    enum State { Init, Idle, Attack, Special }
    FSM<State> _fsm;

    //public EndTurn end;
    Player player;

	void Start()
    {
        player = GetComponent<Player>();
        //end = GetComponent<EndTurn>();
        _fsm = new FSM<State>();
        State[] states = (State[])Enum.GetValues(typeof(State));
        
        foreach(State s in states)
        {
            _fsm.addState(s);
        }

        _fsm.current_state = State.Init;
        _fsm.addTransition(State.Init, State.Idle, null);
        _fsm.addTransition(State.Idle, State.Attack, player.Attack);
        _fsm.addTransition(State.Attack, State.Idle, null);
        _fsm.addTransition(State.Idle, State.Special, player.Special);
        _fsm.addTransition(State.Special, State.Idle, null);

        auto_idle();
    }

    void print_current()
    {
        print(gameObject.name + _fsm.current_state.ToString());
    }
    public void auto_idle()
    {
        if(_fsm.current_state == State.Idle)
        {
            _fsm.current_state = State.Idle;
        }
        else
            _fsm.ChangeState(State.Idle);
        print_current();
    }

    public void idle_to_attack()
    {
        _fsm.ChangeState(State.Attack);
        print_current();
    }

    public void idle_to_special()
    {
        _fsm.ChangeState(State.Special);
        print_current();
    }

   
}
