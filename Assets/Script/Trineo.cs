using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trineo : MonoBehaviour
{
    SceneSystem sceneSystem;

    
    // Start is called before the first frame update
    void Start()
    {
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
    }








}

