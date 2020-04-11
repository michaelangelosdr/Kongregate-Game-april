using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Command : MonoBehaviour
{    

    public virtual void Execute()
    {
        
    }
    public virtual void Execute(GameObject p_object)
    {
        Debug.Log("Executed");
    }
    public virtual void Execute(GameObject p_object,float p_speed)
    {
        Debug.Log("Executed");
    }
    public virtual void Execute(Rigidbody2D p_Rb, float p_speed)
    {
        Debug.Log("Executed");
    }

    public virtual void Execute(IInteractable interactable) { }


    public virtual void ExecuteDone()
    {

    }
}
