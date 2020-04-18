using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Statemachine : MonoBehaviour
{
    [SerializeField]
    protected List<GameState> states = new List<GameState>();
    protected GameState currentState;
    private GameStates currentStateType;

    public void SetState(GameStates state)
    {
        if(currentState !=null)
        {
            StartCoroutine(
            currentState.OnExit());
        }
        currentStateType = state;
        currentState = states[(int)state];
        StartCoroutine(currentState.OnStart());

        Debug.Log(currentState);
    }

    public void IncrementState()
    {

        if (currentState == null) return;

        if (currentState == states[states.Count-1])
        {
            Debug.Log("End Of state");
            return;
        }
    

        int nextStateIndex = (int)currentStateType + 1;
        SetState((GameStates)nextStateIndex);
      
    }

}
