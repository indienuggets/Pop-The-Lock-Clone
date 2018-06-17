using UnityEngine;

public class RemainingDotsTextUI : MonoBehaviour
{
    public GameData GameData;
    TMPro.TextMeshPro _text;

    void Start()
    {
        _text = GetComponent<TMPro.TextMeshPro>();
        _text.text = GameData.DotsRemaining.ToString();
    }

    void Update()
    {
        _text.text = GameData.DotsRemaining.ToString();
    }
}
