using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchAcorn : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        var squirrel = other.GetComponent<PlayerTouchMovement>();
        if (squirrel != null)
        {
            ScoreManager.instance.AddPoint();
            Destroy(this.gameObject);
        }
    }
}
