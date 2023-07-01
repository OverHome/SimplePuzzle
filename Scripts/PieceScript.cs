using System;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using DG.Tweening;

public class PieceScript : MonoBehaviour, IPointerClickHandler
{
    private bool _inRotate;

    private void Start()
    {
        _inRotate = false;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (!_inRotate)
        {
            transform.DORotate(new Vector3(0, 0, -90), 0.3f).SetRelative()
                .OnStart(() => _inRotate = true)
                .OnComplete(() => _inRotate = false);
        }
    }

    // IEnumerator RotatePiece(float angle)
    // {
    //     float t = 0;
    //     const float animationDuration = 0.2f;
    //     
    //     Vector3 degrees = new Vector3(0,0,angle);
    //     Quaternion start = transform.rotation;
    //     Quaternion end = start * Quaternion.Euler(degrees);
    //     while (t<1)
    //     {
    //         transform.rotation = Quaternion.Lerp( start, end, t);
    //         t += Time.deltaTime / animationDuration;
    //         yield return null;
    //     }
    //     transform.rotation = Quaternion.Lerp( start, end, 1);
    //     inRotate = false;
    // }
}