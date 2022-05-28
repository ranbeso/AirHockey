using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class button : MonoBehaviour
{
    public void buttonSettings()
    {
        SceneManager.LoadScene(1);

    }

    public void buttonSettingsOut()
    {
        SceneManager.LoadScene(0);
    }
    public void buttonSettingsTrue()
    {
        SceneManager.LoadScene(2);

    }
    public void buttonSettingsOutTrue()
    {
        SceneManager.LoadScene(0);
    }
    public void button1Player()
    {
        SceneManager.LoadScene(3);

    }
    public void button1Playerend()
    {
        SceneManager.LoadScene(0);

    }




    public void button2Player()
    {
        SceneManager.LoadScene(4);

    }
    public void button2Playerend()
    {
        SceneManager.LoadScene(0);

    }
}
