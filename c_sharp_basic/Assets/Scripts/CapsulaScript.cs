using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsulaScript : MonoBehaviour
{

    [SerializeField] private float _height;
    [SerializeField] private int _numberOfCoins;
    [SerializeField] private string _name;
    [SerializeField] private Color _bodyColor;
    [SerializeField] private Vector3 _startPosition;
    [SerializeField] private bool _isAlive = true;

    [SerializeField] private Light _sun;

    const float MAX_SUN_INTENSITY = 10f;

    private bool _positiveSuIntensity = true;


    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector3(1, _height, 1);
        gameObject.name = _name;
        gameObject.GetComponent<Renderer>().material.color = _bodyColor;
        transform.position = _startPosition;
        gameObject.SetActive(_isAlive);
        _sun.intensity = 0;
        

    }

    // Update is called once per frame
    void Update()
    {

        if(_positiveSuIntensity)
        {
            _sun.intensity += 0.1f;
        }
        else
        {
            _sun.intensity -= 0.1f;
        }
        if(_sun.intensity > MAX_SUN_INTENSITY)
        {
            _positiveSuIntensity = false;
        }
        if(_sun.intensity <= 0)
        {
            _positiveSuIntensity = true;
        }
    }
}
