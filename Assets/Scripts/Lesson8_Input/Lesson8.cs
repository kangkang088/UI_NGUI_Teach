using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson8 : MonoBehaviour
{
    public UIInput input;
    // Start is called before the first frame update
    void Start()
    {
        input.onSubmit.Add(new EventDelegate(() => {

        }));
        input.onChange.Add(new EventDelegate(() => {

        }));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnChange() {
        print("输入变化" + input.value);
    }
    public void OnSubmit() {
        print("输入完成" + input.value);
    }
}
