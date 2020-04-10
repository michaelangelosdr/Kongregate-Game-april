using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteModule : GameModule
{

    //this module should handle sprite movement of character such as animation

    [SerializeField]
    SpriteRenderer renderer;


    public override void Refresh()
    {

        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W)) { renderer.transform.rotation = Quaternion.Euler(0, 0, 135); }
        else if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.S)) { renderer.transform.rotation = Quaternion.Euler(0, 0, 225); }
        else if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.W)) { renderer.transform.rotation = Quaternion.Euler(0, 0, 45); }
        else if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.S)) { renderer.transform.rotation = Quaternion.Euler(0, 0, 315); }
        else if (Input.GetKey(KeyCode.A)) { renderer.transform.rotation = Quaternion.Euler(0, 0, 180); }
        else if (Input.GetKey(KeyCode.D)) { renderer.transform.rotation = Quaternion.Euler(0, 0, 0); }
        else if (Input.GetKey(KeyCode.W)) { renderer.transform.rotation = Quaternion.Euler(0, 0, 90); }
        else if (Input.GetKey(KeyCode.S)) { renderer.transform.rotation = Quaternion.Euler(0, 0, 270); }
    }    
}
