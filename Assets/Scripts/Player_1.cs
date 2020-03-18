using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_1 : MonoBehaviour
{
    //variaveis publicas
    public float velocidadeJogador;
    public int vida;
    public int duraçãoPowerUp;

    public GameObject disparo_1;
    public GameObject disparo_2;
    public GameObject disparo_3;
    public Transform muzzle1;
    public Transform muzzle2;
    


    //variaveis privadas
    private bool vivo;
    private Rigidbody2D rb;
    private GameObject disparo_Atual;
    private float mov_Hori;
    private float mov_Vert;
    private static float posiY;
    private static float posiX;
    private int vidaA;
    private int contadorPower;

    // Use this for initialization
    void Start ()
    {
        disparo_Atual = disparo_1;

        rb = GetComponent<Rigidbody2D>();

        vivo = true;
        Globais.PLAYER_VIVO = vivo;

        vidaA = vida;
        Globais.VIDA_JOGADOR = vidaA;


        Globais.PLAYER_VIVO = vivo;

        duraçãoPowerUp *= 60;
    }
	
    //Carlos Alberto Zgierski

	// Update is called once per frame
	void Update ()
    {
        
        if (vidaA <= 0)
        {
            Globais.PLAYER_VIVO = false;

            Globais.NUM_VIDAS_PLAYER--;
            Globais.PONTUACAO -= 50;

            Destroy(this.gameObject);
        }

        if(contadorPower <=0)
        {
            contadorPower = 0;
            disparo_Atual = disparo_1;
        }

        if (contadorPower > 0)
        {
            contadorPower--;
        }

        if (vidaA > vida)
        {
            vidaA = vida;
        }

        Globais.VIDA_JOGADOR = vidaA;
        
        

        if (Globais.PLAYER_VIVO == true)
        {
            Disparar();
        }

    }

    private void FixedUpdate()
    {


        if (Globais.PLAYER_VIVO == true)
        {
            Movi();
        }

    }

    //Carlos Alberto Zgierski

    void Movi()
    {

        posiY = transform.position.y;
        posiX = transform.position.x;
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -3.155f, 3.155f), Mathf.Clamp(transform.position.y, -5.593f,4.614f), 0);

        if(Input.GetButton("Horizontal"))
        {
            mov_Hori = Input.GetAxis("Horizontal");
            rb.AddForce(transform.up * (velocidadeJogador * (mov_Hori * 2f)));
        }

        if (Input.GetButton("Vertical"))
        {
            mov_Vert = Input.GetAxis("Vertical");
            rb.AddForce(transform.right * (velocidadeJogador*(mov_Vert * 2f)));
        }
    }

    void Disparar()
    {

        if(Input.GetButtonDown("FirePlayer1"))
        {
            Instantiate(disparo_Atual, muzzle1.transform.position, Quaternion.identity);
            Instantiate(disparo_Atual, muzzle2.transform.position, Quaternion.identity);
        }

    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Inimigo")
        {
            Destroy(col.gameObject);
            vidaA -= 5;
        }
        if(col.gameObject.tag == "PowerUp1")
        {
            Destroy(col.gameObject);
            disparo_Atual = disparo_2;
            contadorPower = duraçãoPowerUp;
        }
        if (col.gameObject.tag == "PowerUp2")
        {
            Destroy(col.gameObject);
            disparo_Atual = disparo_3;
            contadorPower = duraçãoPowerUp;
        }
        if (col.gameObject.tag == "PowerUpVida")
        {
            Destroy(col.gameObject);
            vidaA += 5;
        }
    }

    public void SofrerDano(int dano)
    {
        vidaA -= dano;
    }
    public static float PosiX()
    {
        return posiX;
    }
    public static float PosiY()
    {
        return posiY;
    }
}
