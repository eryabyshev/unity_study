using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    [SerializeField] private int _numberOfCoinsInLevel = 0;

    public void addOne()
    {
        _numberOfCoinsInLevel++;
    }
}
