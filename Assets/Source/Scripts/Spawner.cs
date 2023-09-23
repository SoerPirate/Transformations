using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemyTemplate;

    private Transform _moveDirection;

    private Vector3 _spawnerPosition;
    private Vector3 _moveDirectionPosition;
    private Vector3 _enemyMoveDirection;

    private void Awake()
    {
        _moveDirection = gameObject.GetComponentInChildren<MoveDirection>().transform;

        _spawnerPosition = transform.position;
        _moveDirectionPosition = _moveDirection.position;

        _enemyMoveDirection = (_moveDirectionPosition - _spawnerPosition).normalized;
    }

    public void SpawnEnemy()
    {
        Enemy createdEnemy = Instantiate(_enemyTemplate, _spawnerPosition, Quaternion.identity);

        createdEnemy.Init(_enemyMoveDirection);
    }
}
