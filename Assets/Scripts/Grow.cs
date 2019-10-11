using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Grow : MonoBehaviour
{
    public Image image;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        image.color=new Color(image.color.r, image.color.g, image.color.b, image.color.a+speed);
        if (image.color.a <= 0&&speed<0) { speed *= -1; }
        if (image.color.a >= 1&&speed>0) { speed *= -1; }
    }
}
