using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractCommand : Command
{
    public override void Execute(IInteractable interactable)
    {
        interactable.Interact();
    }

    
}
