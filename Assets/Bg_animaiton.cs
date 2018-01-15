using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bg_animaiton : MonoBehaviour
{
    public static float speed = 2;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, -1, 0) * speed * Time.deltaTime);
        //向下移动
        if (transform.position.y < -8.42)
        {
            transform.position =
                new Vector3(transform.position.x, transform.position.y + 8.42f * 2, transform.position.z);
            //移到原位置
        }
    }
}