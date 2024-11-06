using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCameraSled : MonoBehaviour
{
    //[SerializeField] GameObject Target;
    //[SerializeField] CinemachineVirtualCamera T;

    //[SerializeField] float speed;
    [SerializeField]Transform sled;    // Asigna el objeto jugador aqu�
    [SerializeField] Vector3 offset;      // Ajusta el desplazamiento de la c�mara en el Inspector
    [SerializeField] float smooth;

    private void LateUpdate()
    {
        // Posiciona la c�mara con respecto a la posici�n del jugador
        transform.position = sled.position + offset;

        // Hace que la c�mara rote junto con el jugador
        transform.rotation = Quaternion.Lerp(transform.rotation, sled.rotation, Time.deltaTime * smooth);
    }


    // Start is called before the first frame update
    void Start()
    {
        //Target = GameObject.FindGameObjectWithTag("Trineo");
        //T = GetComponent<CinemachineVirtualCamera>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.LookAt(Target.transform);
        //float sled_Move = Mathf.Abs(Vector3.Distance(this.transform.position, T.transform.position) * speed);
        //this.transform.position = Vector3.MoveTowards(this.transform.position, T.transform.position, sled_Move * Time.deltaTime);   
        //float inputRotacion = Input.GetAxis("Horizontal"); // Usa el mismo input para rotaci�n
        //RotacionYActual += inputRotacion * SmoothTime * Time.deltaTime;

        //// Limitamos el �ngulo de rotaci�n a 45 grados
        //RotacionYActual = Mathf.Clamp(RotacionYActual, -45f, 45f);

        //// Aplicamos la rotaci�n limitada
        //transform.rotation = Quaternion.Euler(0, RotacionYActual, 0);

    }

   
}
