using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class credits : MonoBehaviour
{
    void Start()
    {
        //TODO make this print to the screen or smth
        string[] credits =
        {
            "vampire.png -by Chupup Games, url: https://opengameart.org/content/pixel-vampire ",
            "bullet.png -by Gumichan01, url: https://opengameart.org/content/tx-bullet-0 ",
            " light_forest_tileset_0.png -by Stephen Challener (Redshrike), commissioned by Gaurav Munjal, url: https://opengameart.org/content/32x32-and-16x16-rpg-tiles-forest-and-some-interior-tiles "
        };
        foreach (string credit in credits)
        {
            Debug.Log(credit);
        }
        
    }
}
