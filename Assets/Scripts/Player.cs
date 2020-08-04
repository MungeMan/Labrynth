using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocity= 10;
    private Vector3 movement;
    private Rigidbody rb;
    private SphereCollider sp;
    public int health=3;
    private bool damageFlag = false;
    public float mouseSensitivity = 5f;
    public Camera camera;
    public float moveSpeed = 2f;
    public ArrayList item = new ArrayList();
    public ArrayList weapon = new ArrayList();
    public ArrayList armor = new ArrayList();


    // Start is called before the first frame update
    private void Move()
    {
        transform.Translate(Vector3.forward * Input.GetAxis("Vertical") * velocity * Time.deltaTime);
        transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * velocity * Time.deltaTime);
        transform.Rotate(Vector3.up * Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime);
    }

    void Start()
    {
        rb= GetComponent<Rigidbody>();
        sp= GetComponent<SphereCollider>();
        //camera= GetComponent<Camera>();
    }
    void OnCollisionEnter(Collision collision)
    {
       
        if(collision.gameObject.tag=="Obstacle")
        {
           if (health > 0 && damageFlag==false)
            {
                health = health - 1;
                damageFlag = true;
                StartCoroutine(WaitRaiseHealthFlag(2));
            }
            
        }

    }
    // Update is called once per frame
    IEnumerator WaitRaiseHealthFlag(int time)
    {
        yield return new WaitForSeconds(time);
        damageFlag = false;


    }
    void Update()
    {
        //float inputX= Input.GetAxis("Horizontal");
        //float inputZ= Input.GetAxis("Vertical");
        //movement= new Vector3(inputX, 0, inputZ).normalized * velocity;
        //transform.Rotate(camera.transform.rotation.x, camera.transform.rotation.y, camera.transform.rotation.z);
        rb.MoveRotation(rb.rotation * Quaternion.Euler(new Vector3(0, Input.GetAxis("Mouse X") * mouseSensitivity, 0)));
        //rb.MovePosition(transform.position + (transform.forward * Input.GetAxis("Vertical") * moveSpeed) + (transform.right * Input.GetAxis("Horizontal") * moveSpeed));
        transform.position += (transform.forward * Input.GetAxis("Vertical") * moveSpeed) + (transform.right * Input.GetAxis("Horizontal") * moveSpeed);
    }
    void FixedUpdate() 
    {
        //rb.velocity=movement;


    }

}
