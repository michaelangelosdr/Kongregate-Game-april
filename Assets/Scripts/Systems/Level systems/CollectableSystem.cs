using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableSystem : LevelSystem
{


    /// <summary>
    /// [SerializeField]
    /// PlayerIndicators indicator
    /// </summary>

    [SerializeField]
    public List<CollectableObject> Collectables;

    [SerializeField]
    public bool CollectableSerialized;

    public override void onAwake()
    {
        if(!CollectableSerialized)
        {
            Collectables = new List<CollectableObject>();
            CollectableObject[] t = GetComponentsInChildren<CollectableObject>();
            for(int x=0; x<t.Length;x++)
            {
                Collectables.Add(t[x]);
            }
        }


      foreach(CollectableObject o in Collectables)
        {
            o.Initialize(this);
        }
      
    }

    
    public void Collected(CollectableTypes type)
    {

        if (type == CollectableTypes.EGGS)
        { Debug.Log("Egg has been collected"); }
        else if(type == CollectableTypes.ARTIFACT)
        {
            m_manager.ExitEnable(true);
            Debug.Log("Artifact retrieved");
        }


    }

}
