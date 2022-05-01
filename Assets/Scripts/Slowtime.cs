using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slowtime : MonoBehaviour
{
    // Toggles the time scale between 1 and slowness_percent
    // whenever the user hits the Space key.

    private float fixedDeltaTime;
    [SerializeField] private float slowness_percent = 0.3f;

    void Awake()
    {
        // Make a copy of the fixedDeltaTime, it defaults to 0.02f, but it can be changed in the editor
        this.fixedDeltaTime = Time.fixedDeltaTime;
    }

    void Update()
    {
        //This will currently only just toggle the time when you press space -- Steven.
        if (Input.GetButtonDown("Jump"))
        {
            if (Time.timeScale == 1.0f)
                Time.timeScale = slowness_percent;
            else
                Time.timeScale = 1.0f;
            // Adjust fixed delta time according to timescale
            // The fixed delta time will now be 0.02 real-time seconds per frame
            Time.fixedDeltaTime = this.fixedDeltaTime * Time.timeScale;
        }
    }
}