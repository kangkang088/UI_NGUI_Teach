using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson3 : MonoBehaviour {
    public UISprite sprite;
    // Start is called before the first frame update
    void Start() {
        sprite.spriteName = "bk";
        NGUIAtlas atlas = Resources.Load<NGUIAtlas>("Atlas/Login");
        sprite.atlas = atlas;
        sprite.spriteName = "ui_DL_anniuxiao_01";
    }

    // Update is called once per frame
    void Update() {

    }
}
