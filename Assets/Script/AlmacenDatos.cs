using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlmacenDatos : MonoBehaviour
{
    public static AlmacenDatos instance;

    

    public int Ncoleccionable;

    public int regalos;

    public int intentos;

    public float tiempo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);

        }
        else
        {
            if(instance != this)
            {
                Destroy(gameObject);

            }

        }




    }





    // Update is called once per frame
    void Update()
    {
        //trineo.Regalos = regalos;
        //trineo.Intentos = intentos;
    }
    
}
