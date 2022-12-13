using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    Vector3 target = new Vector3(4.38f, 1.69f, 0);

    private void Start()
    {
        //transform.Translate(new Vector3(0, 0, 0)); ;
    }

    void Update()
    {

        //Vector3 vec = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
        //transform.Translate(vec); ;


        // 1.MoveTowards
        transform.position = Vector3.MoveTowards(transform.position, target, 0.5f);



        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    transform.Translate(new Vector3(transform.position.x, ))
        //}

        //if (Input.GetKey(KeyCode.LeftArrow))
        //{

        //}

        //if (Input.GetKey(KeyCode.DownArrow))
        //{

        //}

        //if (Input.GetKey(KeyCode.UpArrow))
        //{

        //}

    }
}
