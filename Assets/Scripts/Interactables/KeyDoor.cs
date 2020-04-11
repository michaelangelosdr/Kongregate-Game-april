using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDoor : Door
{
    [SerializeField]
    DoorKey key;

    public bool keyCollected;

    

    private void Awake()
    {
        keyCollected = false;
        key.Initialize(this);
    }

    public override void Interact()
    {
        if(keyCollected)
        {
            isOpened = !isOpened;
            OpenDoor();
        }
        else
        {
            AnimateLockDoor();
        }
    }

    public void AnimateLockDoor()
    {
        StopAllCoroutines();
        DoorPivot.transform.rotation = Quaternion.Euler(0, 0, 0);
        StartCoroutine(LockDoorAnimation());
    }

    private IEnumerator LockDoorAnimation()
    {
        LeanTween.color(_renderer.gameObject, Color.gray, 0.2f);
         LeanTween.rotate(DoorPivot, new Vector3(0, 0, 2), 0.2f);
        yield return new WaitForSeconds(0.2f);
        LeanTween.rotate(DoorPivot, new Vector3(0, 0, 0), 0.2f);
        LeanTween.color(_renderer.gameObject, Color.white, 0.2f);
    }

}
