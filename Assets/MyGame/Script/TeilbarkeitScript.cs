using TMPro;
using UnityEngine;

public class TeilbarkeitScript : MonoBehaviour
{
    int digit;
    int inputNumber;
    int durch3Teilbar;
    public TMP_InputField inputFieldTeilbarkeit;
    public GameObject[] arrayNummernObj;

    void Start()
    {
        OutputSingleDigits();
    }

    void OutputSingleDigits()
    {
        string numString = inputNumber.ToString(); 
        for (int i = 0; i < numString.Length; i++)
        {
            digit = int.Parse(numString[i].ToString()); 
            durch3Teilbar = durch3Teilbar + digit;
        }


    }
    private void Update()
    {
        inputNumber = int.Parse(inputFieldTeilbarkeit.text);
        string numString = inputNumber.ToString();
        if (Input.GetKeyDown(KeyCode.Return))
        {
            durch3Teilbar = 0;
            for (int i = 0; i < arrayNummernObj.Length; i++)
            {
                arrayNummernObj[i].SetActive(false);
                
            }
            for (int a = 0; a < numString.Length; a++)
            {
                digit = int.Parse(numString[a].ToString()); 
                durch3Teilbar = durch3Teilbar + digit;
            }

        }
        if (int.Parse(numString[numString.Length - 1].ToString()) == 2 || int.Parse(numString[numString.Length - 1].ToString()) == 4 || int.Parse(numString[numString.Length - 1].ToString()) == 6 || int.Parse(numString[numString.Length - 1].ToString()) == 8 || int.Parse(numString[numString.Length - 1].ToString()) == 0 && inputNumber != 0)
        {
            arrayNummernObj[0].SetActive(true);
        }

        
        if (durch3Teilbar % 3 == 0)
        {
            arrayNummernObj[1].SetActive(true);

        }
        if (int.Parse(numString[numString.Length - 1].ToString()) == 5 || int.Parse(numString[numString.Length - 1].ToString()) == 0 && inputNumber != 0)
        {
            arrayNummernObj[2].SetActive(true);

        }
        if (durch3Teilbar % 9 == 0)
        {
            arrayNummernObj[4].SetActive(true);
        }
    }
}
