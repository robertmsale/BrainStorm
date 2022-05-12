using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
    public float speed;
    public float lifeTime;
    public float distance;

    public GameObject destroyEffect;
    public LayerMask isSolid;
    public Vector2 direction;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyProjectile", lifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * (speed * Time.deltaTime));
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy")) {}
        Destroy(this);
    }
}
