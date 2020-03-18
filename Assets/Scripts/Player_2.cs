using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_2 : MonoBehaviour {

    public GameObject disparo_1;
    public GameObject disparo_2;
    public GameObject disparo_3;
    public Transform muzzle;

    private GameObject disparoAtual;

    private static float rotZ;

    // Use this for initialization
    void Start ()
    {
		
	}
    // Update is called once per frame
    void Update ()
    {
        rotZ = transform.position.z;
        if (Globais.PLAYER_VIVO == true)
        {
            Disparar();
        }
        
	}

    void Disparar()
    {
        disparoAtual = disparo_1;

        if (Input.GetButtonDown("FirePlayer2"))
        {
            Instantiate(disparoAtual, muzzle.transform.position, Quaternion.identity);
        }

    }

    public static float RotZ ()
    {
        return rotZ;
    }
}
