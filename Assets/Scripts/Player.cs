using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private UIManager ui;
    [SerializeField] private Rigidbody2D rb;
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
        var yMove = Input.GetAxis("Vertical");
        var xMove = Input.GetAxis("Horizontal");


        if (yMove != 0 || xMove != 0)
        {
            rb.MovePosition(rb.position + new Vector2(xMove, yMove).normalized*Time.deltaTime*movementSpeed);
        }


        if (Mana < MaxMana)
            Mana += (manaPerSecond*Time.deltaTime);
        else
            Mana = MaxMana;


        ui.set_shown_health(Health);
        ui.set_shown_mana(Mana);
    }

    public void Damage()
    {
      this.Health -= 1;
    }
}
