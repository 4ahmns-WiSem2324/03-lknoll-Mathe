using TMPro;
using UnityEngine;

public class Primzahlen : MonoBehaviour
{
    public TextMeshProUGUI randomZahlText;
    int randamZahl;
    bool isPrime;


    private void Start()
    {
        randamZahl = Random.Range(0, 1001);
        randomZahlText.text = randamZahl.ToString();
    }

    public void DetectPrimes()
    {
        for (int number = 2; number <= 1000; number++)
        {
            isPrime = IsPrime(number);
            if (isPrime)
            {
                if (randamZahl == number)
                {
                    Debug.Log("richtig");
                    randamZahl = Random.Range(0, 1001);
                    randomZahlText.text = randamZahl.ToString();
                }
            }
            
        }
    }
    public void DetectKeinePrimes()
    {
        for (int number = 2; number <= 1000; number++)
        {
            isPrime = IsPrime(number);
            if (!isPrime)
            {
                if (randamZahl == number)
                {
                    Debug.Log("richtig");
                    randamZahl = Random.Range(0, 1001);
                    randomZahlText.text = randamZahl.ToString();
                }
            }
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