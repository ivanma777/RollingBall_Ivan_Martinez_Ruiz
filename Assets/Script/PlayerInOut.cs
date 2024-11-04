using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInOut : MonoBehaviour
{
    

    private bool PuedoEntrar;

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
            PuedoEntrar = true;
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



        }

    }
     


}
