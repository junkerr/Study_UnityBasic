using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBall : MonoBehaviour
{

    Rigidbody rigid;

    void Start()
    {


        rigid = GetComponent<Rigidbody>();
        rigid.velocity = Vector3.left;
    }

    void FixedUpdate()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rigid.AddForce(Vector3.up * 10, ForceMode.Impulse);
        }

        Vector3 vector = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));

        rigid.AddForce(vector, ForceMode.Impulse);

        //rigid.AddTorque(Vector3.up);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Cube")
        {
            rigid.AddForce(Vector3.up * 2, ForceMode.Impulse);
        }
    }

    public void Jump()
    {

        rigid.AddForce(Vector3.up * 10, ForceMode.Impulse);

    }
}
