using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class tutorialAudio : MonoBehaviour
{

    AudioSource audioData;

    private void Awake()
    {
        GameObject playerMovement = GameObject.Find("player");
        PlayerMovement playerScript = playerMovement.GetComponent<PlayerMovement>();
        playerScript.doMovement = false;
        StartCoroutine(AudioStart());
    }
    

    IEnumerator AudioStart()
    {
        // start audio
        audioData = GetComponent<AudioSource>();
        audioData.Play(0);
        Debug.Log("started");

        yield return new WaitForSeconds(5);

        audioData.Stop();

        GameObject playerMovement = GameObject.Find("player");
        PlayerMovement playerScript = playerMovement.GetComponent<PlayerMovement>();
        playerScript.doMovement = true;
    }

}
