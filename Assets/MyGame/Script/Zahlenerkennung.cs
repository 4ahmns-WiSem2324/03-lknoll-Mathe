using TMPro;
using UnityEngine;

public class Zahlenerkennung : MonoBehaviour
{
    public TMP_InputField inputZahl;
    public TextMeshProUGUI ausgabeText;
    float inputZahlfloat;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            inputZahlfloat = float.Parse(inputZahl.text);  
        }
        if (inputZahlfloat % 1 == 0)
        {
            ausgabeText.text = "... ist eine Ganze Zahl";
            if (inputZahlfloat >= 0)
            {
                ausgabeText.text = "... ist eine Natürliche Zahl";
            }
        }
        else
        {
            ausgabeText.text = "... ist eine Gleitkommazahl";
        }
    }
}
