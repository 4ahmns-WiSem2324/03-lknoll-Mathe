using System;
using TMPro;
using UnityEngine;

public class EinfachesRechenen : MonoBehaviour
{
    float zahl1;
    float zahl2;
    public TMP_InputField zahl1Input;
    public TMP_InputField zahl2Input;
    public TextMeshProUGUI ergebnisAnzeige;


    public void PlusRechnen()
    {
        zahl1 = float.Parse(zahl1Input.text);
        zahl2 = float.Parse(zahl2Input.text); 
        float ergebnisPlus = zahl1 + zahl2;
        ergebnisAnzeige.text = ergebnisPlus.ToString();
    }
    public void MalRechnen()
    {
        zahl1 = float.Parse(zahl1Input.text);
        zahl2 = float.Parse(zahl2Input.text); 
        float ergebnisPlus = zahl1 * zahl2;
        ergebnisAnzeige.text = ergebnisPlus.ToString();
    }
    public void MinusRechnen()
    {
        zahl1 = float.Parse(zahl1Input.text);
        zahl2 = float.Parse(zahl2Input.text); 
        float ergebnisPlus = zahl1 - zahl2;
        ergebnisAnzeige.text = ergebnisPlus.ToString();
    }
    public void DurchRechnen()
    {
        zahl1 = float.Parse(zahl1Input.text);
        zahl2 = float.Parse(zahl2Input.text); 
        float ergebnisPlus = zahl1 / zahl2;
        ergebnisAnzeige.text = ergebnisPlus.ToString();
    }
}
