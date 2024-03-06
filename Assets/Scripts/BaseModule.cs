using DG.Tweening;
using UnityEngine;

public class BaseModule : MonoBehaviour
{
    [SerializeField] private LoopType _loopType;
    [SerializeField] private Ease _ease;

    protected TweenParams InfiniteLoop { get; private set; }

    private void Awake()
    {
        InfiniteLoop = new TweenParams().SetLoops(-1,_loopType).SetEase(_ease);

        OnAwake();
    }

    protected virtual void OnAwake() { }
}