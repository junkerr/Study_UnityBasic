using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBall : MonoBehaviour
{
    Rigidbody rigid;
    AudioSource audio;

    public GameManagerLogic manager;

    private const int RIGD_MASS = 5;
    private bool isJump;

    public float jumpPower = 30;

    public int itemCount = 0;

    void Awake()
    {
        isJump = false;
        rigid = GetComponent<Rigidbody>();
        rigid.mass = RIGD_MASS;

        audio = GetComponent<AudioSource>();

    }

    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        rigid.AddForce(new Vector3(h, 0, v), ForceMode.Impulse);
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump") && !isJump)
        {
            rigid.AddForce(new Vector3(0, jumpPower, 0), ForceMode.Impulse);
            isJump = true;
        }
    }

    void LateUpdate()
    {
        if (gameObject.transform.position.y <= -20)
        {
            //Restart
            SceneManager.LoadScene(Global.stage);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            isJump = false;
        }


    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Item")
        {
            audio.Play();
            itemCount++;
            other.gameObject.SetActive(false);
            manager.GetItem(itemCount);
        }
        else if (other.tag == "Finish")
        {
            if (manager.TotalItemCount <= itemCount)
            {
                // GameClear
                ;
                SceneManager.LoadScene(++Global.stage);
                //DontDestroyOnLoad(manager);
            }
            else
            {
                // Restart
                SceneManager.LoadScene(Global.stage);
                //DontDestroyOnLoad(manager);
            }
        }
    }

}
