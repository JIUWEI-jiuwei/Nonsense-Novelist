using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 墙壁移动or旋转
/// </summary>
public class OneWayMove : MonoBehaviour
{
    /// <summary>水平方向</summary>
    private float hori_way;
    public float value1 = 10;
    /// <summary>垂直方向</summary>
    private float ver_way;
    public float value2 = 10;
    /// <summary>旋转角度</summary>
    public float angle = 1;
    /// <summary>消失时间</summary>
    public float disappearTime = 2;

    /// <summary>判断</summary>
    public int or = 0;
    // Update is called once per frame
    void Update()
    {
        if (or==0)//水平方向
        {
            hori_way = Mathf.PingPong(Time.time, value1);
            transform.position = new Vector3(hori_way, transform.position.y, transform.position.z);
        }
        else if (or == 1)//竖直方向
        {
            ver_way = Mathf.PingPong(Time.time, value2);
            transform.position = new Vector3(transform.position.x, ver_way, transform.position.z);
        }
        else if(or==2)//定点旋转
        {
            transform.RotateAround(this.transform.position, Vector3.forward, angle);

        }

    }
    /// <summary>
    /// 墙壁消失后再出现
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (or == 3)//消失后再出现
        {
            if (collision.transform.tag == "bullet")
            {
                this.gameObject.SetActive(false);
                Invoke("EnableBack", disappearTime);
            }
        }
        if (or == 4)//传送门（未完成）
        {
            if(collision.transform.tag == "bullet")
            {
                collision.transform.position = transform.GetChild(0).position;
            }
        }
    }
    public void EnableBack()
    {
        this.gameObject.SetActive(true);
    }
}
