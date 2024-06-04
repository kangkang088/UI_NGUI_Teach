using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson5 : MonoBehaviour
{
    public UITexture texture;
    // Start is called before the first frame update
    void Start()
    {
        Texture source = Resources.Load<Texture>("BK");
        if (source != null) {
            texture.mainTexture = source;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
