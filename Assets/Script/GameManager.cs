using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;




public class GameManager : MonoBehaviour
{
    [SerializeField] TMP_Text tiempoText;
    int tiempo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag( "Salida"))
        {
            tiempo++;
            tiempoText.SetText("Timer: " + tiempo);

        }  
    }
}
