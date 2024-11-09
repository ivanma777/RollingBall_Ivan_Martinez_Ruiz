using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trineo : MonoBehaviour
{
    SceneSystem sceneSystem;

    GameManagerF gameManagerF;

    private Vector3 posInicial;

    
    // Start is called before the first frame update
    void Start()
    {
        gameManagerF.Regalos = 0;

        posInicial = transform.position;
        //if (Mathf.Abs(inputRotacion) > 0f)
        //{
        //    // Limitamos el ángulo de rotación a 45 grados
        //    //frenado = RotacionYActual;
        //    velocidadActual = Vector3.Lerp(velocidadActual, Vector3.zero, desaceleracion * Time.deltaTime);

        //}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Final"))
        {
            sceneSystem.Final();
        
        }

        if (other.CompareTag("Coleccionable"))
        {
            gameManagerF.Regalos += 1;
            Destroy(other.gameObject);

        }
        if (other.CompareTag("Muerte"))
        {
            transform.position = (posInicial);
            //intentos--;

        }
    }








}

