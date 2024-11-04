using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlVehiculo : MonoBehaviour
{
    [SerializeField] float velocidadV;

    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MovimientoVehiculo()
    {

        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        rb.AddForce(new Vector3(h, 0, v).normalized * velocidadV, ForceMode.Force);


    }
}
