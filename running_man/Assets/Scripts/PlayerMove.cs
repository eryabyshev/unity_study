using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    [SerializeField] private float _speed = 3.0f;
    [SerializeField] private GameObject _road;
    [SerializeField] private Animator _animator;
    
    private float _oldMousePositionX;
    private float _eulerY;
    
    private const float MAX_EULER_Y = 70;
    private const string RUN_TRIGGER_ANIMATION_NAME = "Run";
    
    
    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _oldMousePositionX = Input.mousePosition.x;
        }
        
        
        if (Input.GetMouseButton(0))
        {
            
            _animator.SetBool(RUN_TRIGGER_ANIMATION_NAME, true);
            
            var newPosition = transform.position + transform.forward * (Time.deltaTime * _speed);
            newPosition.x = getMaxXPosition(newPosition.x);
            transform.position = newPosition;
            
            var deltaX = Input.mousePosition.x - _oldMousePositionX;
            _oldMousePositionX = Input.mousePosition.x;
            
            _eulerY += deltaX;
            _eulerY = Mathf.Clamp(_eulerY, MAX_EULER_Y * -1, MAX_EULER_Y);
            transform.eulerAngles = new Vector3(0, _eulerY, 0);
        }

        if (Input.GetMouseButtonUp(0))
        {
            _animator.SetBool(RUN_TRIGGER_ANIMATION_NAME, false);
        }
    }

    private float getMaxXPosition(float newXPosition)
    { 
        var maxX = (_road.transform.localScale.x / 2) - 0.2f;
        return Mathf.Clamp(newXPosition, -maxX, maxX);
    }
}
