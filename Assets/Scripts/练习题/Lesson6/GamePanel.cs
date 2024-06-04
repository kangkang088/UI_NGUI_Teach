using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePanel : MonoBehaviour
{
    private static GamePanel instance;
    public static GamePanel Instance => instance;
    private void Awake()
    {
        instance = this;
    }
    public UIButton button;
    public TankObj player;
    public UIToggle toggleSound;
    public UILabel labelName;
    public UIButton btnChange;
    public UIPopupList list;
    public Light directionLight;
    public UISlider slider;
    public UIProgressBar progressBar;
    public UIButton btnBag;
    public UISprite controllerSprite;
    public UIToggle toggleCh;
    public UIToggle toggleEn;
    // Start is called before the first frame update
    void Start()
    {
        HideHPProgress();
        button.onClick.Add(new EventDelegate(() =>
        {
            player.Fire();
        }));
        toggleSound.onChange.Add(new EventDelegate(() =>
        {
            MusicData.isOpenSound = toggleSound.value;
        }));
        btnChange.onClick.Add(new EventDelegate(() =>
        {
            ChangeNamePanel.Instance.gameObject.SetActive(true);

        }));
        list.onChange.Add(new EventDelegate(() =>
        {
            switch (list.value)
            {
                case "白天":
                    directionLight.intensity = 1;
                    break;
                case "黑夜":
                    directionLight.intensity = 0.2f;
                    break;
                default:
                    break;
            }
        }));
        slider.onChange.Add(new EventDelegate(() =>
        {
            MusicData.intensity = slider.value;
        }));
        btnBag.onClick.Add(new EventDelegate(() =>
        {
            BagPanel.Instance.gameObject.SetActive(true);
        }));
        #region Lesson14
        UIEventListener uIEventListener = UIEventListener.Get(controllerSprite.gameObject);
        uIEventListener.onDrag += DragWithMove;
        uIEventListener.onDragEnd += DragRevert;
        #endregion
        toggleCh.onChange.Add(new EventDelegate(() =>
        {
            if (toggleCh.value)
            {
                Localization.language = "中文";
            }
        }));
        toggleEn.onChange.Add(new EventDelegate(() =>
        {
            if (toggleEn.value)
            {
                Localization.language = "English";
            }
        }));
    }
    private void DragRevert(GameObject go)
    {
        go.transform.localPosition = Vector3.zero;
        player.Stop();
    }
    private void DragWithMove(GameObject go, Vector2 delta)
    {
        go.transform.localPosition += new Vector3(delta.x, delta.y, 0);
        if (go.transform.localPosition.magnitude > 160)
        {
            go.transform.localPosition = go.transform.localPosition.normalized * 160;
        }
        player.Move(go.transform.localPosition.normalized);
    }
    public void ShowHPProgress()
    {
        progressBar.gameObject.SetActive(true);
    }
    public void HideHPProgress()
    {
        progressBar.gameObject.SetActive(false);
    }
    public void UpdateHPProgress(float nowValue, float maxValue)
    {
        progressBar.value = nowValue / maxValue;
    }
}
