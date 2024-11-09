using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Trineo : MonoBehaviour
{
    [Header("Tiempo")]
    [SerializeField] TMP_Text tiempoText;
    float tiempo;
    bool haSalido;

    [Header("Conexiones")]

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
        if (haSalido == true)
        {
            tiempo +=  Time.deltaTime;


            tiempoText.SetText( tiempo.ToString("F2"));

        }
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

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Salida"))
        {
            haSalido = true;

        }
    }









}

