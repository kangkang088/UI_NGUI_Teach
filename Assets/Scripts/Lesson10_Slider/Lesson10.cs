using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson10 : MonoBehaviour {
    public UISlider slider;
    // Start is called before the first frame update
    void Start() {
        slider.onChange.Add(new EventDelegate(() => {
            print("通过代码监听" + slider.value);
        }));
        slider.onDragFinished += () => {
            print("拖曳结束");
        };
    }
    public void OnChange() {
        print("值变化" + slider.value);
    }
    // Update is called once per frame
    void Update() {

    }
}
