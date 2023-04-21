using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootScript : MonoBehaviour
{
    public GameObject arCamera;
    public Text ammoText;
    public string startingAmmo = (SpawnScript.numSquirrels * 3).ToString();
    public int ammo = SpawnScript.numSquirrels * 3;
    private bool canShoot = true;

    public void Start()
    {
        ammoText.text = (ammo.ToString() + "/" + startingAmmo);
    }

    public void Shoot()
    {
        if (canShoot)
        {
            ammo--;
            if (ammo < 10)
            {
                ammoText.text = ("0" + ammo.ToString() + "/" + startingAmmo);
            } else
            {
                ammoText.text = (ammo.ToString() + "/" + startingAmmo);
            }
            RaycastHit hit;
            FindObjectOfType<AudioManager>().Play("FireSound");
            if (Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out hit))
            {
                if (hit.transform.name == "Squirrel(Clone)")
                {
                    Destroy(hit.transform.gameObject);
                    ScoreManager.instance.AddPoint();
                    if (ScoreManager.instance.remaining == 0)
                    {
                        FindObjectOfType<AudioManager>().Play("WinSound");
                        FindObjectOfType<ShootGameManager>().WinGame();
                        canShoot = false;
                    }
                    else
                    {
                        FindObjectOfType<AudioManager>().Play("KillSound");
                    }
                }
            }
            if (ammo == 0)
            {
                canShoot = false;
                FindObjectOfType<ShootGameManager>().LoseGame();
            }
        }
        else
        {
            FindObjectOfType<AudioManager>().Play("DryFire");
        }
    }
}