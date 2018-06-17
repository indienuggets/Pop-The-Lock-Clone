using UnityEngine;

public class LevelTextUI : MonoBehaviour
{
    public GameData GameData;
    TMPro.TextMeshProUGUI _text;

    void Start()
    {
        _text = GetComponent<TMPro.TextMeshProUGUI>();
        _text.text = "Level: " + GameData.CurrentLevel.ToString();
    }

    void Update()
    {
        _text.text = "Level: " + GameData.CurrentLevel.ToString();
    }
}
