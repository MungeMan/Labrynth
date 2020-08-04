using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{ 
    public float camRotationX;
    public float camRotationY;
    public float camRotationZ;
    private Vector3 offset;
    public float turnSpeed = 1f;
     

    public GameObject player;
    Camera camera;
    
    // Start is called before the first frame update
    void Start()
    {
        camera= GetComponent<Camera>();
        //transform.rotation = Quaternion.Euler(camRotationX, camRotationY, camRotationZ);
    }

    // Update is called once per frame
    void Update()
    {
        camera.transform.position=new Vector3 (player.transform.position.x, (float)(player.transform.position.y+7.25), player.transform.position.z);
        camera.transform.rotation = player.transform.rotation;
        //offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * turnSpeed, Vector3.up) * Quaternion.AngleAxis(Input.GetAxis("Mouse Y") * turnSpeed, Vector3.right) * offset;
    }
}
