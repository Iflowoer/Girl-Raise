using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
    public void GotoGame()
    {
        SceneManager.LoadScene("gamescene");
    }

    /*public void SceneChange2()
    {
        SceneManager.LoadScene("Start");
    }*/

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
