using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RootState : GameState
{
    public RootState(GameManager p_manager):base(p_manager)
    {

    } 

    public override IEnumerator OnStart()
    {
       
        m_manager.InitializeRoot();

        yield return null;
        m_manager.IncrementState();

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
