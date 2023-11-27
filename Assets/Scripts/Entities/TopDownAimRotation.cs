using System.Collections;
using System.Collections.Generic;
using UnityEditor.U2D.Sprites;
using UnityEngine;

public class TopDownAimRotation : MonoBehaviour
{

    [SerializeField] private SpriteRenderer armRenderer;
    [SerializeField] private Transform armPivot;

    [SerializeField] private SpriteRenderer characterRenderer;

    private TopDownCharacterController _controller;

    private void Awake()
    {
        _controller = GetComponent<TopDownCharacterController>();
    }

    void Start()
    {
        _controller.OnLookEvent += OnAim;
    }

    void Update()
    {
        
    }

    public void OnAim(Vector2 newAimDirection)
    {
        RotateArm(newAimDirection);
    }

    private void RotateArm(Vector2 direction)
    {
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        //아크탄젠트를 구하는거 

        armRenderer.flipY = Mathf.Abs(rotZ)>90f;
        characterRenderer.flipX = armRenderer.flipY;
        //활의 좌우를 바꾸는거

        armPivot.rotation = Quaternion.Euler(0, 0, rotZ);
    }
}
