using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aceleration : MonoBehaviour
{
    [SerializeField] ControlVehiculo ControlVehiculo;

    private void Start()
    {
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Trineo"))
        {
            ControlVehiculo.Aceleracion *= 20f;
            

        }
    }
}
