using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickup : MonoBehaviour
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
        if (firstTime == false)
        {
            firstTime = true;
            glow.Play();
        }
    }

    public void pickupKey()
    {
        PlayerPrefs.SetString("Keys", "RedKey");
        Debug.Log("opgepakt");
    }
}
