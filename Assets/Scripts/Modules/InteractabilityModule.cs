using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class InteractabilityModule : GameModule
{
    Command Interactability;

    private GameObject NearestObject;

    private void Awake()
    {
        Interactability = new InteractCommand();
    }

    public override void Refresh()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            var m_Object = GetNearestGameObject();
            if (m_Object == null) return;

            Interactability.Execute(m_Object.GetComponent<IInteractable>());

        }
    }


    private GameObject GetNearestGameObject()
    {
        return NearestObject;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        NearestObject = collision.gameObject;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        NearestObject = collision.gameObject;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        NearestObject = null;
    } 

}
