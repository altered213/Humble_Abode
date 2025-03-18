using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour

   
{
    private Transform _Enemy;
    public GameObject BulletPrefab;
    public Transform FirePoint;
    public GameObject Turret;
    public GameObject Enemy;
    public float fireRate = 1f;
    private float fireCountdown = 0f;
    public float Range = 5.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] possibleTargets = GameObject.FindGameObjectsWithTag("Enemy");
        if (possibleTargets.Length == 0) return;

        Enemy = possibleTargets[0];
        foreach (GameObject o in possibleTargets)
        {
            if (Vector3.Distance(transform.position, o.transform.position) <
                Vector3.Distance(transform.position, Enemy.transform.position))
            {
                Enemy = o; 
            }
        }
     
        Turret.transform.LookAt(Enemy.transform.position);
        Turret.transform.eulerAngles += new Vector3(0, -90, 0);
        if (Vector3.Distance(transform.position, Enemy.transform.position) <= Range)
        {

            Debug.Log("fire shot");
            if (fireCountdown <= 0f)
            {
                Shoot();
                fireCountdown = 1f / fireRate;
            }
            fireCountdown -= Time.deltaTime;
        }
        void Shoot ()
        {
           GameObject bulletGO = (GameObject)Instantiate(BulletPrefab, FirePoint.position, FirePoint.rotation);
            Bullet bullet = bulletGO.GetComponent<Bullet>();

            if (bullet != null)
                bullet.Seek(_Enemy);
            {
                
            }
        }
    }
}
