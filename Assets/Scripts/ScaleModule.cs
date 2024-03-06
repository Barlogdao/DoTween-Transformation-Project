using DG.Tweening;
using UnityEngine;

public class ScaleModule : MonoBehaviour
{
    [SerializeField] Vector3 _targetScale;
    [SerializeField] private float _duration;

    [SerializeField] LoopType _loopType = LoopType.Yoyo;
    [SerializeField] Ease _ease = Ease.Linear;

    void Start()
    {
        Scale();
    }

    private void Scale()
    {
        transform.DOScale(_targetScale,_duration).SetLoops(-1, _loopType).SetEase(_ease);
    }
}