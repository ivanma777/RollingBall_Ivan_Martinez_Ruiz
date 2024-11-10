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

    [SerializeField] TMP_Text intentosText;
    
    [SerializeField] TMP_Text regalosText;
    

    [SerializeField] AlmacenDatos almacenDatos;

    



    [Header("Conexiones")]

    [SerializeField]SceneSystem sceneSystem;

    

    private Vector3 posInicial;

    [Header("Music")]
    [SerializeField] AudioClip colec;
    [SerializeField] AudioClip victoria;
    [SerializeField] AudioClip muerte;

    [SerializeField] AudioManager audioManager;

    
    


    // Start is called before the first frame update
    void Start()
    {
        

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
            almacenDatos.tiempo +=  Time.deltaTime;


            tiempoText.SetText( almacenDatos.tiempo.ToString("F2"));

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Final"))
        {
            audioManager.ReproducirColeccionable(victoria);
            sceneSystem.Final();
        
        }

        if (other.CompareTag("Coleccionable"))
        {
            almacenDatos.regalos++;
            regalosText.SetText(": " + almacenDatos.regalos);
            audioManager.ReproducirColeccionable(colec);



        }
        if (other.CompareTag("Muerte"))
        {
            audioManager.ReproducirColeccionable(muerte);
            transform.position = (posInicial);
            almacenDatos.intentos++;
            tiempo = 0;
            intentosText.SetText(": " + almacenDatos.intentos);
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

