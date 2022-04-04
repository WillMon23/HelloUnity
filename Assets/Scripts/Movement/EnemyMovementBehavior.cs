using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementBehavior : MovementBehavior
{
    [SerializeField]
    private Transform _target;

    [SerializeField]
    private float _damage; 
    public Transform Target { get { return _target; } set { _target = value; } }

    // Update is called once per frame
    public override void  Update()
    {
        Vector3 direction = Target.position - transform.position;
        Velocity = direction.normalized * Speed;

        base.Update();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform == _target)
        {
            GoalBehavior goalHealth = other.GetComponent<GoalBehavior>();
            if (goalHealth)
                goalHealth.TakeDamage(_damage);
            Destroy(gameObject);
        }
    } 

    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
