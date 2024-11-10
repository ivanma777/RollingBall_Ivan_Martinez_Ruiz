using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlVehiculo : MonoBehaviour
{

    [SerializeField] Rigidbody rb;

    public float forwardAccel = 8f, reverseAccel = 4f, macSpeed = 50f, turnStrength = 180f, gravityForce= 2f, dragOnGround = 3f;

    private float speedInput, turnInput;

    private bool grounded;

    public LayerMask Ground;

    public float groundRayLenght = 1f;

    [SerializeField] Transform groundRayPoint;

    private void Start()
    {
        rb.transform.parent = null;
    }

    private void Update()
    {
        transform.position = rb.position;

        speedInput = 0;
        if(Input.GetAxis("Vertical") > 0)
        {
            speedInput = Input.GetAxis("Vertical") * forwardAccel * 100f; 


        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            speedInput = (Input.GetAxis("Vertical")) * reverseAccel * 100f; 

        }


        turnInput = Input.GetAxis("Horizontal");


        if (grounded )
        {

        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0f, turnInput * turnStrength * Time.deltaTime , 0f) ) ;


        }




    }

    private void FixedUpdate()
    {
        grounded = false;
        RaycastHit hit;

        if( Physics.Raycast(groundRayPoint.position, -transform.up, out hit, groundRayLenght, Ground ))
        {
            grounded = true;    

            transform.rotation = Quaternion.FromToRotation(transform.up, hit.normal) * transform.rotation;
        }

        if( grounded )
        {

            rb.drag = dragOnGround;
             if(Mathf.Abs(speedInput) > 0)
             {
                rb.AddForce(transform.forward *  speedInput);
            
             }



        }
        else
        {
            rb.drag = 0.1f;
            rb.AddForce(Vector3.up * -gravityForce );


        }
    }











    //private float aceleracion;

    //private float speed;
    //private float rotate;

    //private float steering;

    //private float currentSpeed;
    //private float currentRotate;

    //private bool drifting;
    //private int driftDirection;

    //[SerializeField] Transform trineo;



    //private Rigidbody sphere;

    //[Header("Musica")]
    //[SerializeField] private AudioClip deslizar;
    //[SerializeField] private AudioClip choque;
    //private AudioManager audioManager;

    //public float Aceleracion { get => aceleracion; set => aceleracion = value; }

    ////private Quaternion rotacionInicial;

    //private void Start()
    //{
    //    /*rotacionInicial = transform.rotation*/;
    //    sphere = GetComponent<Rigidbody>(); 

    //    trineo = GetComponent<Transform>();
    //}

    //void Update()
    //{


    //    if (Input.GetAxis("Horizontal") != 0f)
    //    {
    //        int direccion = Input.GetAxis("Horizontal") > 0 ? 1 : -1;

    //        float amount = Mathf.Abs((Input.GetAxis("Horizontal")));

    //        Steer(direccion, amount);
    //    }

    //    //Drift
    //    if (Input.GetButtonDown("Jump") && !drifting && Input.GetAxis("Horizontal") != 0)
    //    {

    //        drifting = true;
    //        driftDirection = Input.GetAxis("Horizontal") > 0 ? 1 : -1; 
    //    }

    //    if (drifting)
    //    {
    //        float control = Input.GetAxis("Horizontal");
    //        Steer(driftDirection, 1* control); 

    //    }

    //    currentSpeed = Mathf.SmoothStep(currentSpeed, speed, Time.deltaTime * 12f); speed = 0f;
    //    currentRotate = Mathf.Lerp(currentRotate, rotate, Time.deltaTime * 4f); rotate = 0f;

    //}

    //private void FixedUpdate()
    //{
    //    sphere.AddForce(trineo.forward * currentSpeed, ForceMode.Acceleration);

    //        transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, new Vector3(0, transform.eulerAngles.y + currentRotate, 0), Time.deltaTime * 5f);
    //}


    //void Steer(int direccion, float amount)
    //{
    //    rotate = (steering * direccion) * amount;

    //}

    //void Raycast()
    //{
    //     RaycastHit hitOn;
    //    RaycastHit hitNear;

    //    Physics.Raycast(transform.position, Vector3.down, out hitOn, 1.1f);
    //    Physics.Raycast(transform.position, Vector3.down, out hitNear, 2.0f);

    //    trineo.up = Vector3.Lerp(trineo.up, hitNear.normal, Time.deltaTime * 8f);
    //    trineo.Rotate(0, transform.eulerAngles.y, 0);
    //}
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
