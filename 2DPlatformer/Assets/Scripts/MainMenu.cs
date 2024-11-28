using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Canvas main;
    public Canvas load;

    // Start is called before the first frame update
    void Start()
    {
        main.enabled = true;
        load.enabled = false;
    }

    public void OnPlay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void OnLoad()
    {
        main.enabled = false;
        load.enabled = true;
    }
    public void OnQuit()
    {
        Application.Quit();
    }
    public void OnBackToMain()
    {
        main.enabled = true;
        load.enabled = false;
    }
}
