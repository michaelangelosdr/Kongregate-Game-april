using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
   
    [SerializeField]
    List<GameModule> Modules;

    private void Awake()
    {
        foreach(GameModule module in Modules)
        {
            module.onAwake();
        }
    }

    public void Update()
    {       
        foreach(GameModule module in Modules)
        {
            module.Refresh();
        }       
    }

}
