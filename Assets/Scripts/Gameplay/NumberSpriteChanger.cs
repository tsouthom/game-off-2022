using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberSpriteChanger : MonoBehaviour
{
    public Image img;
    public Sprite[] sprites;
    public int currentIndex;

    void Start()
    {
        currentIndex = 0;
    }

    public void incrementSprite()
    {
        if(currentIndex >= 8)
            currentIndex = 0;
        else
            currentIndex++;
        
        if (currentIndex >= 0 && currentIndex <= 8)
            img.sprite = sprites[currentIndex];
    }

    public void decrementSprite()
    {
        if(currentIndex <= 0)
            currentIndex = 8;
        else
            currentIndex--;

        if (currentIndex >= 0 && currentIndex <= 8)
            img.sprite = sprites[currentIndex];
    }
}
