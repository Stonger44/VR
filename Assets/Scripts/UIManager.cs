using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoSingleton<UIManager>
{
    [SerializeField]
    TMP_Text _basketballText;
    int _basketballScore = 0;

    private void Start()
    {
        _basketballText.text = _basketballScore.ToString("00");
    }

    public void AddBasketballScore(string name)
    {
        if (name.Contains("Beach"))
        {
            _basketballScore += 5;
        }
        else
        {
            _basketballScore++;
        }
        _basketballText.text = _basketballScore.ToString("00");
    }
}
