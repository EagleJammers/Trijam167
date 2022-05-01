using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slowtime : MonoBehaviour
{
    // Toggles the time scale between 1 and slow_mult
    // whenever the user hits the Space key.

    private float fixedDeltaTime;
    [SerializeField] private Player player;
    [SerializeField] private float slow_mult = 0.3f;


    void Awake()
    {
        // Make a copy of the fixedDeltaTime, it defaults to 0.02f, but it can be changed in the editor
        this.fixedDeltaTime = Time.fixedDeltaTime;
    }

    void Update()
    {
        //This will currently only just toggle the time when you press space -- Steven.
        if (Input.GetButton("Jump") && player.Mana > 0)
        {
            if (Time.timeScale == 1.0f)
                Time.timeScale = slow_mult;
            else
                Time.timeScale = 1.0f;
            // Adjust fixed delta time according to timescale
            // The fixed delta time will now be 0.02 real-time seconds per frame
            Time.fixedDeltaTime = this.fixedDeltaTime * Time.timeScale;
        }
    }
}
