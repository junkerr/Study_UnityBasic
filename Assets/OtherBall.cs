using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherBall : MonoBehaviour
{
    MeshRenderer mesh;
    Material mat;

    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;
    }

    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "MyBall")
        {
            mat.color = Color.red;
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        //if (collision.gameObject.name != "MyBall")
        //{
        //    mat.color = Color.blue;
        //}
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "MyBall")
        {
            mat.color = Color.grey;
        }
    }

}
