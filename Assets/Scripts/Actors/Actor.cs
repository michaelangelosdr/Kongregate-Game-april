using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


[RequireComponent(typeof(CircleCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class Actor : ActorStateMachine
{

    [SerializeField]
    public ActorAction[] m_Actions;

    private int currentStateIndex;

    private void Awake()
    {
        currentStateIndex = 0;
        ActivateState();
    }


    public void ActivateState()
    {

       if(currentStateIndex < m_Actions.Length)
        {
            if(m_Actions[currentStateIndex].behaviourtype == actorbehaviours.Idle)
            {
                ChangeState(new Idle(this, m_Actions[currentStateIndex]));
            }
            else if (m_Actions[currentStateIndex].behaviourtype == actorbehaviours.Walk)
            {
                ChangeState(new Walking(this, m_Actions[currentStateIndex]));
            }
        }      
    }

    public override void StartStateDone()
    {
        currentStateIndex++;
        if(currentStateIndex>=m_Actions.Length)
        {
            currentStateIndex = 0;
        }
        ActivateState();        
    }
}


[Serializable]
public struct ActorAction
{
    public actorbehaviours behaviourtype;
    //public Vector3[] TargetPos; 
    public ActorSplinePath path;
    public float time;
    //Animation
}

[Serializable]
public struct ActorSplinePath
{
    public Vector3 startPoint;
    public Vector3 endPoint;
    public Vector3 startControl;
    public Vector3 endControl;

}

