using UnityEngine;
using DG.Tweening;

public class FinalPopup : MonoBehaviour
{
    public void ActivateFinalPopup()
    {
        gameObject.SetActive(true);
        gameObject.transform.DOLocalMove(Vector3.zero, 2);
    }
}
