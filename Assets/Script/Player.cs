using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float velocidad;
    [SerializeField] float velocidad1;
    [SerializeField] Vector3 direccion;
    [SerializeField] float fuerza;
    private float puntos = 0;
    private float vida = 3;
    Vector3 posInicial;
    

    [Header("Musica")]
    
    [SerializeField] private AudioClip Win;
    [SerializeField] private AudioClip lose;






    [SerializeField] float MaxDistance;
    // Start is called before the first frame update
    void Start()
    {
        posInicial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        rb = GetComponent<Rigidbody>();

        if (Input.GetKey(KeyCode.Space ))
        {
            
            if (DetectaSuelo() )
            {
                rb.AddForce(direccion * fuerza, ForceMode.Impulse);

            }
            
           
        }
        

        
        
        
        
    }

    private void FixedUpdate()
    {
        Movimiento();
    }

    public void Movimiento()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        rb.AddForce(new Vector3(h, 0, v).normalized * velocidad1, ForceMode.Force);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Trampa"))
        {
            vida -= 1;
            Destroy(other.gameObject);

        }

        if (other.CompareTag("Coleccionable"))
        {
            puntos += 10;
            Destroy(other.gameObject);

        }
        if (other.CompareTag("Muerte"))
        {
            transform.position = (posInicial);

        }
        
        
    }
    
    private bool DetectaSuelo()
    {

        
        bool resultado =Physics.Raycast(transform.position, Vector3.down,  MaxDistance);
        Debug.DrawLine(transform.position, Vector3.down,Color.red, 1f);
        return resultado;   
    }
    


    
    

}
