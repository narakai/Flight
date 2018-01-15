using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero_animation : MonoBehaviour
{
    private bool animation = true;
    public int framOfPerSecond = 10; //每秒几帧(帧率)
    public Sprite[] sprite; //存放精灵图片
    SpriteRenderer sp; //存放精灵组件
    public float timer; //计时器


    // Use this for initialization
    void Start()
    {
        sp = GetComponent<SpriteRenderer>(); //获取精灵组件
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime; //计时器累加
        int m = (int) (timer / (1.0f / framOfPerSecond)); // 时间除以每帧所需的时间，得出一共有多少帧
        int sprit = m % 2; //总帧数和2取余，结果总是0，1，0，1，0
        sp.sprite = sprite[sprit]; //从精灵数组里取出精灵图片
    }
}