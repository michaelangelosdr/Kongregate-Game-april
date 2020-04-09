using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ActorState
{
    protected Actor actor;
    protected float TimePerState;
    protected ActorAction m_action;

    public ActorState(Actor actor)
    {
        this.actor = actor;
    }
    public ActorState(Actor actor,ActorAction m_action)
    {
        this.actor = actor;
        this.m_action = m_action;
    }
    public ActorState(Actor actor,float Time)
    {
        this.actor = actor;
        this.TimePerState = Time;
    }

    public virtual IEnumerator Start() {

        //actor.StartStateDone();
        yield break;
    }

    public virtual void Refresh()
    {
       
    }

    public virtual IEnumerator Exit()
    {
        yield break;
    }

}
