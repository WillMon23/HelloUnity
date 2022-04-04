using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerBehavior : MonoBehaviour
{
    [SerializeField]
    EnemyMovementBehavior _enemy; 
    [SerializeField]
    private Transform _enemyTarget;

    [SerializeField]
    private float _spawnTimer = 5.0f;
    private float _timer = 0.0f;
    
    public EnemyMovementBehavior Enemy { get { return _enemy; } set { _enemy = value; } }
    public Transform EnemyTarget { get { return _enemyTarget; } set { _enemyTarget = value; } }

    private void Update()
    {
        if (_timer > _spawnTimer)
        {
            EnemyMovementBehavior spawnedEnemy = Instantiate(Enemy, transform.position, transform.rotation);
            spawnedEnemy.Target = EnemyTarget;
            _timer = 0;
        }
        _timer += Time.deltaTime;
    }

}
