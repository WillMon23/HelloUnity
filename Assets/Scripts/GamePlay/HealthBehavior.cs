using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBehavior : MonoBehaviour
{
    // Sets the health values for this object
    [SerializeField]
    private float _health;
    // Kepts tabs on the object 
    [SerializeField]
    private bool _isAlive;
    [SerializeField]
    private bool _destroyOnDeath;

    public float Health { get { return _health; } set { _health = value; } }

    public bool IsAlive { get { return _isAlive; } set { _isAlive = value; } }

    public virtual float TakeDamage(float damageAmount)
    {
        _health -= damageAmount;

        return damageAmount;
    }

    public virtual void OnDeath()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (_health <= 0 && IsAlive)
            OnDeath();

        _isAlive = _health > 0;

        if (!IsAlive && _destroyOnDeath)
            Destroy(gameObject);
    }
}
