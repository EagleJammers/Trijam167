using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private UIManager ui;
    public float movementSpeed = 2;
    public float manaPerSecond = 10;
    private int Health = 3;
    private float Mana = 0f;
    private float MaxMana = 100f;

    // Start is called before the first frame update

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float yMove = Input.GetAxisRaw("Vertical");
        float xMove = Input.GetAxisRaw("Horizontal");

        Mana += (manaPerSecond/Time.deltaTime);
        if (Mana >= MaxMana)
        {
            Mana = MaxMana;
            //Debug.Log($"Current mana: {Mana}");
            ui.set_shown_mana(Mana);
        }
    }

    public void Damage()
    {
      this.Health -= 1;
    }
}
