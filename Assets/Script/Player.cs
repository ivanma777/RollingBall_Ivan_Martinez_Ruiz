using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float velocidad;
    [SerializeField] float velocidad1;
    [SerializeField] Vector3 direccion;
    [SerializeField] float fuerza;
    // Start is called before the first frame update
    void Start()
    {
        
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
}
