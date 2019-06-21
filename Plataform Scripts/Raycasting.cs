using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycasting : MonoBehaviour
{

    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.left);

        Color corDoRaio = Color.black;

        if (hit.collider.gameObject.tag == "Player"){
            corDoRaio = Color.red;
            print("O " + hit.collider + " está a " + hit.distance + " de distância.");

            //Only shots if the player in the nearest object
            if (hit.distance <= 5 && hit.collider.gameObject.tag == "Player")
            GetComponent<AtiradorIA>().Atirar();
        }

        Debug.DrawRay(transform.position, Vector2.left * 1000, corDoRaio);

    }
}
