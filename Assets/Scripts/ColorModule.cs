using DG.Tweening;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class ColorModule : BaseModule
{
    [SerializeField] private Color _color;
    [SerializeField] private float _duration;

    private Material _material;

    protected override void OnAwake()
    {
        base.OnAwake();
        _material = GetComponent<MeshRenderer>().material;
    }

    private void Start()
    {
        ChangeColor();
    }

    private void ChangeColor()
    {
        _material.DOColor(_color, _duration).SetAs(InfiniteLoop);
    }
}
