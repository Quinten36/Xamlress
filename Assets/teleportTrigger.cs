using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class teleportTrigger : MonoBehaviour
{

    // teleport naar sublevel

    // misschien een fade

    public string levelName;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(levelName);
        // SceneManager.LoadScene(levelName);
    }
}
