using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AC;

public class CombinationCalculator : MonoBehaviour
{
    static Dictionary<int, string> results = 
        new()
        {
            {111, "Danish Subplot from 1899"},
            {112, "Star Wars"},
            {113, "LOTR"},
            {121, "Dune"},
            {122, "Chicken Run"},
            {123, "Revolution"},
            {131, "Grapes of Wrath"},
            {132, "Interstellar"},
            {133, "Home on the Range"},
            {211, "Harry Potter"},
            {212, "Dead Poets Society"},
            {213, "Spiderman"},
            {221, "The Imitation Game"},
            {222, "Matilda"},
            {223, "A Beautiful Mind"},
            {231, "Slumdog Millionaire"},
            {232, "Code Geass"},
            {233, "The Aetheriad Series"},
            {311, "Johnny English"},
            {312, "Mr and Mrs Smith"},
            {313, "James Bond"},
            {321, "Kingsman"},
            {322, "Indiana Jones and the Kingdom of the Crystal Skull"},
            {323, "Tinker Tailor Soldier Spy"},
            {331, "Get Smart"},
            {332, "Spy x Family"},
            {333, "Mission: Impossible"}
        };
    public static void PostCalculatedString()
    {
        GVar protagonist = GlobalVariables.GetVariable("protagonist");
        GVar goal = GlobalVariables.GetVariable("goal");
        GVar obstacle = GlobalVariables.GetVariable("obstacle");
        
        int key = protagonist.IntegerValue * 100 + goal.IntegerValue * 10 + obstacle.IntegerValue;
        GlobalVariables.SetStringValue(9, results[key]);
    }
}
