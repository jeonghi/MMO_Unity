using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float _speed = 100.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private float _yAngle = 10.0f;
    // Update is called once per frame
    void Update()
    {

        _yAngle += Time.deltaTime * _speed;
        // 절대 회전 값
        //transform.eulerAngles = new Vector3(0.0f, _yAngle, 0.0f);
        
        // +- 델타 회전 값
        //transform.Rotate(new Vector3(0.0f, Time.deltaTime * 100.0f, 0.0f), Space.World);
        //transform.rotation = Quaternion.Euler(new Vector3(0.0f, _yAngle, 0.0f));
            
        // Local -> World
        // TransformDirection
        
        // World -> Local
        // InverseTransformDirection
        
        if (Input.GetKey(KeyCode.W))
        {
            //transform.rotation = Quaternion.LookRotation(Vector3.forward);
            //transform.position += transform.TransformDirection(Vector3.forward * Time.deltaTime * _speed);
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.forward), 0.2f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            //transform.rotation = Quaternion.LookRotation(Vector3.back);
            //transform.position += transform.TransformDirection(Vector3.back * Time.deltaTime * _speed);
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.back), 0.2f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            //transform.rotation = Quaternion.LookRotation(Vector3.left);
            //transform.position += transform.TransformDirection(Vector3.left * Time.deltaTime * _speed);
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.left), 0.2f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            //transform.rotation = Quaternion.LookRotation(Vector3.right);
            //transform.position += transform.TransformDirection(Vector3.right * Time.deltaTime * _speed);
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.right), 0.2f);
        }
    }
}
