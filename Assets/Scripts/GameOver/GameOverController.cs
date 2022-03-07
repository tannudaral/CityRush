using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverController : MonoBehaviour
{
    public GameObject gameOverMenu;

    public void GameOver()
    {
        gameOverMenu.SetActive(true);
    }
}
