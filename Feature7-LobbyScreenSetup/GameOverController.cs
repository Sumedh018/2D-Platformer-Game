using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverController : MonoBehaviour
{
    public Button buttonRestart;

    private void Awake()
    {
        buttonRestart.onClick.AddListener(ReloadLevel);
    }
    public void playerDie()
    {
        gameObject.SetActive(true);
    }

    private void ReloadLevel()
    {
        SceneManager.LoadScene(1);
    }

}
