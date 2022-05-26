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
                SceneManager.LoadScene("Level1");
                break;
            case "Button 2":
                SceneManager.LoadScene("Level2");
                break;
            case "Button 3":
                SceneManager.LoadScene("Level3");
                break;
            case "Button 4":
                SceneManager.LoadScene("Level4");
                break;
            case "Button 5":
                SceneManager.LoadScene("Level5");
                break;
            case "Button 6":
                SceneManager.LoadScene("Level6");
                break;
            case "Button 7":
                SceneManager.LoadScene("Level7");
                break;
            case "Button 8":
                SceneManager.LoadScene("Level8");
                break;
        }
    }
}