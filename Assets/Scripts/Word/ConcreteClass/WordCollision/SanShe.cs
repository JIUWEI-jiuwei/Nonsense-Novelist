using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 碰撞机制：排比 散射
/// </summary>
public class SanShe : WordCollisionShoot
{
    private int num = 0;
    public bool hasCol;
    Coroutine coroutineWait = null;
    Color color = Color.yellow;
    public override void Awake()
    {
        base.Awake();

        this.GetComponent<SpriteRenderer>().color = color;

    }
    public override void OnTriggerEnter2D(Collider2D collision)
    {
     
        //给absWord赋值
        //absWord = Shoot.abs;
        base.OnTriggerEnter2D(collision);
    }
    public void OnCollisionEnter2D(Collision2D collision)//(角度计算有问题)
    {        //给absWord赋值
        //absWord = Shoot.abs;
        if (!hasCol && collision.transform.tag == "wall")
        {
            if (coroutineWait != null)
                StopCoroutine(coroutineWait);
            coroutineWait = StartCoroutine(SanSheFunction(collision));
        }
          
          
        
    }
    Rigidbody2D a;
    Vector3 normal;
    IEnumerator SanSheFunction(Collision2D collision)
    {
        a = this.transform.GetComponent<Rigidbody2D>();
        // 计算反射方向
        Vector3 reflectionDirection = Vector3.Reflect(a.velocity, normal);
        // 更新小球速度为反射方向并保持原有速度的大小
        a.velocity = reflectionDirection.normalized * a.velocity.magnitude;

        yield return new WaitForSeconds(0.05f);

        if (!hasCol && collision.transform.tag == "wall")
        {

            hasCol = true;

            while (num < 2)
            {
                GameObject clone = Instantiate(this.gameObject);//2
                hasCol = true;

                clone.transform.SetParent(this.transform);
                clone.transform.localScale = Vector3.one;
                clone.transform.localPosition = Vector3.zero;

                if (num == 0)
                {

                    clone.GetComponent<SpriteRenderer>().color =color + new Color(0.4f, 0.4f, 0.4f, 0);

                    clone.GetComponent<Rigidbody2D>().velocity = Quaternion.Euler(0, 0, 60) * reflectionDirection;

                }
                else if (num == 1)
                {
                    clone.GetComponent<SpriteRenderer>().color = color- new Color(0.4f, 0.4f, 0.4f, 0);
                    if (clone.transform.GetChild(0) != null)
                    {
                        Destroy(clone.transform.GetChild(0).gameObject);
                    }
                    clone.GetComponent<Rigidbody2D>().velocity = Quaternion.Euler(0, 0, -60) * reflectionDirection;

                }
        
                num++;
            }
        }


        StopAllCoroutines();
    }
}
