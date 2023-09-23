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
        //transform.position = Vector3.MoveTowards(transform.position, _target1.position, _speed * Time.deltaTime);           // [1-1] идем куда-то конкретно, задаем цель (объект)   !!! можно сделать МОРКОВКУ (сделать таргет дочерним объектом)
        //transform.position = Vector3.MoveTowards(transform.position, _target2, _speed * Time.deltaTime);                    // [1-2] идем куда-то конкретно, задаем цель (прописываем координаты руками)


        //transform.Translate(0, 0, _speed * Time.deltaTime);                                                                 // [2] жмем кнопку и говорим по какой координате двигаемся


        transform.position += _moveDirection * _speed * Time.deltaTime;                                                       // [3] просто идем, задаем направление только нормализованным вектором (_targetPosition - _currentPosition).normalized
                                                                                                                              // ИЛИ одним из стандартных направлений transform.forward

        //_currentTime += Time.deltaTime;                                                                                     // [4-1] между стартом и целью в зависимости от значения (приведенного к условной 1)
        //_normalizRunningTime = _currentTime / _lerpTime;
        //transform.position = Vector3.Lerp(_startPosition, _target2, _normalizRunningTime);
        //transform.position = Vector3.Lerp(transform.position, _target2, _normalizRunningTime);                              // [4-2] между СОБОЙ и целью в зависимости от значения (приведенного к условной 1), работает рывком совсем иначе


        //rigidbody2D.AddForce(Vector2.up * _jumpForce, ForceMode2D.Force);                                                   // [5-1] Физика
        //rigidbody3D.velocity = _speed * transform.forward;                                                                  // [5-2] Физика
    }
}
