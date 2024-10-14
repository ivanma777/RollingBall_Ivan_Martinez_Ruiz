using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiaCamera : MonoBehaviour
{
    [SerializeField] private GameObject camara1;
    [SerializeField]private GameObject camara2;
    // Start is called before the first frame update
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if(camara1.activeSelf)
            {

                camara2.SetActive(false);
                camara2.SetActive(true);
            }
            else
            {
                camara2.SetActive(true);
                camara2.SetActive(false);

            }

        }
    }
}
