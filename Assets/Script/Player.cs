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
    [SerializeField] TMP_Text tiempoText;
    int tiempo;
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
            rb.AddForce(direccion * fuerza, ForceMode.Impulse);
        }
        

        rb.AddForce(new Vector3(h, 0, v).normalized  * velocidad1,ForceMode.Force);

        
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
        if (other.CompareTag("Salida"))
        {
            tiempo++;
            tiempoText.SetText("Timer: " + tiempo);

        }
    }
   


}
