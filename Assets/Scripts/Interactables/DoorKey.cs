using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorKey : MonoBehaviour, IInteractable
{

    [SerializeField]
    KeyDoor door;

    public void Initialize(KeyDoor door)
    {
        this.door = door;
    }

    public void Interact()
    {
        door.keyCollected = true;
        AnimateKeyCollection();
    }

    public IEnumerator _Interact()
    {
        throw new System.NotImplementedException();
    }

    public void AnimateKeyCollection()
    {
        LeanTween.scale(gameObject, new Vector3(0, 0, 0), 0.25f).setEaseInBack().setOnComplete(()=> { gameObject.SetActive(false); });
    }
}
