using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vida : MonoBehaviour
{
    public Sprite Vida100;
    public Sprite Vida90;
    public Sprite Vida80;
    public Sprite Vida70;
    public Sprite Vida60;
    public Sprite Vida50;
    public Sprite Vida40;
    public Sprite Vida30;
    public Sprite Vida20;
    public Sprite Vida10;
    public Sprite Vida0;

    private Image atual;

    // Use this for initialization
    void Start ()
    {
        atual = GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(Globais.VIDA_JOGADOR == 10)
        atual.sprite = Vida100;
        if (Globais.VIDA_JOGADOR == 9)
            atual.sprite = Vida90;
        if (Globais.VIDA_JOGADOR == 8)
            atual.sprite = Vida80;
        if (Globais.VIDA_JOGADOR == 7)
            atual.sprite = Vida70;
        if (Globais.VIDA_JOGADOR == 6)
            atual.sprite = Vida60;
        if (Globais.VIDA_JOGADOR == 5)
            atual.sprite = Vida50;
        if (Globais.VIDA_JOGADOR == 4)
            atual.sprite = Vida40;
        if (Globais.VIDA_JOGADOR == 3)
            atual.sprite = Vida30;
        if (Globais.VIDA_JOGADOR == 2)
            atual.sprite = Vida20;
        if (Globais.VIDA_JOGADOR == 1)
            atual.sprite = Vida10;
        if (Globais.VIDA_JOGADOR <= 0)
            atual.sprite = Vida0;
    }
}
