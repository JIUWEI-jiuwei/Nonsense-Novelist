using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 散射
/// </summary>
public class SanShe : WordCollisionShoot
{
    private int num = 0;
    public bool hasCol;

    public override void Awake()
    {
        base.Awake();
    }
    public override void OnTriggerEnter2D(Collider2D collision)
    {
        //给absWord赋值
        absWord = Shoot.abs;
        base.OnTriggerEnter2D(collision);
    }
    public void OnCollisionEnter2D(Collision2D collision)//(角度计算有问题)
    {
        //给absWord赋值
        absWord = Shoot.abs;

        if (!hasCol && collision.transform.tag == "wall")
        {
            hasCol = true;
            while (num < 2)
            {
                GameObject clone = Instantiate(this.gameObject);//2
                hasCol = true;

                clone.transform.SetParent(this.transform);
                clone.transform.localScale = Vector3.one;
                clone.transform.GetComponent<Rigidbody2D>().velocity = this.transform.GetComponent<Rigidbody2D>().velocity;
                if (num == 0)
                {
                    clone.transform.localEulerAngles = new Vector3(this.transform.localEulerAngles.x, this.transform.localEulerAngles.y, this.transform.localEulerAngles.z + 60);
                    Vector3 a = this.GetComponent<Rigidbody2D>().velocity;
                    clone.transform.position = this.transform.position + a;
                }
                else if (num == 1)
                {
                    if (clone.transform.GetChild(0) != null)
                    {
                        Destroy(clone.transform.GetChild(0).gameObject);
                    }

                    clone.transform.localEulerAngles = new Vector3(this.transform.localEulerAngles.x, this.transform.localEulerAngles.y, this.transform.localEulerAngles.z - 60);
                    Vector3 b = this.GetComponent<Rigidbody2D>().velocity;
                    clone.transform.position = this.transform.position + b;
                }
                num++;
            }
        }
        
    }
}
