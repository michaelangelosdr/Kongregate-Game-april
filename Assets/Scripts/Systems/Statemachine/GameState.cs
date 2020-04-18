using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameState
{
    protected GameManager m_manager;

    public GameState(GameManager p_manager)
    {
        m_manager = p_manager;
    }


    public virtual IEnumerator OnStart()
    {

        yield break;
    }

    public virtual IEnumerator Refresh()
    {

        yield break;
    }

    public virtual IEnumerator OnExit()
    {
        yield break;
    }
    
}


public enum GameStates
{
    RootState =0,
    Level_One_Start=1,
    Level_One_End=2

}
