using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    public GameObject Turret;
    public GameObject Target;
    float Range = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // NOT FINISHED- FINISH CODE____
    // Update is called once per frame
    void Update()
    {
        GameObject[] possibleTargets = GameObject.FindGameObjectsWithTag("Enemy");

        if (possibleTargets.Length == 0) return;

        Target = possibleTargets[0];

        foreach (GameObject o in possibleTargets) { 
            if (Vector3.Distance(transform.position, o.transform.position) <
 //more code needed ______
        Turret.transform.LookAt(Target.transform.position);
    }
}
