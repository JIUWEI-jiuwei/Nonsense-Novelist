using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 充能
/// </summary>
public class ChongNeng : WordCollisionShoot
{
    /// <summary>碰撞次数 </summary>
    private int count = 0;
    public override void Awake()
    {
        base.Awake();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        count++;
        Debug.Log(count);
    }
    public override void OnTriggerEnter2D(Collider2D collision)
    {
        //给absWord赋值
        absWord = Shoot.abs;

        if (collision.gameObject.layer == LayerMask.NameToLayer("Character"))
        {
            AbstractCharacter character = collision.gameObject.GetComponent<AbstractCharacter>();

            //判断该词条是形容词/动词/名词
            //先把absWord脚本挂在角色身上，然后调用角色身上的useAdj
            if (absWord.wordKind == WordKindEnum.verb)
            {
                AbstractVerbs b = this.GetComponent<AbstractVerbs>();
                collision.gameObject.AddComponent(b.GetType());
                character.skills.Add(b);
                Destroy(this.gameObject);

            }
            else if (absWord.wordKind == WordKindEnum.adj)
            {
                collision.gameObject.AddComponent(absWord.GetType());
                //充能效果
                if (collision.gameObject.GetComponent<XinShenJiDang>())
                {
                    //心神激荡的
                    XinShenJiDang  a = collision.gameObject.GetComponent<XinShenJiDang>();
                    a.chongNeng = count;
                }
                else if (collision.gameObject.GetComponent<GuoMin>())
                {
                    //过敏的
                    GuoMin a = collision.gameObject.GetComponent<GuoMin>();
                    a.chongNeng = count;
                }
                collision.gameObject.GetComponent<AbstractAdjectives>().UseAdj(collision.gameObject.GetComponent<AbstractCharacter>());
                Destroy(this.gameObject);
            }
            else if (absWord.wordKind == WordKindEnum.noun)
            {
                collision.gameObject.AddComponent(absWord.GetType());

                //充能效果
                if (collision.gameObject.GetComponent<EXingZhongLiu>())
                {
                    //恶性肿瘤
                    EXingZhongLiu a = collision.gameObject.GetComponent<EXingZhongLiu>();
                    a.chongNeng = count;
                }

                collision.gameObject.GetComponent<AbstractItems>().UseItems(collision.gameObject.GetComponent<AbstractCharacter>());
                Destroy(this.gameObject);
            }
        }
    }
}
