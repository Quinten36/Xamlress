using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class timer : MonoBehaviour
{

    private float time;

    public float overleven;
    public TextMeshProUGUI timeUI;

    // Start is called before the first frame update
    void Start()
    {
        time = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (time > overleven) return;
        float timeleft = Mathf.Round(overleven - time);

        timeUI.text = "Time left: " + timeleft;

        time += 0.1f;
    }
}
