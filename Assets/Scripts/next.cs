using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class next : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Next()
    {
        SceneManager.LoadScene("SampleScene 1");
    }

    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void NextStep()
    {
        SceneManager.LoadScene("SampleScene 3");
    }

    public void LetHimCook()
    {
        SceneManager.LoadScene("SampleScene 2");
    }

    public void First()
    {
        SceneManager.LoadScene("Start");
    }

    public void Last()
    {
        SceneManager.LoadScene("SampleScene 4");
    }
}
