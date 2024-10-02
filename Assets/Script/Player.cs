using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    [SerializeField] float velocidad;
    [SerializeField] float velocidad1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {

            transform.Translate(new Vector3(0, 0, 1).normalized * velocidad * Time.deltaTime, Space.World);

        } 
        if(Input.GetKey(KeyCode.S))
        {

            transform.Translate(new Vector3(0, 0, -1).normalized * velocidad * Time.deltaTime, Space.World);

        } 
        if(Input.GetKey(KeyCode.A))
        {

            transform.Translate(new Vector3(1, 0, 0).normalized * velocidad * Time.deltaTime, Space.World);

        } 
        if(Input.GetKey(KeyCode.D))
        {

            transform.Translate(new Vector3(-1, 0, 0).normalized * velocidad * Time.deltaTime, Space.World);

        }
        if(Input.GetKey(KeyCode.Space))
        {

            transform.Translate(new Vector3(0, 2, 0)* velocidad1 * Time.deltaTime, Space.World);

        }

    }
}
