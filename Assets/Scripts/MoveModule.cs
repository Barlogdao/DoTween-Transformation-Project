using UnityEngine;
using DG.Tweening;

public class MoveModule : MonoBehaviour
{
    [SerializeField] private Vector3 _positionOffset;

    [SerializeField] private float _speed;
    [SerializeField] LoopType _loopType = LoopType.Yoyo;
    [SerializeField] Ease _ease = Ease.Linear;

    void Start()
    {
        Move();
    }

    private void Move()
    {
        Vector3 targetPosition = transform.position + _positionOffset;
        transform.DOMove(targetPosition, _speed).SetSpeedBased().SetLoops(-1,_loopType).SetEase(_ease);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;

        Gizmos.DrawSphere(transform.position + _positionOffset, 0.5f);
    }
}
