using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManagerF : MonoBehaviour
{
    [SerializeField] TMP_Text RegalosRecogidos;

    private int regalos;

    private int Ncoleccionable;

    

    public int Regalos { get => regalos; set => regalos = value; }
    public int Ncoleccionable1 { get => Ncoleccionable; set => Ncoleccionable = value; }

    // Start is called before the first frame update
    void Start()
    {
        RegalosRecogidos.SetText("Regalos totales recogidos: " + Regalos + " / " + Ncoleccionable1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
