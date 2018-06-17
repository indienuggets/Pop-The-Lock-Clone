using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarTextUI : MonoBehaviour
{

    public GameData GameData;
    TMPro.TextMeshProUGUI _text;

    void Start()
    {
        _text = GetComponent<TMPro.TextMeshProUGUI>();
        _text.text = "Star: " + GameData.Stars.ToString();
    }

    void Update()
    {
        _text.text = "Star: " + GameData.Stars.ToString();
    }
}
