using UnityEngine;

public class HintTextUI : MonoBehaviour
{
    public GameData GameData;

    void Update()
    {
        if (GameData.CurrentLevel != 1) { gameObject.SetActive(false); }
    }
}
