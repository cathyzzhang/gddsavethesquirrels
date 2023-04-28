using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Controller : MonoBehaviour
{
    private Rigidbody player;
    public bool isFlat;
    public int acornsLeft;
    public float movespeed;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody>();
    } 

    // Update is called once per frame
    void Update()
    {
        Vector3 tilt = Input.acceleration;

        if (isFlat)
        {
            tilt = Quaternion.Euler(90, 0, 0) * -tilt;
        }

        player.AddForce(tilt * movespeed);

    }

    public int acorns()
    {
        return acornsLeft;
    }

    public void updateAcornsAmount(int amount)
    {
        acornsLeft += amount;
        GameObject text = GameObject.FindGameObjectWithTag("Text");
        AcornsCounter acornsCount = text.GetComponent<AcornsCounter>();
        acornsCount.updateAcornsAmount();
    }

}
