using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelOne_State : GameState
{
    public LevelOne_State(GameManager p_manager) : base(p_manager)
    {

    }

    public override IEnumerator OnStart()
    {
       
      yield return m_manager.m_UImanager.FadeIn(0f);
        yield return m_manager.m_UImanager.SetText("Loading...",true);
        yield return new WaitForSeconds(3f);
      yield return m_manager._LoadScene(1);
        // yield return new WaitForSeconds(1);
        yield return m_manager.m_UImanager.FadeOut(0.5f);
        yield return m_manager.m_UImanager.SetText("Loading...", false);
        m_manager.GetLevelManager();
        
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
