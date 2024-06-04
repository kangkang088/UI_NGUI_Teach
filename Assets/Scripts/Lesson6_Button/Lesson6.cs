using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson6 : MonoBehaviour {
    public UIButton button;
    // Start is called before the first frame update
    void Start() {
        button.onClick.Add(new EventDelegate(ClickDoSomething2));
    }

    public void ClickDoSomething() {
        print("点击执行");
    }
    public void ClickDoSomething2() {
        print("点击测试2");
    }
}
