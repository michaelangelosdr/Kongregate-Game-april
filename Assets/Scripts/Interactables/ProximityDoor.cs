using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProximityDoor : Door
{
    [SerializeField]
    private SpriteRenderer leftDoor;

    [SerializeField]
    private SpriteRenderer rightDoor;

    public override void Interact()
    {
        
    }

    public void inProximity(bool isWithin)
    {
        isOpened = isWithin;
        OpenDoor();
    }

    public override void OpenDoor()
    {
        if(isOpened)
        {
            LeanTween.moveLocalY(leftDoor.gameObject, 0.9f, 0.5f);
            LeanTween.moveLocalY(rightDoor.gameObject, -0.9f, 0.5f);
        }
        else
        {

            LeanTween.moveLocalY(leftDoor.gameObject, 0.4f, 0.5f);
            LeanTween.moveLocalY(rightDoor.gameObject, -0.4f, 0.5f);
        }
    }

}
