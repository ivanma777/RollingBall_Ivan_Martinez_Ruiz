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

    [SerializeField] Salida Salida;

    [SerializeField] GameObject Player;
    
    [SerializeField] GameObject FakePlayer;



    [SerializeField] ControlVehiculo cVehiculo;

    [SerializeField] GameObject car;

    [Header("Cameras")]

    [SerializeField] private GameObject camaraPlayer;
    [SerializeField] private GameObject camaraVehicule;

    // Start is called before the first frame update
    void Start()
    {
        cVehiculo.enabled = false;
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
        camaraPlayer.SetActive(true);
        camaraVehicule.SetActive(false);
            FakePlayer.SetActive(false);
            Player.SetActive(true);

            Salida.PuedoSalir1 = false;

        
            
             Player.transform.position = car.transform.position + car.transform.TransformDirection(Vector3.left);

    }
    public void GetIn()
           {
        camaraPlayer.SetActive(false);
        camaraVehicule.SetActive(true );
                Player.SetActive(false);

             FakePlayer.SetActive(true);

             //Player.transform.position = car.transform.position + car.transform.TransformDirection(Vector3.up);
           }
}
