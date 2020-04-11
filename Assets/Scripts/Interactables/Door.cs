using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, IInteractable
{

    [SerializeField]
    protected SpriteRenderer _renderer;

    [SerializeField]
    protected GameObject DoorPivot;

    [SerializeField]
    private float DoorOpenTime;

    [SerializeField]
    protected bool isOpened;

    public virtual void Interact()
    {
        isOpened = !isOpened;
        OpenDoor();
    }

    public IEnumerator _Interact()
    {
        throw new System.NotImplementedException();
    }

    public virtual void OpenDoor()
    {
       if(isOpened)
        {
            LeanTween.rotateLocal(DoorPivot, new Vector3(0,0,90), DoorOpenTime).setEaseInSine();
        }
       else
        {
            LeanTween.rotateLocal(DoorPivot, new Vector3(0, 0, 0), DoorOpenTime).setEaseInSine();
        }
    }
}
