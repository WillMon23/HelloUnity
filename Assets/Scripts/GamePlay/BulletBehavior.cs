using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    private string _ownerTag;
    [SerializeField]
    private float _damage;

    [SerializeField]
    private bool _destroyOnHit;

    [SerializeField]
    private float _lifeTime;

    private bool _isAlive;
    private float _currentLifeTime;

    private Rigidbody _rigidbody;

    public string OwnerTag { get { return _ownerTag; } set { _ownerTag = value; } }

    public Rigidbody Rigidbody { get { return _rigidbody; } }

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        //Checks and compares if the tag maches the owners tag 
        if (other.CompareTag(OwnerTag))
            return;

        HealthBehavior otherHealth = other.GetComponent<HealthBehavior>();

        if (!otherHealth)
            return;
        

        otherHealth.TakeDamage(_damage);

        if (_destroyOnHit)
            Destroy(gameObject);
    }

    private void Update()
    {
        _currentLifeTime += Time.deltaTime;

        if (_currentLifeTime >= _lifeTime)
            Destroy(gameObject);
    }
}
