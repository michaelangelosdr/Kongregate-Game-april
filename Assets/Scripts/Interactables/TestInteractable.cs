using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestInteractable : MonoBehaviour, IInteractable
{

    [SerializeField]
    SpriteRenderer renderer;

    private bool isInteractedWith = false;


    public void Interact()
    {
        isInteractedWith = !isInteractedWith;
        Debug.Log("HELLO YOU HAVE INTERACTED WITH ME");
        
        if(isInteractedWith)
        {
            renderer.color = Color.blue;
        }
        else

        {
            renderer.color = Color.white;
        }
    }

    public IEnumerator _Interact()
    {
        throw new System.NotImplementedException();
    }
}
