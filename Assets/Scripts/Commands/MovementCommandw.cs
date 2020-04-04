using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp:Command
{

    public override void Execute(GameObject p_object,float p_speed)
    {
        p_object.transform.position += new Vector3(0, p_speed,0) * Time.deltaTime;
    }

}

public class MoveDown: Command
{
    public override void Execute(GameObject p_object, float p_speed)
    {
        p_object.transform.position -= new Vector3(0, p_speed, 0) * Time.deltaTime;
    }
}

public class MoveLeft: Command
{
    public override void Execute(GameObject p_object, float p_speed)
    {
        p_object.transform.position -= new Vector3(p_speed, 0, 0) * Time.deltaTime;
    }

}

public class MoveRight:Command
{
    public override void Execute(GameObject p_object, float p_speed)
    {
        p_object.transform.position += new Vector3(p_speed, 0, 0) * Time.deltaTime;
    }

}