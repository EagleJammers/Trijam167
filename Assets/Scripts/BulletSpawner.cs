using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bullet;
    public int freq = 6;

    private int time = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Spawns a bullet at its location every 10 seconds
        time++;

        if (time % freq == 0) {

            Instantiate(bullet, this.transform.position, Quaternion.identity); 
        }
    }
}
