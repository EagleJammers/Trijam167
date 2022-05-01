using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject player;
    public float velocity = .001f;
    private float ySpeed;
    private float xSpeed;

    // Start is called before the first frame update
    void Start()
    {
        //Get the player's y
        float playerY = player.transform.position.y;

        //get my y
        float thisY = this.transform.position.y;

        float deltaX = player.transform.position.x - this.transform.position.x;
        float deltaY = playerY - thisY;

        //Determine the y val
        ySpeed = deltaY * velocity;
        xSpeed = deltaX * velocity;
        Debug.Log(ySpeed);
    }

    // Update is called once per frame
    void Update()
    {
        //move at this rate x and y
        transform.Translate(new Vector3(xSpeed, ySpeed, 0));
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
