using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Actor
{

    [SerializeField]
    public Transform sightDirection;
    [SerializeField]
    public Transform sightPosition;
    [SerializeField]
    public SightLine sight;

    void Update()
    {
        Vector3 aimDir = ((sightDirection.position - transform.position)).normalized;
        sight.SetAimDirection(aimDir);
        sight.SetOrigin(sightPosition.position);
    }
}
