using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp:Command
{

    public override void Execute(GameObject p_object,float p_speed)
    {
        p_object.transform.position += new Vector3(0, p_speed,0) * Time.deltaTime;
    }
    public override void Execute(Rigidbody2D p_rb, float p_speed)
    {
        p_rb.MovePosition(p_rb.transform.position + (new Vector3(0, 1, 0)* p_speed * Time.deltaTime));
    }

}

public class MoveDown: Command
{
    public override void Execute(GameObject p_object, float p_speed)
    {
        p_object.transform.position -= new Vector3(0, p_speed, 0) * Time.deltaTime;
    }
    public override void Execute(Rigidbody2D p_rb, float p_speed)
    {
        p_rb.MovePosition(p_rb.transform.position - (new Vector3(0, 1, 0) * p_speed * Time.deltaTime));
    }
}

public class MoveLeft: Command
{
    public override void Execute(GameObject p_object, float p_speed)
    {
        p_object.transform.position -= new Vector3(p_speed, 0, 0) * Time.deltaTime;
    }
    public override void Execute(Rigidbody2D p_rb, float p_speed)
    {
        p_rb.MovePosition(p_rb.transform.position - (new Vector3(1, 0, 0) * p_speed * Time.deltaTime));
    }
}

public class MoveRight:Command
{
    public override void Execute(GameObject p_object, float p_speed)
    {
        p_object.transform.position += new Vector3(p_speed, 0, 0) * Time.deltaTime;
    }
    public override void Execute(Rigidbody2D p_rb, float p_speed)
    {
        p_rb.MovePosition(p_rb.transform.position + (new Vector3(1, 0, 0) * p_speed * Time.deltaTime));
    }
}

public class MoveRightUp:Command
{
    public override void Execute(Rigidbody2D p_rb, float p_speed)
    {
        p_rb.MovePosition(p_rb.transform.position + (new Vector3(1, 1, 0) * p_speed * Time.deltaTime));
    }
}

public class MoveRightDown: Command
{
    public override void Execute(Rigidbody2D p_rb, float p_speed)
    {
        p_rb.MovePosition(p_rb.transform.position + (new Vector3(1, -1, 0) * p_speed * Time.deltaTime));
    }
}

public class MoveLeftUp:Command
{
    public override void Execute(Rigidbody2D p_rb, float p_speed)
    {
        p_rb.MovePosition(p_rb.transform.position + (new Vector3(-1, 1, 0) * p_speed * Time.deltaTime));
    }

}
public class MoveLeftDown:Command
{
    public override void Execute(Rigidbody2D p_rb, float p_speed)
    {
        p_rb.MovePosition(p_rb.transform.position - (new Vector3(1, 1, 0) * p_speed * Time.deltaTime));
    }
}