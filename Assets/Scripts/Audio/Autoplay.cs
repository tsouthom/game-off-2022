using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Autoplay : MonoBehaviour
{
    public float minPeriod = 2;
    public float maxPeriod = 2;
    public float firstPlayAt = 0;
    AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        source = gameObject.GetComponent<AudioSource>();
        InvokeRepeating("PlaySound", firstPlayAt, Random.Range(minPeriod, maxPeriod));
    }

    // Update is called once per frame
    void PlaySound()
    {
        source.Play();
    }
}
