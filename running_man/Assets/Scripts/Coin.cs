using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed = 25f;

    // Update is called once per frame
    public void Update()
    {
        transform.Rotate(0, _rotationSpeed * Time.deltaTime, 0);
    }

    public void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<CoinManager>().addOne();
        Destroy(gameObject);
    }
}
