using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walking : ActorState
{

    public Walking(Actor p_Actor) : base(p_Actor)
    {
        TimePerState = 0;
    }
    public Walking(Actor p_Actor, ActorAction action) : base(p_Actor, action)
    {

    }

    public override IEnumerator Start()
    {
        LTBezierPath path = new LTBezierPath(new Vector3[] {
            m_action.path.startPoint,
            m_action.path.endControl,
            m_action.path.startControl,
            m_action.path.endPoint
        });


        LeanTween.move(actor.gameObject, path, m_action.time).setEase(LeanTweenType.easeInOutQuad);
        yield return new WaitForSeconds(m_action.time);
        actor.StartStateDone();
        yield break;
    }

    public override IEnumerator Exit()
    {

        yield break;
    }

}
