using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBehavior : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    [SerializeField]
    private Vector3 _velocity;
    
    public float Speed { get { return _speed; } set { _speed = value; }  }
    public Vector3 Velocity { get { return _velocity;  } set { _velocity = value; } }

    public void Move(Vector3 vector)
    {
        _velocity = transform.position + vector * Speed;
    }

    // Update is called once per frame
    public virtual void Update()
    {
        transform.position += Velocity * Time.deltaTime;
    }
   
}
