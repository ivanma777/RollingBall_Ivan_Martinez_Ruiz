using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salida : MonoBehaviour
{
    private bool PuedoSalir;

    [SerializeField] ControlVehiculo cVehiculo;

    [SerializeField] GameObject FakePlayer;

    [SerializeField] GameManager gameManager;

    public bool PuedoSalir1 { get => PuedoSalir; set => PuedoSalir = value; }

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


        if (other.CompareTag("FakePlayer"))
        {
            PuedoSalir = true;
        }
    }

    

    public void SalirVehiculo()
    {
        if (PuedoSalir)
        {
            gameManager.GetOutCar();
            cVehiculo.enabled = false;
        }

    }
}
