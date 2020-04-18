using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class LevelSystem : MonoBehaviour
{

    protected LevelManager m_manager;

    public virtual void Initialize(LevelManager p_manager)
    {
        m_manager = p_manager;
    }

    public virtual void onAwake()
    {

    }
}
