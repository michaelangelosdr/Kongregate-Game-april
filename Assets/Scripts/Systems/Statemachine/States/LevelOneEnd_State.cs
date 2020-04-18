using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelOneEnd_State : GameState
{
    public LevelOneEnd_State(GameManager p_manager) : base(p_manager)
    {

    }

    public override IEnumerator OnStart()
    {

        yield return m_manager.m_UImanager.FadeIn(0.25f);
        yield return m_manager.m_UImanager.SetText("Stage done!", true);
        yield return new WaitForSeconds(3);
        yield return m_manager.m_UImanager.SetText("Demo Done hehe lol", true);
        yield break;
    }

    public override IEnumerator Refresh()
    {
        yield break;
    }
    public override IEnumerator OnExit()
    {

        yield break;
    }
}
