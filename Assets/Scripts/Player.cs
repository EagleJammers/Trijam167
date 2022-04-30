using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {


        float ud = Input.GetAxisRaw("Vertical");
        float lr = Input.GetAxis("Horizontal");

    
       
        if (up != 0 || down != 0)
        {
            Debug.Log("Moving");

        }
        else {
            Debug.Log("Stationary");
        }
        //Key is Down
        //On Any Key Release
        //Key is Released

    }
}
