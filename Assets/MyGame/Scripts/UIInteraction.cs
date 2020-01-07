using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInteraction : MonoBehaviour
{
    public InputField textInput;
    public Button textButton;
    public Button countButton;
    public Text resultText;
    public Text counter;

    int countNumber = 1;


    public void countUp()
    {
        countNumber += 1;

        counter.text = countNumber.ToString();
    }

    public void CopyText()
    {
        resultText.text = textInput.text;
    }
}


