using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public enum DeformationType
{
    Width, Height
}

public class GateApperence : MonoBehaviour
{
    
    [SerializeField] TextMeshProUGUI _text;
    [SerializeField] Image _topeImage;
    [SerializeField] Image _glassImage;
    
    [SerializeField] Color _positiveColor;
    [SerializeField] Color _negativeColor;
    
    
    [SerializeField] GameObject _widthUp;
    [SerializeField] GameObject _widthDown;
    [SerializeField] GameObject _heigthUp;
    [SerializeField] GameObject _heigthDown;
    private const float Transparency = 0.5f;

    public void Update(int value, DeformationType deformationType)
    {
        setColor(value);
        setText(value);
        setIcon(value, deformationType);
    }


    void setColor(int value)
    {
        var color = value >= 0 ?  _positiveColor : _negativeColor;
        _topeImage.color = color;
        _glassImage.color = new Color(color.r, color.g, color.b, 0.8f);
    }
    
    void setText(int value)
    {
        _text.text = value.ToString();
    }
    
    void setIcon(int value, DeformationType deformationType)
    {
        _widthUp.SetActive(false);
        _widthDown.SetActive(false);
        _heigthUp.SetActive(false);
        _heigthDown.SetActive(false);
        switch (deformationType)
        {
            case DeformationType.Height:
                if(value >= 0)
                {
                    _heigthUp.SetActive(true);
                }
                else
                {
                    _heigthDown.SetActive(true);
                }
                break;
            case DeformationType.Width:
                if(value >= 0)
                {
                    _widthUp.SetActive(true);
                }
                else
                {
                    _widthDown.SetActive(true);
                }
                break;
                
        }
    }
    
    
}
 