using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    [SerializeField] int _value;
    [SerializeField] DeformationType _deformationType;
    [SerializeField] GateApperence _gateApperence;
    
    
    private void OnValidate()
    {
        _gateApperence.Update(_value, _deformationType);
    }
}
