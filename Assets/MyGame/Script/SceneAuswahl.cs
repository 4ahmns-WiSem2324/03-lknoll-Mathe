using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneAuswahl : MonoBehaviour
{
    public void Home()
    {
        SceneManager.LoadScene(0);
    }
    public void ZahlenQuiz()
    {
        SceneManager.LoadScene(1);
    }
    public void Rechner()
    {
        SceneManager.LoadScene(2);
    }
    public void Priemzahlen()
    {
        SceneManager.LoadScene(3);
    }
    public void Teilbarkeit()
    {
        SceneManager.LoadScene(4);
    }
}
