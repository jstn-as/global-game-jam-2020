using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Player
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private Transform _camera;
        [SerializeField] private float _speed;
        private Vector2 _moveDirection;
        private Rigidbody _rb;
        private void Awake()
        {
            _rb = GetComponent<Rigidbody>();
        }

        private void OnMove(InputValue input)
        {
            _moveDirection = input.Get<Vector2>();
            print(_moveDirection);
        }

        private void FixedUpdate()
        {
            _rb.velocity = new Vector3(_moveDirection.x, 0, _moveDirection.y);
        }
    }
}
