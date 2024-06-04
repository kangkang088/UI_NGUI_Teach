using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson7 : MonoBehaviour {
    public UIToggle toggle1;
    public UIToggle toggle2;
    public UIToggle toggle3;
    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }
    public void Change() {
        print("value has changed!");
        if (toggle1.value) {
            print("toggle1被选中");
        } else if (toggle2.value) {
            print("toggle2被选中");
        } else if (toggle3.value) {
            print("toggle3被选中");
        }
    }
}
