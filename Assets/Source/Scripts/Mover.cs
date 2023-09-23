using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;

    //[SerializeField] private float _currentTime = 0f;                 // [4]
    //[SerializeField] private float _lerpTime;                         // [4]

    //[SerializeField] private Transform _target1;                      // [1-1]
    //[SerializeField] private Vector3 _target2;                        // [1-2]

    private Vector3 _moveDirection;

    //private Vector3 _startPosition;                                   // [4]

    //private float _normalizRunningTime;                               // [4]

    private void Start()
    {
        _moveDirection = transform.forward;       // [3]


        //_startPosition = transform.position;    // [4]
    }

    void Update()
    {
        //transform.position = Vector3.MoveTowards(transform.position, _target1.position, _speed * Time.deltaTime);           // [1-1] ���� ����-�� ���������, ������ ���� (������)   !!! ����� ������� �������� (������� ������ �������� ��������)
        //transform.position = Vector3.MoveTowards(transform.position, _target2, _speed * Time.deltaTime);                    // [1-2] ���� ����-�� ���������, ������ ���� (����������� ���������� ������)


        //transform.Translate(0, 0, _speed * Time.deltaTime);                                                                 // [2] ���� ������ � ������� �� ����� ���������� ���������


        transform.position += _moveDirection * _speed * Time.deltaTime;                                                       // [3] ������ ����, ������ ����������� ������ ��������������� �������� (_targetPosition - _currentPosition).normalized
                                                                                                                              // ��� ����� �� ����������� ����������� transform.forward

        //_currentTime += Time.deltaTime;                                                                                     // [4-1] ����� ������� � ����� � ����������� �� �������� (������������ � �������� 1)
        //_normalizRunningTime = _currentTime / _lerpTime;
        //transform.position = Vector3.Lerp(_startPosition, _target2, _normalizRunningTime);
        //transform.position = Vector3.Lerp(transform.position, _target2, _normalizRunningTime);                              // [4-2] ����� ����� � ����� � ����������� �� �������� (������������ � �������� 1), �������� ������ ������ �����


        //rigidbody2D.AddForce(Vector2.up * _jumpForce, ForceMode2D.Force);                                                   // [5-1] ������
        //rigidbody3D.velocity = _speed * transform.forward;                                                                  // [5-2] ������
    }
}
