using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idle : ActorState
{
    
    public Idle(Actor p_Actor) : base(p_Actor)
    {
        TimePerState = 0;
    }
    public Idle(Actor p_Actor, ActorAction action) : base(p_Actor, action)
    {

    }

    public override IEnumerator Start()
    {

        yield break;
    }

    public override IEnumerator Exit()
    {

        yield break;
    }

}
