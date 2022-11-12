using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMainMenu : MonoBehaviour
{
    GameObject music;
    // Start is called before the first frame update
    void Start()
    {
        music = GameObject.Find("_Music");
        music?.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.timeSinceLevelLoad > 32)
        {
            music?.SetActive(true);
            SceneManager.LoadScene(0);
        }
    }
}
