using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void PlayGame(){
        SceneManager.LoadScene("Stage 1");
    }
    public void QuitGame(){
        Application.Quit();
    }
}