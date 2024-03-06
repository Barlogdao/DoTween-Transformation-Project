using UnityEngine;
using DG.Tweening;

public class MoveModule : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private float _speed;
    [SerializeField] LoopType _loopType = LoopType.Yoyo;
    [SerializeField] Ease _ease = Ease.Linear;

    void Start()
    {
        Move();
    }

    private void Move()
    {
        transform.DOMove(_target.transform.position, _speed).SetSpeedBased().SetLoops(-1,_loopType).SetEase(_ease);
    }
}
