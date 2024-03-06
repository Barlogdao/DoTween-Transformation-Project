using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class TextModule : BaseModule
{
    [SerializeField] private Text _text;

    [SerializeField] private string _message;
    [SerializeField] private string _additionalMessage;
    [SerializeField] private string _scrambledMessage;

    [SerializeField] private float _duration;
    [SerializeField] private float _intervalDuration;

    [SerializeField] private ScrambleMode _scrambleMode;

    private void Start()
    {
        SetText();
    }

    private void SetText()
    {
        Tween changeTextTween = _text.DOText(_message, _duration);
        Tween addTextTween = _text.DOText(_additionalMessage, _duration).SetRelative();
        Tween scrambleTextTweeen = _text.DOText(_scrambledMessage, _duration, scrambleMode: _scrambleMode);

        Sequence sequence = DOTween.Sequence();

        sequence.AppendInterval(_intervalDuration)
            .Append(changeTextTween)
            .AppendInterval(_intervalDuration)
            .Append(addTextTween)
            .AppendInterval(_intervalDuration)
            .Append(scrambleTextTweeen)
            .SetAs(InfiniteLoop);
    }
}
