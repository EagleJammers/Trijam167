using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chronoburst : MonoBehaviour
{

    [SerializeField]
    private bool show;
    [SerializeField]
    private Texture countChocolua;
    [SerializeField]
    private int showtime = 5;
    [SerializeField]
    private int showleft;
    // Start is called before the first frame update
    void Start()
    {
        showleft = showtime;
        show = false;
    }

     void OnGUI () {
         if (show) {
             GUI.DrawTexture(new Rect(0,0,1280,720), countChocolua);
         }
     }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("i")){

          Burst();

        }
        if (show){
           ShowUpdate();
          }
    }

    void Burst()
    {
      show = true;
      GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
      foreach (GameObject enemy in enemies) Destroy(enemy);
    }

    void ShowUpdate()
    {
      showleft -= 1;
      if (showleft <= 0)
      {
        show = false;
        showleft = showtime;
      }
    }
}
