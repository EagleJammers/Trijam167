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
            "bullet.png -by Gumichan01, url: https://opengameart.org/content/tx-bullet-0 "
        };
        foreach (string credit in credits)
        {
            Debug.Log(credit);
        }
        
    }
}
