﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSystem : MonoBehaviour
{

    [SerializeField]
    GameObject FollowObject;
    [SerializeField]
    PlayerStats stats;
    [SerializeField]
    private float speedMultipier = 1.0f;

    public bool isSmoothFollow = false;

    public void Awake()
    {
        if(FollowObject == null)
        {

            FollowObject = GameObject.Find("PlayerCharacter");
        }

     
    }

    public void Update()
    {
        if (!isSmoothFollow)
        {
            Vector3 position = new Vector3(FollowObject.transform.position.x, FollowObject.transform.position.y, this.transform.position.z);
            this.transform.position = position;
        }
        else
        {
            float interpolation = (stats.Speed * speedMultipier) * Time.deltaTime;

            Vector3 position = this.transform.position;
            position.y = Mathf.Lerp(this.transform.position.y, FollowObject.transform.position.y, interpolation);
            position.x = Mathf.Lerp(this.transform.position.x, FollowObject.transform.position.x, interpolation);

            this.transform.position = position;
        }

    }
}
