using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class ball : MonoBehaviour
    
{
    public float speed = 1.0f;
    private Rigidbody myRigid;
// Start is called before the first frame update
void Start()
    {
        myRigid = this.GetComponent<Rigidbody>();
        myRigid.AddForce((transform.forward + transform.right) * speed, ForceMode.VelocityChange);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
