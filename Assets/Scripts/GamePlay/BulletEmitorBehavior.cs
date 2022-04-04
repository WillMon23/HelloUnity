using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEmitorBehavior : MonoBehaviour
{
    [SerializeField]
    private BulletBehavior _bulletRef;
    [SerializeField]
    private float _bulletForce;
    [SerializeField]
    //Game Object Shooting this bullet
    private GameObject _owner; 

    public void Fire()
    {
        GameObject bullet = Instantiate(_bulletRef.gameObject, transform.position, transform.rotation);

        BulletBehavior bulletBehavior = bullet.GetComponent<BulletBehavior>();
        bulletBehavior.OwnerTag = _owner.tag;
        bulletBehavior.Rigidbody.AddForce(transform.forward * _bulletForce,ForceMode.Impulse);
    }
}
