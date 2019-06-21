using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atirador : MonoBehaviour
{
    public GameObject projetilPrefab;
    public Transform origemDoTiro;
    public bool olhandoParaDireita;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")){
            Atirar();
        }
    }

    void Atirar(){

        var tiro = (GameObject)Instantiate(
            projetilPrefab,
            origemDoTiro.position,
            origemDoTiro.rotation
        );

        if(olhandoParaDireita)
        tiro.GetComponent<Rigidbody2D>().velocity = transform.right * 60f;
        else
        tiro.GetComponent<Rigidbody2D>().velocity = -transform.right * 60f;
        
        tiro.GetComponent<CausaDano>().causador = this.gameObject;

    }
}
