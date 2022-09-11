using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetection : MonoBehaviour
{
    public float seekerVision;
    private Transform playerPosition;
    private Vector3 distanceFromPlayer;
    // Start is called before the first frame update
    void Start()
    {
        playerPosition = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        distanceFromPlayer = transform.position - playerPosition.position;
        if (distanceFromPlayer.magnitude < seekerVision)
        {
            print("dead");
        }
    }

}
