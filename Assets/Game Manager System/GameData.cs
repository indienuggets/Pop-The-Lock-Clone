using UnityEngine;

[CreateAssetMenu]
public class GameData : ScriptableObject
{
    public int CurrentLevel;
    public int DotsRemaining;
    public int Stars;
    public bool IsRunning = false;
    public int MinSpawnAngle = 30;
    public int MaxSpawnAngle = 90;

    public int CurrentMotorSpeed = 60;
    public int MinMotorSpeed = 50;
    public int MaxMotorSpeed = 120;

    public void ResetLevel()
    {
        IsRunning = false;
        DotsRemaining = CurrentLevel;
    }

    public void ResetData()
    {
        CurrentLevel = 1;
        DotsRemaining = CurrentLevel;
        CurrentMotorSpeed = MinMotorSpeed;
    }

    public void IncreaseMotorSpeed(int value)
    {
        if (value > 0)
        {
            CurrentMotorSpeed = Mathf.Min(CurrentMotorSpeed + value, MaxMotorSpeed);
        }
        else
        {
            Debug.LogError("Increase speed value must be greater than 0");
        }

    }

    public void ReduceMotorSpeed(int value)
    {
        if (value > 0)
        {
            CurrentMotorSpeed = Mathf.Max(CurrentMotorSpeed - value, MinMotorSpeed);
        }
        else
        {
            Debug.LogError("Reduce speed value must be greater than 0");
        }
    }

    public void StopGame()
    {
        IsRunning = false;
    }
}
