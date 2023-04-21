using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    private int score;
    [SerializeField]
    private Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        scoreText.text = "Score: " + score;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Acorn"))
        {
            float scoreTime = Time.time;
            score += 1;
            scoreText.text = "Score: " + score;

        }
    }
}
