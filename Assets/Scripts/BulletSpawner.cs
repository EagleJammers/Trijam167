using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bullet;
    public int freq = 600;

    private int time = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Spawns a bullet at its location every 10 seconds
        time++;

        if (time % freq == 0) {
            Debug.Log("spawn");
            Instantiate(bullet, this.transform.position, Quaternion.identity); 
        }
    }
}
