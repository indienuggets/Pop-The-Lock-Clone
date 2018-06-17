using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameData GameData;
    bool _isFirstTap = true;

    void Start()
    {
        GameData.ResetLevel();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !GameData.IsRunning && _isFirstTap)
        {
            GameData.IsRunning = true;
            _isFirstTap = false;
        }
    }

    public void LoadLevel()
    {
        GameData.ResetLevel();
        _isFirstTap = true;
    }


}
