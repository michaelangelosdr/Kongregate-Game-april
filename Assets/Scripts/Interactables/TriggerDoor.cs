using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoor : Door
{
    [SerializeField]
    SpriteRenderer button_renderer;
    /*
    public override void Interact()
    {
        isOpened = !isOpened;
        OpenDoor();

        if (isOpened) { LeanTween.color(button_renderer.gameObject, Color.gray, 0.3f); return; }

        LeanTween.color(button_renderer.gameObject, Color.white, 0.3f); return;
    }
    */
}
