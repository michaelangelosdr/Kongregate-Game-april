using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
public class ExitSystem : LevelSystem, IInteractable
{

    public bool canEscape;


    public override void onAwake()
    {
        canEscape = false;

    }


    public void Interact()
    {
        if (!canEscape) return;

        m_manager.ExitLevel();

    }

    public IEnumerator _Interact()
    {
        yield break;

    }

    public void EnableExit(bool isEnabled)
    {
        Debug.Log("EXIT ENABLED:" + isEnabled);
        canEscape = isEnabled;
    }
}
