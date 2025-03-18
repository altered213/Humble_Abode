using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Transform Enemy;

    public float speed = 70f;

    public void Seek (Transform _Enemy) 
    {
        Enemy = _Enemy;
    }

    // Update is called once per frame
    void Update()
    {
        if (Enemy == null)
        {
            Destroy(gameObject);
            return;
        }
        Vector3 dir = Enemy.position - transform.position;
        float distanceThisFrame = speed * Time.deltaTime;

        if (dir.magnitude <= distanceThisFrame) 
        {
            HitEnemy();
            return;
        }

        transform.Translate(dir.normalized * distanceThisFrame, Space.World);
    }
    void HitEnemy ()
    {
        Debug.Log("BULLET HAS HIT");
    }
}
