using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBarUI : MonoBehaviour
{
    [SerializeField] private GameObject hasprogressgameobject;
    [SerializeField] private Image baseImage;

    private IHasProgress hasprogress;
    private void Start()
    {
        hasprogress = hasprogressgameobject.GetComponent<IHasProgress>();
        hasprogress.OnprogressChanged += Hasprogress_OnprogressChanged;
        baseImage.fillAmount = 0;
        Hide();
    }

    private void Hasprogress_OnprogressChanged(object sender, IHasProgress.OnprogressChangedEventargs e)
    {
        baseImage.fillAmount = e.progressNormalized;
        if (e.progressNormalized == 0f || e.progressNormalized == 1f)
        {
            Hide();
        }
        else { Show(); }

    }

    private void Show()
    {
        gameObject.SetActive(true);
    }
    private void Hide()
    {
        gameObject.SetActive(false);
    }
}
