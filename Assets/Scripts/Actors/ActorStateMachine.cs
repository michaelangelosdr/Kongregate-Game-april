using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActorStateMachine : GameModule
{

    ActorState currentstate;

    bool isChangingStates = false;

    [SerializeField]
    protected bool isLooping;


    public void ChangeState(ActorState p_state)
    {
        isChangingStates = true;
        if (currentstate != null)
        {
            StartCoroutine(currentstate.Exit());
        }
        currentstate = p_state;
        StartCoroutine( currentstate.Start());
       
        isChangingStates = false;
    }

    public virtual void StartStateDone()
    {

    }

   

    public override void Refresh()
    {
        if(!isChangingStates)
        {
          
            currentstate.Refresh();
        }
    }
}
