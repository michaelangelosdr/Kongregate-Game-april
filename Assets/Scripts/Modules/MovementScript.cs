using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : GameModule
{
    Command moveUp = null;
    Command moveDown = null;
    Command moveLeft = null;
    Command moveRight = null;
    
    [SerializeField]
    PlayerStats stats;

  
    public void Awake()
    {
        moveUp = new MoveUp();
        moveDown = new MoveDown();
        moveLeft = new MoveLeft();
        moveRight = new MoveRight();
    }

    public override void Refresh()
    {
        if (Input.GetKey(KeyCode.A)) { moveLeft.Execute(this.gameObject, stats.Speed); }
        else if (Input.GetKey(KeyCode.D)) { moveRight.Execute(this.gameObject, stats.Speed); }
        if (Input.GetKey(KeyCode.W)) { moveUp.Execute(this.gameObject, stats.Speed); }
        else if (Input.GetKey(KeyCode.S)) { moveDown.Execute(this.gameObject, stats.Speed); }
    }

}
