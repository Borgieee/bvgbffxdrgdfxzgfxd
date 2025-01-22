using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Unity.VisualScripting;

public class Conversionofunits : MonoBehaviour
{
    public float PHP;
    public float Dollars;
    public float Yen;
    public float Won;
    public float Rupees;
    public float BTC;

    public TMP_InputField inputField; 
    public TextMeshProUGUI convertedValue;


    public void toDollars()
    {
        string inputValue = inputField.text;
        float numericValue;
        if (float.TryParse(inputValue, out numericValue))
        {
            Debug.Log(numericValue);
            PHP = numericValue * Dollars;
            convertedValue.text = "₱" + PHP.ToString();
        }
        else
        {
            Debug.Log("InvalidConnection Input");
        }
    }

    public void toYen()
    {
        string inputValue = inputField.text;
        float numericValue;
        if (float.TryParse(inputValue, out numericValue))
        {
            Debug.Log(numericValue);
            PHP = numericValue * Yen;
            convertedValue.text = "₱" + PHP.ToString();
        }
        else
        {
            Debug.Log("InvalidConnection Input");
        }
    }

    public void toWon()
    {
        string inputValue = inputField.text;
        float numericValue;
        if (float.TryParse(inputValue, out numericValue))
        {
            Debug.Log(numericValue);
            PHP = numericValue * Won;
            convertedValue.text = "₱" + PHP.ToString();
        }
        else
        {
            Debug.Log("InvalidConnection Input");
        }
    }

    public void toRupees()
    {
        string inputValue = inputField.text;
        float numericValue;
        if (float.TryParse(inputValue, out numericValue))
        {
            Debug.Log(numericValue);
            PHP = numericValue * Rupees;
            convertedValue.text = "₱" + PHP.ToString();
        }
        else
        {
            Debug.Log("InvalidConnection Input");
        }
    }

    public void toBTC()
    {
        string inputValue = inputField.text;
        float numericValue;
        if (float.TryParse(inputValue, out numericValue))
        {
            Debug.Log(numericValue);
            PHP = numericValue * BTC;
            convertedValue.text = "₱" + PHP.ToString();         
        }
        else
        {
            Debug.Log("InvalidConnection Input");
        }
    }
}

    
