using UnityEngine;
using DG.Tweening;

public class MoveModule : BaseModule
{
    [SerializeField] private Vector3 _positionOffset;
    [SerializeField] private float _speed;

    private void Start()
    {
        Move();
    }

    private void Move()
    {
        Vector3 targetPosition = transform.position + _positionOffset;

        transform.DOMove(targetPosition, _speed).SetAs(InfiniteLoop).SetSpeedBased();
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;

        Gizmos.DrawSphere(transform.position + _positionOffset, 0.5f);
    }
}
