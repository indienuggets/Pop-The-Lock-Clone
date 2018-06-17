using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotDetector : MonoBehaviour
{
    GameObject _currentDot;
    GameObject _lastEnteredDot;
    public GameData GameData;
    public float LoseThreshold = .5f;
    public GameEvent OnDotMissed;
    public GameEvent OnDotScored;
    public GameEvent OnWinEvent;

    void OnTriggerEnter2D(Collider2D other)
    {
        _currentDot = other.gameObject;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        _lastEnteredDot = _currentDot;
        _currentDot = null;
        Debug.Log("Last dot set");
    }

    void Update()
    {
        if (GameData.IsRunning)
        {
            //Find distance b/w last dot and current pos. And if it's higher than some threshold then raise DotMissed Event
            if (_lastEnteredDot && GetDistanceFromLastDot() > LoseThreshold)
            {
                OnDotMissed.Raise();
            }



            if (_didTap)
            {
                if (_currentDot != null)
                {
                    if (_currentDot.GetComponent<Star>())
                    {
                        GameData.Stars++;
                    }
                    Destroy(_currentDot);
                    GameData.DotsRemaining--;

                    if (GameData.DotsRemaining <= 0)
                    {
                        GameData.DotsRemaining = 0;
                        GameData.CurrentLevel++;
                        OnWinEvent.Raise();
                    }
                    else
                    {
                        OnDotScored.Raise();
                    }
                }
                else
                {
                    OnDotMissed.Raise();
                }
            }
        }


    }

    float GetDistanceFromLastDot()
    {
        Debug.Log((transform.position - _lastEnteredDot.transform.position).magnitude);
        return (transform.position - _lastEnteredDot.transform.position).magnitude;
    }


    bool _didTap
    {
        get
        {
            return Input.GetMouseButtonDown(0);
        }
    }
}
