using UnityEngine;

[RequireComponent (typeof(Rigidbody),typeof(BoxCollider))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private DynamicJoystick _joystick;
    [SerializeField] private float _speed;
    void Update()
    {
        _rigidbody.linearVelocity = new Vector3(_joystick.Horizontal*_speed, _rigidbody.linearVelocity.y, _joystick.Vertical*_speed);

        if (_joystick.Horizontal !=0|| _joystick.Vertical!=0)
        {
            transform.rotation = Quaternion.LookRotation(_rigidbody.linearVelocity);
        }
    }
}
