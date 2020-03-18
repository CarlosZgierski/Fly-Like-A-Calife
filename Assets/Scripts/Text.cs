using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text : MonoBehaviour
{
    public InputField points;
    public InputField Wave;

	// Use this for initialization
	void Start ()
    {
       
	}
	
	// Update is called once per frame
	void Update ()
    {
        points.text = "Pontuação: " + Globais.PONTUACAO.ToString();
        Wave.text = "Wave " + Globais.WAVE.ToString();
	}
}
