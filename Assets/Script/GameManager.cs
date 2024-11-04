using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;




public class GameManager : MonoBehaviour
{
    [SerializeField] TMP_Text tiempoText;
    int tiempo;

    [SerializeField] KeyCode EnterCodeKey = KeyCode.E;

    [Header("Entrada/Salida")]

    [SerializeField] PlayerInOut Entrada;

    [SerializeField] Trineo Salida;

    [SerializeField] GameObject Player;


    [SerializeField] GameObject car;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(EnterCodeKey))
        {
            Entrada.EntrarVehiculo();

            Salida.SalirVehiculo();


        }


    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag( "Salida"))
        {
            tiempo++;
            tiempoText.SetText("Timer: " + tiempo);

        }  
    }
    public void GetOutCar()
           {


             Player.transform.position = car.transform.position + car.transform.TransformDirection(Vector3.left);

           }
    public void GetIn()
             {

             Player.transform.position = car.transform.position + car.transform.TransformDirection(Vector3.up);
             }
}
