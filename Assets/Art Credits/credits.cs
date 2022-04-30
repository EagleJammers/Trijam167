using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class credits : MonoBehaviour
{
    void Start()
    {
        //TODO make this print to the screen or smth
        String [] credits =
        {
            "vampire.png -by Chupup Games, url: https://opengameart.org/content/pixel-vampire "
        }
        foreach (credit in credits)
        {
            Debug.Log(credit);
        }
        
    }
}
