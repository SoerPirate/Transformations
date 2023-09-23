using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Vector3 _moveDirection;

    private void Start()
    {
        _moveDirection = transform.forward;
    }

    void Update()
    {
        transform.position += _moveDirection * _speed * Time.deltaTime;
    }
}
