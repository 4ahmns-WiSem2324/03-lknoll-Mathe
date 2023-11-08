using TMPro;
using UnityEngine;

public class PrimeNumberDetector : MonoBehaviour
{
    public int upperLimit = 1000; 
    public TextMeshProUGUI ausgabeFeld;
    public TMP_InputField inputPrimzahl;
    int zahl1;


    void DetectPrimes()
    {
        for (int number = 2; number <= upperLimit; number++)
        {
            bool isPrime = IsPrime(number);
            if (number == zahl1)
            {
                if (isPrime)
                {
                    ausgabeFeld.text = zahl1.ToString() + " ist eine Primzahl";

                }
                else
                {
                    ausgabeFeld.text = zahl1.ToString() + " ist keine Primzahl";
                }
            }
            
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            zahl1 = int.Parse(inputPrimzahl.text);
            DetectPrimes();
        }
    }

    bool IsPrime(int num)
    {
        if (num <= 1)
        {
            return false;
        }
        if (num <= 3)
        {
            return true;
        }
        if (num % 2 == 0 || num % 3 == 0)
        {
            return false;
        }

        for (int i = 5; i * i <= num; i += 6)
        {
            if (num % i == 0 || num % (i + 2) == 0)
            {
                return false;
            }
        }
        return true;
    }
}
