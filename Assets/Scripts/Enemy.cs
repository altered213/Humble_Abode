using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
   public Transform[] Waypoints;
    public int CurrentDestination = 0;
    public float Speed = 2;
    public float WaypointAcceptableError = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (CurrentDestination >= Waypoints.Length)
            return;
        transform.position = Vector3.MoveTowards(transform.position, Waypoints[CurrentDestination].position, Speed * Time.deltaTime);
        transform.LookAt(Waypoints[CurrentDestination].position);
        if (Vector3.Distance(transform.position, Waypoints[CurrentDestination].position) <= WaypointAcceptableError)
            {
            CurrentDestination++;
            }
    }
}
