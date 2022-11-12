using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fader : MonoBehaviour
{
    public AudioSource audioSource;
    public Image panel;
    public float step = 0.05f;

    void Awake()
    {
        panel.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (panel.color.a > 0)
            panel.color = new Color(panel.color.r, panel.color.g, panel.color.b, panel.color.a - step);
        else
            gameObject.SetActive(false);
        // else if (!audioSource.isPlaying)
            // audioSource.Play();
    }
}
