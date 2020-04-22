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

    private bool isOpening;

    public virtual void Interact()
    {
        if (isOpening) return;

        isOpened = !isOpened;
        OpenDoor();
    }

    public IEnumerator _Interact()
    {
        throw new System.NotImplementedException();
    }

    public virtual void OpenDoor()
    {
        isOpening = true;
       if(isOpened)
        {
            //LeanTween.rotateLocal(DoorPivot, new Vector3(0,0,90), DoorOpenTime).setEaseInSine().setOnComplete(()=> { isOpening = false; });
            LeanTween.moveLocal(_renderer.gameObject,new Vector2(0,1f),DoorOpenTime).setEaseInSine().setOnComplete(() => { isOpening = false; });
           
        }
       else
        {
            //LeanTween.rotateLocal(DoorPivot, new Vector3(0, 0, 0), DoorOpenTime).setEaseInSine().setOnComplete(() => { isOpening = false; });
            LeanTween.moveLocal(_renderer.gameObject, new Vector2(0, -0.5f), DoorOpenTime).setEaseInSine().setOnComplete(() => { isOpening = false; });
        }
    }
}
