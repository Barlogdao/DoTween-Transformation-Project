using DG.Tweening;
using UnityEngine;

public class ScaleModule : BaseModule
{
    [SerializeField] private Vector3 _targetScale;
    [SerializeField] private float _duration;

    private void Start()
    {
        Scale();
    }

    private void Scale()
    {
        transform.DOScale(_targetScale, _duration).SetAs(InfiniteLoop);
    }
}