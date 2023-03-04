using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject Bullet;
    public float speed;
    private Rigidbody rig_bullet;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
           GameObject createdBullet = Instantiate(Bullet);

           createdBullet.transform.position = transform.position;

           rig_bullet = createdBullet.GetComponent<Rigidbody>();

           Camera cam = Camera.main;

           rig_bullet.velocity = cam.transform.rotation * Vector3.forward * speed;

        }
    }
}
