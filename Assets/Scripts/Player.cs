using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
         rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
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
