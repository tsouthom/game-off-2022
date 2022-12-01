using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using AC;

public class VaultPuzzleCheck : MonoBehaviour
{
    public NumberSpriteChanger slot1;
    public NumberSpriteChanger slot2;
    public NumberSpriteChanger slot3;
    public NumberSpriteChanger slot4;

    public UnityEngine.UI.Button[] buttons;

    public Animator vaultAnimation;
    public AudioSource audioSource;
    // somehow set the AC "is vault open" to true

    bool puzzleDone = false;

    public bool CheckPuzzleSolved()
    {
        return slot1.currentIndex == 2 
            && slot2.currentIndex == 0
            && slot3.currentIndex == 4
            && slot4.currentIndex == 2;
    }

    private void Update() 
    {
        if (!puzzleDone && CheckPuzzleSolved())
        {
            foreach(var button in buttons)
                button.interactable = false;
                
            puzzleDone = true;
            vaultAnimation.SetBool("vaultUnlock", true);
            audioSource.Play();
            GVar myVar = GlobalVariables.GetVariable("hasOpenedVault");
            myVar.BooleanValue = true;
        }

        if (puzzleDone && !vaultAnimation.IsInTransition(0))
        {
            var menu = PlayerMenus.GetMenuWithName("Vault Puzzle");
            menu.TurnOff();
        }
    }
}
