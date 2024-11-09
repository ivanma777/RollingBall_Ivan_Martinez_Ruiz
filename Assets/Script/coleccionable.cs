using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class coleccionable : MonoBehaviour
{

     [SerializeField]GameManagerF gameManagerF;

    

    [SerializeField] float x;
    [SerializeField] float y;
    [SerializeField] float z;
    [SerializeField] float velocidad;


    private bool coleccionables;

    float timer;
    // Start is called before the first frame update
    void Start()
    {
        coleccionables = false;
        
        gameManagerF.Ncoleccionable1++;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(40, 40, 40) * Time.deltaTime);
        //timer += Time.deltaTime;

        //transform.Translate(new Vector3(x, y, z).normalized * velocidad * Time.deltaTime,Space.World);
        //if (timer >= 5)
        //{
        //    y = y * -1f;

        //    timer = 0;
        //}

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Trineo"))
        {

           
            coleccionables = true;
            Destroy(this.gameObject);
            

        }
    }
}
