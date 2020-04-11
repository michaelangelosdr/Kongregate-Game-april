using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameModule : MonoBehaviour
{
    public abstract void onAwake();
    public abstract void onStart();
    public abstract void Refresh();
}
