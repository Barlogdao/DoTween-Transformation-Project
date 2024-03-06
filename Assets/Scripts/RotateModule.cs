using DG.Tweening;
using UnityEngine;

public class RotateModule : MonoBehaviour
{
    [SerializeField] Vector3 _rotation;
    [SerializeField] private float _speed;

    [SerializeField] LoopType _loopType = LoopType.Incremental;
    [SerializeField] Ease _ease = Ease.Linear;
    [SerializeField] RotateMode _rotateMode = RotateMode.Fast;

    void Start()
    {
        Rotate();
    }

    private void Rotate()
    {
        transform.DORotate(_rotation,_speed, _rotateMode).SetSpeedBased().SetLoops(-1, _loopType).SetEase(_ease);
    }
}