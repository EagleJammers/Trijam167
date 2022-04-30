using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public CharacterController controllerMain;

    public float movementSpeed = 2;

    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {

        var movement = Input.GetAxis("Vertical");
        transform.position += new Vector3(0,movement, 0) * Time.deltaTime * movementSpeed;
        
    }
}
