using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : GameModule
{
    Command moveUp = null;
    Command moveDown = null;
    Command moveLeft = null;
    Command moveRight = null;
    Command moveRightUp = null;
    Command moveRightDown = null;
    Command moveLeftUp = null;
    Command moveLeftDown = null;


    [SerializeField]
    PlayerStats stats = null;

    [SerializeField]
    Rigidbody2D _Rb2d = null;

    public override void onAwake()
    {
        moveUp = new MoveUp();
        moveDown = new MoveDown();
        moveLeft = new MoveLeft();
        moveRight = new MoveRight();
        moveRightUp = new MoveRightUp();
        moveRightDown = new MoveRightDown();
        moveLeftUp = new MoveLeftUp();
        moveLeftDown = new MoveLeftDown();

        if (_Rb2d == null)
        {
            _Rb2d = GetComponent<Rigidbody2D>();
        }
    }

    public override void onStart()
    {
      
    }

    public override void Refresh()
    {
        if(Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.W)) { moveRightUp.Execute(_Rb2d, stats.Speed); }
        else if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.S)) { moveRightDown.Execute(_Rb2d, stats.Speed); }
        else if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W)) { moveLeftUp.Execute(_Rb2d, stats.Speed); }
        else if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.S)) { moveLeftDown.Execute(_Rb2d, stats.Speed); }
        else if (Input.GetKey(KeyCode.A)) { moveLeft.Execute(_Rb2d, stats.Speed);  }
        else if (Input.GetKey(KeyCode.D)) { moveRight.Execute(_Rb2d, stats.Speed); }
        else if (Input.GetKey(KeyCode.W)) { moveUp.Execute(_Rb2d, stats.Speed); }
        else if (Input.GetKey(KeyCode.S)) { moveDown.Execute(_Rb2d, stats.Speed); }
    }

}
