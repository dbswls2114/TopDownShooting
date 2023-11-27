using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    private TopDownCharacterController _controller;

    private Vector2 _moveMentDirection = Vector2.zero;
    private Rigidbody2D _rigidbody;
    [SerializeField] private Animator _animator;
    bool _isMoving = false;

    private void Awake()
    {
        _controller = GetComponent<TopDownCharacterController>();
        _rigidbody = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    private void Start()
    {
        _controller.OnMoveEvent += Move;       
    }

    private void FixedUpdate()
    {
        ApplyMovement(_moveMentDirection);
    }

    private void Move(Vector2 direction)
    {
        _moveMentDirection = direction;
        //한글테스트
    }

    void ApplyMovement(Vector2 direction)
    {
        direction = direction * 5;
        _rigidbody.velocity = direction;
        if(direction != Vector2.zero)
        {
            _isMoving = true;           
        }
        else if(direction == Vector2.zero)
        {
            _isMoving = false;           
        }
        _animator.SetBool("IsMove", _isMoving);

    }
}
