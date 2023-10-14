using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameStart : MonoBehaviour
{
    [SerializeField] private GameObject LevelSelection;
    [SerializeField] private Button buttonPlay;

    private void Awake()
    {
        buttonPlay.onClick.AddListener(PlayGame);
    }

    private void PlayGame()
    {
        LevelSelection.SetActive(true);
        SceneManager.LoadScene(1);
        SceneManager.LoadScene(2);
        SceneManager.LoadScene(3);
        SceneManager.LoadScene(4);
    }
}
