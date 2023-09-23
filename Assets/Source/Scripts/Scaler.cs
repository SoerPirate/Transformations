using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Vector3 _initialScale;

    void Start()
    {
        _initialScale = transform.localScale;
    }

    void Update()
    {
        transform.localScale += _initialScale * _speed * Time.deltaTime;
    }
}
