using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject CanvasGame;
    public GameObject CanvasRestart;

    public GameObject Win1Txt;
    public GameObject Win2Txt;

    public ScoreScript scoreScript;

    public PuckScript puckScript;
    public Movement movement;
    public Movement2Player movement2Player;

    public Ai ai;

    public void ShowRestartCanvas(bool didWin)
    {
        Time.timeScale = 0;
        CanvasGame.SetActive(false);
        CanvasRestart.SetActive(true);

        if (didWin)
        {
            Win1Txt.SetActive(false);
            Win2Txt.SetActive(true);

        }
        else
        {
            Win1Txt.SetActive(true);
            Win2Txt.SetActive(false);
        }
    }
    
    public void RestartGame()
    {
        Time.timeScale = 1;

        CanvasGame.SetActive(true);
        CanvasRestart.SetActive(false);

        scoreScript.ResetScores();
        puckScript.CenterPuck();
        movement.ResetPosition();
        movement2Player.ResetPosition();
        ai.ResetPosition();

    }

    public void ShowMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

  
}
