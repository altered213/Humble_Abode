using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Vector3[] Waypoints;
    public int currentDestination;
    public float Speed = 2;
    public float WaypointAcceptableError = 0.015f;
    // Start is called before the first frame update
    void Start()
    {
        currentDestination = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentDestination >= Waypoints.Length) return;
        transform.position = Vector3.MoveTowards(transform.position, Waypoints[currentDestination], Speed + Time.deltaTime);
        transform.LookAt(Waypoints[currentDestination]);

        if (Vector3.Distance(Transform.position, Waypoints[currentDestination].position) <= WaypointAcceptableError)
        {
            currentDestination++;
        }
    }
}
