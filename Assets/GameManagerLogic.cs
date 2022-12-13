using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManagerLogic : MonoBehaviour
{
    public int TotalItemCount;

    public TextMeshProUGUI stageCountText;

    public TextMeshProUGUI playerCountText;


    private void Start()
    {
        GameObject[] items = GameObject.FindGameObjectsWithTag("Item");
        TotalItemCount = items.Length;
        stageCountText.text = $"/{TotalItemCount}";
    }

    public void GetItem(int count)
    {
        playerCountText.text = count.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            SceneManager.LoadScene(Global.stage);
            //DontDestroyOnLoad(this);
        }
    }

}
