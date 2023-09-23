using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _lifeTime;

    private Vector3 _moveDirection;

    private void Start()
    {
        StartCoroutine(DestroyThroughTime(_lifeTime));
    }

    private void Update()
    {
        transform.position += _moveDirection * _speed * Time.deltaTime;
    }

    public void Init(Vector3 moveDirection)
    {
        _moveDirection = moveDirection;
    }

    private IEnumerator DestroyThroughTime(float lifeTime)
    {
        yield return new WaitForSeconds(lifeTime);

        Destroy(gameObject);
    }
}
