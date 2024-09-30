using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coleccionable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(40, 90, 90) * Time.deltaTime);
    }
}
