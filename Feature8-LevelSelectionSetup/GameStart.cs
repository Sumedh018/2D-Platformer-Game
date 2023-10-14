using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameStart : MonoBehaviour
{
    public Button buttonPlay;


    private void Awake()
    {
        buttonPlay.onClick.AddListener(Level1);
        //buttonPlay.onClick.AddListener(Level2);
        //buttonPlay.onClick.AddListener(Level3);
      //  buttonPlay.onClick.AddListener(Level4);
    }

    private void Level1()
    {
        SceneManager.LoadScene(1);

    }
}
