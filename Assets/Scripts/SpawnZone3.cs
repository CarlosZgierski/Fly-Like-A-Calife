using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnZone3 : MonoBehaviour {

    public GameObject tier3;

    private float numInimigos3;

    // Use this for initialization
    IEnumerator Start()
    {
        while (Globais.PLAYER_VIVO == true)
        {
            yield return new WaitForSeconds(Globais.ESPERA_INICIO + 10);
            if (Globais.NUM_INIMIGOS >= 40)
            {
                numInimigos3 = Globais.NUM_INIMIGOS / 15 + 1;

                for (int x = 0; x < numInimigos3; x++)
                {
                    Vector3 spawn = new Vector3(Random.Range(-3.136f, 3.151f), transform.position.y, 0f);
                    Instantiate(tier3, spawn, Quaternion.identity);
                    yield return new WaitForSeconds(Globais.ESPERA + 10);
                }
                yield return new WaitForSeconds(Globais.ESPERA_WAVE);
            }
        }
    }
}
