using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _speed;

    private Vector3 currentEulerAngles;
    private Vector3 rotationDirection;

    void Start()
    {
        currentEulerAngles = transform.localEulerAngles;

        rotationDirection = new Vector3(0, 1, 0);
    }

    void Update()
    {
        currentEulerAngles += rotationDirection * _speed * Time.deltaTime;

        transform.localEulerAngles = currentEulerAngles;
    }
}
