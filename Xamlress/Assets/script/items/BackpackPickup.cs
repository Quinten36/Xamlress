using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackpackPickup : MonoBehaviour
{
    public ParticleSystem glow;
    private bool firstTime;

    // Start is called before the first frame update
    void Start()
    {
        glow.Stop();
        firstTime = false;
    }

    public void glowStart()
    {
        if (firstTime == false) {
            firstTime = true;
            glow.Play();
        }
    }

    public void pickupBackpack()
    {
        PlayerPrefs.SetString("items", "Backpack");
        Debug.Log("opgepakt");
    }
}
