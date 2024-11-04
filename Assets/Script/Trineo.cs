using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trineo : MonoBehaviour
{
    bool PuedoSalir;

    [SerializeField] GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {


        if (other.CompareTag("Player"))
        {
            PuedoSalir = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PuedoSalir = false;

        }
    }

    public void SalirVehiculo()
    {
        if (PuedoSalir)
        {
            gameManager.GetOutCar();

        }

    }
    

}

