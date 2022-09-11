using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SeekerMovement : MonoBehaviour
{

    public NavMeshAgent seeker;
    public LayerMask whatIsGround;
    public Vector3 walkPoint;
    bool walkPointSet;
    public float walkPointRange;
    public float moveSpeed;
    public Transform[] points = new Transform[6];
    // Start is called before the first frame update
    void Start()
    {
        seeker = GetComponent<NavMeshAgent>();
    }


    // Update is called once per frame
    void Update()
    {

        if (!walkPointSet)
        {
            walkPoint = points[(int)Random.Range(0f, points.Length)].position;
            walkPointSet = true;
        }

        else seeker.SetDestination(walkPoint);
        Vector3 distanceToWalkPoint = transform.position - walkPoint;
        if (distanceToWalkPoint.magnitude < 1f)
            walkPointSet = false;
    }
}
