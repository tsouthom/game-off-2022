using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AC;

public class CloseVaultMenu : MonoBehaviour
{
    public void CloseMenu()
    {
        var menu = PlayerMenus.GetMenuWithName("Vault Puzzle");
        menu.TurnOff();
    }
}
