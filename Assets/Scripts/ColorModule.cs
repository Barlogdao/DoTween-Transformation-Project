using DG.Tweening;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class ColorModule : MonoBehaviour
{
    [SerializeField] Color _color;
    [SerializeField] private float _duration;

    [SerializeField] LoopType _loopType = LoopType.Yoyo;
    [SerializeField] Ease _ease = Ease.Linear;

    private Material _material;

    private void Awake()
    {
        _material = GetComponent<MeshRenderer>().material;
    }

    void Start()
    {
        ChangeColor();
    }

    private void ChangeColor()
    {
        _material.DOColor(_color,_duration).SetLoops(-1, _loopType).SetEase(_ease);
    }
}
