using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float speed = 10f;
    public float damage = 1f;
    public float bulletLifeTime = 5f;
    private float lifeTimeLeft;

    // Start is called before the first frame update
    void Start()
    {
        ResetTimer();
    }

    void ResetTimer()
    {
        lifeTimeLeft = bulletLifeTime;
    }

    void BulletTimer()
    {
        lifeTimeLeft -= Time.deltaTime;
        if (lifeTimeLeft <= 0)
        {
            Destroy(gameObject);
            ResetTimer();
        }
    }
    // Update is called once per frame
    void Update()
    {
        Move();
        BulletTimer();
    }

    void Move()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }


}