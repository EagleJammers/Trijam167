using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showVampireImage : MonoBehaviour
{

    private bool show;
    public Texture countChocolua;
    // Start is called before the first frame update
    void Start()
    {
        show = false; 
    }

     void OnGUI () {
         if (show) {
             GUI.DrawTexture(new Rect(0,0,Screen.width,Screen.height), countChocolua);
         }
     }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("i")){
            
            show = true;

        }

        else if (Input.GetKeyDown("p")) {
            show = false;
        }

    }
}
