using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{


    public float movementSpeed = 2;
    public float manaPerSecond = 10;
    private int Health = 3;
    private float Mana = 0;
    private float MaxMana = 100;

    // Start is called before the first frame update

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float yMove = Input.GetAxisRaw("Vertical");
        float xMove = Input.GetAxisRaw("Horizontal");

        if( xMove != 0 || yMove != 0)
            transform.position += new Vector3(xMove,yMove,0).normalized*Time.deltaTime * movementSpeed;


        Mana += (manaPerSecond/Time.deltaTime);
        if (Mana >= MaxMana)
        {
            Mana = MaxMana;
            Debug.Log($"Current mana: {Mana}");
        }
    }
}
