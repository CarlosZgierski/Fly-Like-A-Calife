using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparos : MonoBehaviour {

    //variaveis publicas
    public float velocidadeBala;
    public int danoBala;

    //variaveis privadas
    private Rigidbody2D rb;

	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        //usar eulerAngles para o player 2, fazer ele instancia na rotação em Z da torre
       // transform.eulerAngles = new Vector3
        transform.Translate(0, velocidadeBala * Time.deltaTime, 0);
        
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Limite")
        {
            Destroy(this.gameObject);
        }

        if(col.gameObject.tag == "Inimigo")
        {
            Inimigos prov = col.GetComponent<Inimigos>();
            prov.SofrerDano(danoBala);
            Destroy(this.gameObject);
        }
    }
}
