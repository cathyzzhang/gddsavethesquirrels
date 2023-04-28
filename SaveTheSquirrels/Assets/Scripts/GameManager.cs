using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance = null;

    #region Unity_functions
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    #endregion

    #region Scence_transitions

    public void StartGame()
    {
        SceneManager.LoadScene("CarMainGame");
    }

    public void LoseGame()
    {
        SceneManager.LoadScene("CarLoseScene");
        MusicScript.instance.GetComponent<AudioSource>().Stop();
    }

    public void WinGame()
    {
        SceneManager.LoadScene("CarWinScene");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("EnterCar");
        MusicScript.instance.GetComponent<AudioSource>().Play();
    }

    #endregion
}