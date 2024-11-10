using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerInOut : MonoBehaviour
{
    

    private bool PuedoEntrar;

    [SerializeField] GameManager gameManager;

    [SerializeField] ControlVehiculo cVehiculo;

    [SerializeField] GameObject Boton;

    // Start is called before the first frame update
    void Start()
    {
        Boton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {


        


    }


    private void OnTriggerEnter(Collider other)
    {
        
        
        if (other.CompareTag("Player"))
        {
            PuedoEntrar = true;
            Boton.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PuedoEntrar= false;
            

        }
       
    }

    
    

    public void EntrarVehiculo()
    {
        if (PuedoEntrar)
        {
            gameManager.GetIn();



            cVehiculo.enabled = true;
            Boton.SetActive(false);
        }

    }
     


}
