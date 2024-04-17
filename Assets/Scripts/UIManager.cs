using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoSingleton<UIManager>
{
    private const string _arenaSportsBoard = "ArenaSportsBoard";
    private const string _beachBall = "BeachBall";

    [SerializeField]
    TMP_Text _basketballText;
    int _basketballScore = 0;

    private void Start()
    {
        _basketballText.text = _basketballScore.ToString("00");
    }

    public void UpdateBasketballScore(Collider other)
    {
        if (other.CompareTag(_arenaSportsBoard))
        {
            _basketballScore = 0;
        }
        else if (other.CompareTag(_beachBall))
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
