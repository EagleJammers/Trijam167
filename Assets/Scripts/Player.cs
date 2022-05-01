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

        if (yMove != 0 || xMove != 0)
        {
            this.transform.position += new Vector3(xMove, yMove, 0) * Time.deltaTime * movementSpeed;
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
