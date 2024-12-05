using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreen : MonoBehaviour
{
    public void OnBackToMain()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void OnPlay()
    {
        SceneManager.LoadScene(1);
    }
}
