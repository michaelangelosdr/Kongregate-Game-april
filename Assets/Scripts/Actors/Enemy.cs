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

    private void Update()
    {
        Vector3 aimDir = ((sightDirection.position - transform.position)).normalized;
        sight.SetAimDirection(aimDir);
        sight.SetOrigin(sightPosition.position);
        Refresh();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ProxiDoor"))
        {
            collision.GetComponent<ProximityDoor>().inProximity(true);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("ProxiDoor"))
        {
            collision.GetComponent<ProximityDoor>().inProximity(false);
        }
    }
}
