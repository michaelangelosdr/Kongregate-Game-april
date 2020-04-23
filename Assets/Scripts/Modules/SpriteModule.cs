using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteModule : GameModule
{

    //this module should handle sprite movement of character such as animation

    [SerializeField]
    SpriteRenderer _renderer = null;

    public override void onAwake()
    {
       
    }

    public override void onStart()
    {
       
    }

    public override void Refresh()
    {

        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W)) { _renderer.transform.rotation = Quaternion.Euler(0, 0, 225); }
        else if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.S)) { _renderer.transform.rotation = Quaternion.Euler(0, 0, 315); }//225
        else if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.W)) { _renderer.transform.rotation = Quaternion.Euler(0, 0, 135); }
        else if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.S)) { _renderer.transform.rotation = Quaternion.Euler(0, 0, 45); }//315
        else if (Input.GetKey(KeyCode.A)) { _renderer.transform.rotation = Quaternion.Euler(0, 0, 270); }
        else if (Input.GetKey(KeyCode.D)) { _renderer.transform.rotation = Quaternion.Euler(0, 0, 90); }
        else if (Input.GetKey(KeyCode.W)) { _renderer.transform.rotation = Quaternion.Euler(0, 0, 180); }
        else if (Input.GetKey(KeyCode.S)) { _renderer.transform.rotation = Quaternion.Euler(0, 0, 0); }
    }    
}
