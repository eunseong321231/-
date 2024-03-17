using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void Change()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            SceneManager.LoadScene("Scene1");
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            SceneManager.LoadScene("Scene2");
        }    

    }

    void Update()
    {
        Change();
    }
}
