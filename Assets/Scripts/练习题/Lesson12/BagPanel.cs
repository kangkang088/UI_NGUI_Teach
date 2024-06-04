using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagPanel : MonoBehaviour
{
    private static BagPanel instance;
    public static BagPanel Instance => instance;

    public UIScrollView scrollView;
    public UIButton buttonClose;
    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(false);
        buttonClose.onClick.Add(new EventDelegate(() =>
        {
            this.gameObject.SetActive(false);
        }));
        for (int i = 0; i < 60; i++)
        {
            GameObject obj = Instantiate(Resources.Load<GameObject>("Item"));
            obj.transform.SetParent(scrollView.transform, false);
            obj.transform.localPosition = new Vector3(120 * (i % 5), 120 * (i / 5), 0);
        }
        scrollView.UpdateScrollbars();
    }


}
