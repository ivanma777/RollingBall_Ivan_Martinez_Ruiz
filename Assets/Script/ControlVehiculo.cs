using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlVehiculo : MonoBehaviour
{

  



    [SerializeField] float velocidadMaxima = 10f; // Velocidad máxima que puede alcanzar el objeto
    [SerializeField] float aceleracion = 2f; // Aceleración del objeto
    [SerializeField] float desaceleracion = 3f; // Desaceleración cuando se deja de mover
    [SerializeField] private float smoothTime;
    [SerializeField] private float smoothTimeR;



    private float rotacionYActual = 0f;

    private Vector3 velocidadActual = Vector3.zero; // Velocidad actual del objeto

    public float SmoothTime { get => smoothTime; set => smoothTime = value; }
    public float RotacionYActual { get => rotacionYActual; set => rotacionYActual = value; }

    private Quaternion rotacionInicial;

    private void Start()
    {
        rotacionInicial = transform.rotation;
    }

    void Update()
    {
        // Obtenemos el input de movimiento (WASD o flechas)
        float inputHorizontal = Input.GetAxis("Horizontal");
        float inputVertical = Input.GetAxis("Vertical");

        // Creamos un vector de dirección en base al input
        Vector3 direccionMovimiento = new Vector3(0, 0, inputVertical).normalized;


        // Si hay input, aceleramos
        if (direccionMovimiento.magnitude > 0)
        {
            // Incrementamos la velocidad en la dirección deseada
            velocidadActual += direccionMovimiento * aceleracion * Time.deltaTime;

            // Limitamos la velocidad a la velocidad máxima
            if (velocidadActual.magnitude > velocidadMaxima)
            {
                velocidadActual = velocidadActual.normalized * velocidadMaxima;
            }
        }
        //else
        //{
        //    // Si no hay input, aplicamos desaceleración
        //    velocidadActual = Vector3.Lerp(velocidadActual, Vector3.zero, desaceleracion * Time.deltaTime);
        //}

        // Movemos el objeto usando la velocidad actual
        velocidadActual = AdjustVelocityToSlope( velocidadActual );
        transform.Translate(velocidadActual * Time.deltaTime);


        float inputRotacion = Input.GetAxis("Horizontal"); // Usa el mismo input para rotación

        if (Mathf.Abs(inputRotacion) > 0.01f)
        {
            RotacionYActual += inputRotacion * SmoothTime * Time.deltaTime;

            // Limitamos el ángulo de rotación a 45 grados
            RotacionYActual = Mathf.Clamp(RotacionYActual, -45f, 45f);

            // Aplicamos la rotación limitada
            transform.rotation = Quaternion.Euler(0, RotacionYActual, 0) ;
        }
        else 
        
        {
            RotacionYActual = 0f;
            
            transform.rotation = Quaternion.Slerp(transform.rotation, rotacionInicial, smoothTimeR * Time.deltaTime);



        }
    }

    private Vector3 AdjustVelocityToSlope(Vector3 velocity)

    { 
        var ray = new Ray(transform.position, Vector3.down);
        
        if (Physics.Raycast(ray, out RaycastHit hitInfo, 0.2f ))
        {
            var slopeRotation = Quaternion.FromToRotation(Vector3.up, hitInfo.normal);
            var adjustVelocity = slopeRotation * velocity;

            if (adjustVelocity.y < 0)
            {
                return adjustVelocity;

            }

        }
            return velocity;
    
    }
    //private CharacterController controller;

    //private float velocidadRotacion;

    //[SerializeField] private float velocidadMovimiento;
    //[SerializeField] private float velocidadMax;
    //[SerializeField] private float velocidadMin;


    ////Rigidbody rb;
    ////private Animator anim;
    //// Start is called before the first frame update
    //void Start()
    //{
    //    controller = GetComponent<CharacterController>();
    //    //anim = GetComponent<Animator>();


    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    float h = Input.GetAxisRaw("Horizontal");
    //    float v = Input.GetAxisRaw("Vertical");



    //    transform.Translate(new Vector3(h, 0, v).normalized * velocidadMovimiento * Time.deltaTime);


    //    //transform.eulerAngles = new Vector3(h, 0, v) * Time.deltaTime;
    //    //Vector2 input = new Vector2(h, v);
    //    //if (input.magnitude > 0)
    //    //{
    //    //    //anim.SetBool("Walking", true);
    //    //    float angulo = Mathf.Atan2(input.x, input.y) * Mathf.Rad2Deg + Camera.main.transform.eulerAngles.y;



    //    //    float anguloSuave = Mathf.SmoothDampAngle(transform.eulerAngles.y, angulo, ref velocidadRotacion, smoothTime);

    //    //    transform.eulerAngles = new Vector3(0, anguloSuave, 0);

    //    //    Vector3 movimiento = Quaternion.Euler(0, angulo, 0) * Vector3.forward;

    //    //    //controller.Move(movimiento * velocidadMovimiento * Time.deltaTime);
    //    //}
    //    //else
    //    //{
    //    //    //anim.SetBool("Walking", false);
    //    //}

    //}
        
}
