using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public void selectScene()
    {
        switch (this.gameObject.name)
        {
            case "Button 1":
                SceneManager.LoadScene("Hazal level 3");
                break;
            case "Button 2":
                SceneManager.LoadScene("Hazal level 3");
                break;
            case "Button 3":
                SceneManager.LoadScene("Hazal level 3");
                break;
            case "Button 4":
                SceneManager.LoadScene("Hazal level 3");
                break;
            case "Button 5":
                SceneManager.LoadScene("Hazal level 3");
                break;
            case "Button 6":
                SceneManager.LoadScene("Hazal level 3");
                break;
            case "Button 7":
                SceneManager.LoadScene("Hazal level 3");
                break;
            case "Button 8":
                SceneManager.LoadScene("Hazal level 3");
                break;
        }
    }
}