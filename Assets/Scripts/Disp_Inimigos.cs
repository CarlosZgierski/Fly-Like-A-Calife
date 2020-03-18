using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disp_Inimigos : MonoBehaviour
{

    //variaveis publicas
    public float velocidadeBala;
    public int danoBala;

    //variaveis privadas
    private Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        velocidadeBala *= -1;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, velocidadeBala * Time.deltaTime, 0);
        Destroy(this.gameObject, 20);
    }

    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag == "Player")
        {
            Player_1 prov = col.GetComponent<Player_1>();
            prov.SofrerDano(danoBala);
            Destroy(this.gameObject);
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.tag == "Limite_Inimigos")
        {
            Destroy(this.gameObject);
        }

    }
}
