using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParedCubos : MonoBehaviour
{
    private bool iniciarTimer;
    [SerializeField] private  Rigidbody[] rb;
    private float timer = 0;
    private void Update()
    {
        if (iniciarTimer)
        {
            timer += Time.unscaledDeltaTime;
            if (timer >= 2) 
            {
                    Time.timeScale = 1;

                    for (int i = 0; i < rb.Length; i++)
                    {

                        rb[i].useGravity = true;

                    }

            }
                

            
            
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0.2f;
            iniciarTimer = true;

        }
    }
}
