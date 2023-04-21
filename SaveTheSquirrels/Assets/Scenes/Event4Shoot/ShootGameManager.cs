using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShootGameManager : MonoBehaviour
{
    public Animator transition;
    public void StartGame()
    {
        StartCoroutine(MakeTransition("ShootingGame", 1.5f, 0f));
    }
    public void WinGame()
    {
        StartCoroutine(MakeTransition("WinScene", 2f, 2f));
    }
    public void LoseGame()
    {
        StartCoroutine(MakeTransition("LoseScene", 2f, 2f));
    }
    public void Quit()
    {
        StartCoroutine(MakeTransition("Map", 2f, 0f));
        Debug.Log("Player has quit game");
    }
    IEnumerator MakeTransition(string sceneName, float transitionTime, float transitionDelay)
    {
        yield return new WaitForSeconds(transitionDelay);
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(sceneName);
    }
}