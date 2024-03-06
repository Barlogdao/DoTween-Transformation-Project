using DG.Tweening;
using UnityEngine;

public class RotateModule : BaseModule
{
    [SerializeField] private Vector3 _rotation;
    [SerializeField] private float _speed;

    [SerializeField] private RotateMode _rotateMode = RotateMode.Fast;

    private void Start()
    {
        Rotate();
    }

    private void Rotate()
    {
        transform.DORotate(_rotation, _speed, _rotateMode).SetAs(InfiniteLoop).SetSpeedBased();
    }
}