using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameController : MonoBehaviour
{
    public Dropdown difi;
    public GameObject player;
    public Transform spawn;
    public int numVidas;

    List<string> dificuldades = new List<string>() {"Normal", "Hard", "Calife"};

    public static bool easy;
    public static bool normal;
    public static bool hard;

    public static float fatorDif;
    
    // Use this for initialization
    void Start ()
    {
        if (easy == false && normal == false && hard == false)
        {
            easy = true;
        }
        Globais.NUM_VIDAS_PLAYER = numVidas;
        NomLista();
	}


	// Update is called once per frame
	void Update ()
    {
        print(Globais.NUM_VIDAS_PLAYER);
		if(easy == true)
        {
            fatorDif = 1;
        }
        if(normal==true)
        {
            fatorDif = 1.5f;
        }
        else if(hard == true)
        {
            fatorDif = 2;
        }

        RespawnPlayer();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "tiro")
        {
            Destroy(col.gameObject);
        }
    }

	public void Dropdown_IndexChanged(int index)
    {
        if(index == 0)
        {
            Easy();
        }
        if(index == 1)
        {
            Normal();
        }
        if(index == 2)
        {
            Hard();
        }
    }

    void NomLista()
    {
        difi.AddOptions(dificuldades);
    }

    public void Easy()
    {
        easy = true;
        normal = false;
        hard = false;
    }

    public void Normal()
    {
        easy = false;
        normal = true;
        hard = false;
    }

    public void Hard()
    {
        easy = false;
        normal = false;
        hard = true;
    }

    public void RespawnPlayer()
    {
        if(Globais.NUM_VIDAS_PLAYER>0 && Globais.PLAYER_VIVO == false)
        {
            
            Instantiate(player, spawn.transform.position, Quaternion.identity);
            
        }
    }

}
