using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coleccionable : MonoBehaviour
{
    [SerializeField] float x;
    [SerializeField] float y;
    [SerializeField] float z;
    [SerializeField] float velocidad;


    float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(40, 40, 40) * Time.deltaTime);
        timer += Time.deltaTime;

        transform.Translate(new Vector3(x, y, z).normalized * velocidad * Time.deltaTime,Space.World);
        if (timer >= 5)
        {
            y = y * -1f;

            timer = 0;
        }
    }
}