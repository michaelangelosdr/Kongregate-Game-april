using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
   

    [SerializeField]
    List<GameModule> Modules;


    public void Update()
    {       
        foreach(GameModule module in Modules)
        {
            module.Refresh();
        }       
    }

}
