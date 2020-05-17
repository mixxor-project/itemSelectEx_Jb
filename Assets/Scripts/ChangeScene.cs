using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class ChangeScene : MonoBehaviour
{
    string btnName = "";
    public void CorrectButton()
    {
        //correct = true;
        SceneManager.LoadScene("CorrectScene");
    }
    public void WrongButton()
    {
        SceneManager.LoadScene("WrongScene");
    }
    void Start()
    {
        GameObject tempBtn = EventSystem.current.currentSelectedGameObject;
        if (tempBtn)
        {
            btnName = tempBtn.name;
            if (btnName.Equals("wrong"))
            {
                CorrectButton();
            }
            else if (btnName.Equals("correct"))
            {
                WrongButton();
            }
        }
        else
        {
            Debug.Log("No game object called wibble found");
        }
    }
    void Update()
    {

    }
}
