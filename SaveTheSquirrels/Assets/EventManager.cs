using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EventManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int maxDistance = 500;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //clicking on join switches scenes to different minigames that corresponds to different event IDs
    public void ActivateEvent(int eventID)
    {
        if (eventID == 1) //Doe Library & Maze Game
        {
            Debug.Log("Loading Maze Game");
            SceneManager.LoadScene("EnterMaze");
        } else if (eventID == 2) //Cal Memorial Stadium & Basketball Game
        {
            Debug.Log("Loading Basketball Game");
            SceneManager.LoadScene("EnterBasketball");

        } else if (eventID == 3) //Campanile & Car Race Game
        {
            Debug.Log("Loading Car Race Game");
            SceneManager.LoadScene("EnterCar");
        } else if (eventID == 4) //Jacobs Hall & Shooting Game
        {
            SceneManager.LoadScene("EnterShoot");
        }
    }


}
