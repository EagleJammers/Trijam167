using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private UIManager ui;
    public float movementSpeed = 2;
    public float manaPerSecond = 10;
    private int Health = 3;
    public float Mana = 0f;
    private float MaxMana = 100f;
    [SerializeField] private float manaDrainMultiplier = 3f;

    private float minMana = 0f;
    //private bool slowTimeInUse = false;

    // Start is called before the first frame update

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var yMove = Input.GetAxisRaw("Vertical");
        var xMove = Input.GetAxisRaw("Horizontal");


        if (yMove != 0 || xMove != 0)
        {
            this.transform.Translate(new Vector3(xMove, yMove,0).normalized*Time.deltaTime*movementSpeed);
        }





        if(!Input.GetButton("Jump")){
            if (Mana < MaxMana)
                Mana += (manaPerSecond*Time.deltaTime);
            else
                Mana = MaxMana;
        }
        else if (Input.GetButton("Jump")){
            if (Mana > minMana) {
                Mana -= (manaPerSecond*Time.deltaTime*manaDrainMultiplier);
            }
            else {
                Mana = minMana;
            }
        }


        ui.set_shown_health(Health);
        ui.set_shown_mana(Mana);
    }

    public void Damage()
    {
      this.Health -= 1;
      if (this.Health <= 0) Destroy(this);
    }
}
