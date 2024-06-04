using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson14 : MonoBehaviour
{
    public UISprite A;
    public UISprite B;
    // Start is called before the first frame update
    void Start()
    {
        UIEventListener listener = UIEventListener.Get(A.gameObject);
        listener.onPress += Press;
        listener.onDragStart += DragStart;
    }

    private void DragStart(GameObject go)
    {
        print(go.name + "开始拖曳!");
    }

    private void Press(GameObject go, bool state)
    {
        print(go.name + "被按下或抬起了" + state);
    }

    // Update is called once per frame
    void Update()
    {

    }
    //void OnPress(bool pressed)
    //{
    //    if (pressed)
    //    {
    //        print("按下!!!!");
    //    }
    //    else
    //    {
    //        print("抬起！！！！");
    //    }
    //}
    //void OnHover(bool isOver)
    //{
    //    if (isOver)
    //    {
    //        print("经过!!!");
    //    }
    //    else
    //    {
    //        print("离开！！！");
    //    }
    //}
    //void OnClick()
    //{
    //    print("点击相关！");
    //}
    //void OnDragStart()
    //{
    //    print("拖曳开始");
    //}
    //void OnDrag(Vector2 delta)
    //{
    //    print("拖曳中" + delta);
    //}
    //void OnDragEnd()
    //{
    //    print("拖曳结束！！");
    //}
    void OnDragOver(GameObject obj)
    {
        print("拖曳经过对象：" + obj.name);
    }
    void OnDragOut(GameObject obj)
    {
        print("拖曳离开对象：" + obj.name);
    }
}
