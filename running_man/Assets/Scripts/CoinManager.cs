using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    [SerializeField] private int _numberOfCoinsInLevel = 0;
    [SerializeField] private TextMeshProUGUI _numberOfCoinsView;

    public void addOne()
    {
        _numberOfCoinsInLevel++;
        _numberOfCoinsView.text = _numberOfCoinsInLevel.ToString();
    }
}
