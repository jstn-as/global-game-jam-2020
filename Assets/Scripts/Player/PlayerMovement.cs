using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Users;

namespace Player
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private float _speed = 1;
        private PlayerInput _playerInput;
        private Vector2 _moveDirection;
        private Rigidbody _rb;
        private void Awake()
        {
            _rb = GetComponent<Rigidbody>();
        }

        private void OnJoin(Object player)
        {
            print(player.GetType());
        }
        
        private void OnMove(InputValue input)
        {
            _moveDirection = input.Get<Vector2>();
        }

        private void FixedUpdate()
        {
            var newVelocity = new Vector3(_moveDirection.x, 0, _moveDirection.y) * _speed;
            _rb.velocity = newVelocity;
        }
    }
}
