using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using AC;

public class LoadingProgress : MonoBehaviour
{
    Slider slider;
    SceneChanger sc;
    // Start is called before the first frame update
    void Start()
    {
        sc = GameObject.Find("PersistentEngine").GetComponent<SceneChanger>();    
        slider = gameObject.GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = sc.GetLoadingProgress();
    }
}
