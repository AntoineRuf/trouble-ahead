using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class EventForScoreBoard : MonoBehaviour
{
    
    public string aButton;
    public string bButton;
    

    void Update()
    {
        if (Input.GetButton(aButton))
        {

            SceneManager.LoadScene("Release");

        }
        if (Input.GetButton(bButton))
        {
            SceneManager.LoadScene("Main Menu");
        }
    }
}