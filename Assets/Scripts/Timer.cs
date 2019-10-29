using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    float countTime = 0;
    public Sprite[] num;
    public Image[] image;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        countTime += Time.deltaTime;
        image[0].sprite = num[(int)countTime / 10];
        image[1].sprite = num[(int)countTime % 10];
        image[2].sprite = num[(int)(countTime*10-(int)countTime*10)];
        image[3].sprite = num[(int)(countTime *100 -(int)countTime*100)% 10];
    }
}
