﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName ="Stats",menuName ="Player/Stats")]
public class PlayerStats : ScriptableObject
{
    [SerializeField]
    public float Speed;

    [SerializeField]
    public int GasValue;

    [SerializeField]
    public int Max_GasValue;

}
