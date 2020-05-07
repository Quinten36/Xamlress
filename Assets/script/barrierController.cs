using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrierController : MonoBehaviour
{

    public GameObject barrier;
    public GameObject ParticleBarrier;
    public GameObject barrierLock;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Checker());
    }

    private IEnumerator Checker()
    {
        yield return new WaitForSeconds(3.0f);
        KeyCheck();
        Debug.Log("check");
    }

    public void KeyCheck()
    {
        string info = PlayerPrefs.GetString("Keys");

        Debug.Log(info);

        if (info == "RedKey")
        {
            Destroy(barrier);
            Destroy(ParticleBarrier);
            Destroy(barrierLock);
            Debug.Log("down");
        }
    }
}
