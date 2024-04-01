using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //makes script acknowledge UI stuff
using TMPro; //makes sure TextMesh Pro that's imported earlier will work 

public class UIScript : MonoBehaviour
{
    //public TMP_Text displayText;
    private TMP_Text textMeshPro;
    private Button yesButton;
    private Button noButton;

    public void start()
    {
        textMeshPro = transform.Find("QuestionDialogUI").GetComponent<TextMeshProUGUI>();
        yesButton = transform.Find("yesButton").GetComponent<Button>();
        noButton = transform.Find("noButton").GetComponent<Button>();

        ShowQuestion("Do you want to do this?", () => 
        {
            Debug.Log("Yes");
        }, () => 
        {
            Debug.Log("No");
        });
    }

    public void ShowQuestion(string questionText, Action yesAction, Action noAction)
    {
        textMeshPro.text = questionText;
        yesButton.onClick.AddListener(new UnityEngine.Events.UnityAction(yesAction));
        noButton.onClick.AddListener(new UnityEngine.Events.UnityAction(noAction));
    }

    // public void OnButtonClick()
    // {
    //     displayText.text = "Button Clicked!";
    // }
}
