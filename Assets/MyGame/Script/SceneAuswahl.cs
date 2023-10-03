using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneAuswahl : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
}
