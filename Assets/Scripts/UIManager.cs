using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    //Use these to assign your GUI parts you want
    [SerializeField] private Text healthText;
    [SerializeField] private Text manaText;
    [SerializeField] private Text timeText;
    
    void Start()
    {
        
    }

    void Update()
    {
        //this will probably slow down when time slows down btw.
        timeText.text = Time.time.ToString();
    }
    public void set_shown_mana(float mana)
    {
        //setter for the gui
        manaText.text = mana.ToString();
    }
    public void set_shown_health(float health)
    {
        //setter for the gui
        healthText.text = health.ToString();
    }
}
