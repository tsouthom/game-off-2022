using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  Febucci.UI;

public class Updater : MonoBehaviour
{
    TextAnimator textAnimator;
    // Start is called before the first frame update
    void Start()
    {
        textAnimator = gameObject.GetComponent<TextAnimator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        textAnimator.UpdateEffects();
        textAnimator.ForceMeshRefresh();
    }
}
