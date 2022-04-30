using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{


    public CharacterController controllerMain;
    public float movementSpeed = 2;
    private Renderer rend;


    // Start is called before the first frame update
    void Start()
    {
         rend = GetComponent<Renderer>();


    }

    // Update is called once per frame
    void Update()
    {


        var movementVert = Input.GetAxis("Vertical");
        var movementHori = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movementHori,movementVert, 0) * Time.deltaTime * movementSpeed;

      

        float ud = Input.GetAxis("Vertical");
        float lr = Input.GetAxis("Horizontal");
        
       
        if (ud != 0 || lr != 0)
        {
            Debug.Log("Moving");

        }
        else {
            Debug.Log("Stationary");
        }
        //Key is Down
        //On Any Key Release
        //Key is Released


        if(Input.GetKeyDown("e"))
        {
            changeColor();
        }
    }

    void changeColor()
    {
      rend.material.SetColor("_Color", Color.green);

    }
}
