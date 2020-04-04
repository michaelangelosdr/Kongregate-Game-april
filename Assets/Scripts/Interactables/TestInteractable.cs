using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestInteractable : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        Debug.Log("HELLO YOU HAVE INTERACTED WITH ME");
    }

    public IEnumerator _Interact()
    {
        throw new System.NotImplementedException();
    }
}
