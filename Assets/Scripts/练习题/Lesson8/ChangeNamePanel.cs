using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeNamePanel : MonoBehaviour {
    private static ChangeNamePanel instance;
    public static ChangeNamePanel Instance => instance;
    private void Awake() {
        instance = this;
    }
    public UIButton btnChange;
    public UIInput inputName;
    // Start is called before the first frame update
    void Start() {
        btnChange.onClick.Add(new EventDelegate(() => {
            GamePanel.Instance.labelName.text = inputName.value;
            this.gameObject.SetActive(false);
        }));
        this.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update() {

    }
}
