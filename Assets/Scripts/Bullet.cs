using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float velocity = .01f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(velocity, 0, 0));
    }

    void OnCollisionEnter(Collision collision)
    {
        GameObject collide = collision.gameObject;
        string collidetag = collide.tag;

        if(collidetag == "Player")
        {
          //collision.gameObject.damage()
          Destroy(this);
        }
        else if(collidetag == "Wall")
        {
          Destroy(this);
        }

    }
}
