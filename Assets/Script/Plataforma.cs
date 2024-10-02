using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour
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
        timer += Time.deltaTime;

        transform.Translate(new Vector3(x, y, z).normalized * velocidad * Time.deltaTime);
        if (timer >= 5)
        {
            x = x * -1f;

            timer = 0;
        }
    }
}
