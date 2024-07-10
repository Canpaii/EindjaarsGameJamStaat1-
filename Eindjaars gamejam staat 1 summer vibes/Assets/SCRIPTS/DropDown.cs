using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using TMPro;
public class DropDown : MonoBehaviour
{
    public TMP_Dropdown dropdown;  // Reference to the Dropdown component
    public int selectedValue;  // Variable to store the selected value
    public ScoreCollider[] score;
    void Start()
    {
        if (dropdown != null)
        {
            dropdown.onValueChanged.AddListener(OnDropdownValueChanged);
        }
    }

    void OnDropdownValueChanged(int value)
    {
        selectedValue = value;
        Debug.Log("Selected value: " + selectedValue);

        // Here you can add any logic to handle the value change
        switch (value)
        {
            case 0:
                foreach(ScoreCollider scores in score)
                {
                    scores.scoreToWin = 5;
                }
                break;
            case 1:
                foreach(ScoreCollider scores in score)
                {
                    scores.scoreToWin = 10;
                }
                break;
            case 2:
               foreach(ScoreCollider scores in score)
                {
                    scores.scoreToWin = 15;
                }
                break;
            case 3:
                foreach(ScoreCollider scores in score)
                {
                    scores.scoreToWin = 20;
                }
                break;
            case 4:
                foreach(ScoreCollider scores in score)
                {
                    scores.infiniteScore = true;
                }
                break;          
        }
    }
}
