using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 碰撞机制：排比 散射
/// </summary>
public class SanShe : WordCollisionShoot
{ 
    static public string s_description = "纸团在首次碰到墙壁时分裂为3个";
    static public string s_wordName = "排比 散射";



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
<<<<<<< HEAD
        if (CharacterManager.instance.pause)
            return;
=======
     
>>>>>>> 66fe0047b38250f01931638095da1ca5d7de0454
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
<<<<<<< HEAD
        if (CharacterManager.instance.pause)
            return;
        //给absWord赋值
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
         
=======
        a = this.transform.GetComponent<Rigidbody2D>();
        // 计算反射方向
        Vector3 reflectionDirection = Vector3.Reflect(a.velocity, normal);
        // 更新小球速度为反射方向并保持原有速度的大小
        a.velocity = reflectionDirection.normalized * a.velocity.magnitude;

        yield return new WaitForSeconds(0.05f);

        if (!hasCol && collision.transform.tag == "wall")
        {

            hasCol = true;

>>>>>>> 66fe0047b38250f01931638095da1ca5d7de0454
            while (num < 2)
            {
                
                GameObject clone = Instantiate(this.gameObject);//2
                hasCol = true;

                clone.transform.SetParent(this.transform);
                clone.transform.localScale = Vector3.one;
                clone.transform.localPosition = Vector3.zero;
<<<<<<< HEAD
                clone.transform.SetParent(this.transform.parent);
=======

>>>>>>> 66fe0047b38250f01931638095da1ca5d7de0454
                if (num == 0)
                {

                    clone.GetComponent<SpriteRenderer>().color =color + new Color(0.4f, 0.4f, 0.4f, 0);

                    clone.GetComponent<Rigidbody2D>().velocity = Quaternion.Euler(0, 0, 60) * reflectionDirection;

                }
                else if (num == 1)
                {
                    clone.GetComponent<SpriteRenderer>().color = color- new Color(0.4f, 0.4f, 0.4f, 0);
<<<<<<< HEAD
                  
                    clone.GetComponent<Rigidbody2D>().velocity = Quaternion.Euler(0, 0, -60) * reflectionDirection;
                   
                }
                foreach (var _c in clone.GetComponents<SanShe>())
                    _c.hasCol = true;

                if (this.transform.childCount > 2)
                {
                    Destroy(this.gameObject);
=======
                    if (clone.transform.GetChild(0) != null)
                    {
                        Destroy(clone.transform.GetChild(0).gameObject);
                    }
                    clone.GetComponent<Rigidbody2D>().velocity = Quaternion.Euler(0, 0, -60) * reflectionDirection;

>>>>>>> 66fe0047b38250f01931638095da1ca5d7de0454
                }
        
                num++;
            }
        }

<<<<<<< HEAD
      
=======

>>>>>>> 66fe0047b38250f01931638095da1ca5d7de0454
        StopAllCoroutines();
    }
}
