using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : GameSystem
{

    [SerializeField]
    public int LevelID;
    [SerializeField]
    public string LevelName;
    

    [SerializeField]
    private List<LevelSystem> systems;

    [SerializeField]
    private ExitSystem m_exitsystem;

    // should the BGMs be stored here? 
    // A LevelSoundSystem should be created for the sounds that will store the level's BGM
    
    //Can escape
    //

    public override void onAwake()
    {
        if(m_exitsystem == null)
        {
            m_exitsystem = GameObject.Find("Exit").GetComponent<ExitSystem>();
        }

        foreach(LevelSystem s in systems)
        {
            s.Initialize(this);
            s.onAwake();
        }

        m_exitsystem.Initialize(this);
        m_exitsystem.onAwake();
    }

    public override void Refresh()
    {
        foreach(LevelSystem s in systems)
        {
            s.Refresh();
        }
    }

    public void ExitEnable(bool isEnabled)
    {
        if(!m_exitsystem.gameObject.activeInHierarchy)
        {
            m_exitsystem.gameObject.SetActive(isEnabled);
        }
        m_exitsystem.EnableExit(isEnabled);
        
    }

    public void ExitLevel()
    {
        m_manager.IncrementState();
    }

    public void LevelFailed()
    {
        //temporary
        ExitLevel();
    }
}
