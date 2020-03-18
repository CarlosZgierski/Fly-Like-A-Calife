using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigos : MonoBehaviour
{
    //variaveis publicas
    public bool tier1;
    public bool tier2;
    public bool tier3;
    public int vida;
    public int coolDownBala;
    public float velocidade;
    public GameObject tiro;
    public Transform muzzle1;
    public Transform muzzle2;
    public Transform muzzle3;
   

    //variaveis privadas
    private Rigidbody2D rb;
    private int vidaA;
    private int contadorBalas;
    private int cooldown;
    private bool disparar;
    private float posX;
    private float velLateral;
    private float npcX;

    //animação
    private Animator anim;
    public bool morreu;

	// Use this for initialization
	void Start ()
    {
        velLateral = velocidade*0.8f;

        anim = GetComponent<Animator>();

        vidaA = vida;
        velocidade *= -1;

        posX = transform.position.x;
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        cooldown = (Random.Range(coolDownBala - 2, coolDownBala + 2));
        cooldown *= 60;

        if(contadorBalas >= cooldown)
        {
            disparar = true;
        }

        if(transform.position.x > (posX+0.5) || transform.position.x < (posX - 0.5))
        {
            velLateral *= -1;
        }

        if (contadorBalas < cooldown )
        {
            contadorBalas++;
            disparar = false;
        }

        if (vidaA > 0)
        {
            atirar();
            Movimento();
        }

        if(vidaA <= 0)
        {
            if (tier1)
            {
                anim.SetBool("Morreu", true);
            }
            else if (tier2)
            {
                anim.SetBool("Morreu", true);
            }
            else
            {
                anim.SetBool("Morreu", true);
            }

            
        }
	}

    public void SofrerDano(int dano)
    {
        vidaA -= dano;
    }

    private void atirar()
    {
        if (tier1)
        {
            if (disparar == true)
            {
                Instantiate(tiro, muzzle1.transform.position, Quaternion.identity);
                contadorBalas = 0;
            }
        }
        else if(tier2)
        {
            if (disparar == true)
            {
                Instantiate(tiro, muzzle1.transform.position, Quaternion.identity);
                Instantiate(tiro, muzzle2.transform.position, Quaternion.identity);
                contadorBalas = 0;
            }
        }
        else
        {
            if (disparar == true)
            {
                Instantiate(tiro, muzzle1.transform.position, Quaternion.identity);
                Instantiate(tiro, muzzle2.transform.position, Quaternion.identity);
                Instantiate(tiro, muzzle3.transform.position, Quaternion.identity);
                contadorBalas = 0;
            }
        }
    }

    private void Movimento()
    {
        npcX = velLateral * Time.deltaTime;
        npcX = Mathf.Clamp(npcX, -3.136f, 3.151f);
        transform.Translate(npcX, velocidade * Time.deltaTime,0);
        
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if(col.gameObject.tag == "Limite_Inimigos")
        {
            Destroy(gameObject);
        }
    }

    public void Destruir()
    {
        if(tier1 == true)
            Globais.PONTUACAO += 10;
        if(tier2 == true)
            Globais.PONTUACAO += 25;
        if(tier3 == true)
            Globais.PONTUACAO += 50;
        Destroy(this.gameObject);
    }
}
