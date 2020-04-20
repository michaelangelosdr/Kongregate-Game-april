using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSystem : MonoBehaviour
{

    protected GameManager m_manager; 


    public virtual void Initialize(GameManager p_manager)
    {
        m_manager = p_manager;
    }
    
   public virtual void onAwake()
    {
       
        Debug.Log("NO IMPLEMENTATION");
    }

    public virtual void onStart()
    {
        Debug.Log("NO IMPLEMENTATION");
    }
    public virtual void Refresh()
    {

    }
}
