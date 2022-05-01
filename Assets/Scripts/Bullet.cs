using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private GameObject player;
    public float velocity = .001f;

    private float deltaX;
    private float deltaY;
    // Start is called before the first frame update
    void Start()
    {

        player = GameObject.FindGameObjectWithTag("Player");
        deltaX = player.transform.position.x - this.transform.position.x;
        deltaY = player.transform.position.y - this.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        //move at this rate x and y
        transform.Translate(new Vector3(deltaX, deltaY, 0).normalized * Time.deltaTime * velocity);
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
