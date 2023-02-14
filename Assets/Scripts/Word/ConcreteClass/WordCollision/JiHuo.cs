using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 激活
/// </summary>
public class JiHuo : WordCollisionShoot
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
                //激活效果
                if (count >= 3 && collision.gameObject.GetComponent<SanFaFeiLuoMeng>())
                {
                    //散发费洛蒙的
                    SanFaFeiLuoMeng a = collision.gameObject.GetComponent<SanFaFeiLuoMeng>();
                    a.jiHuo = true;
                }
                collision.gameObject.GetComponent<AbstractAdjectives>().UseAdj(collision.gameObject.GetComponent<AbstractCharacter>());
                Destroy(this.gameObject);
            }
            else if (absWord.wordKind == WordKindEnum.noun)
            {
                collision.gameObject.AddComponent(absWord.GetType());

                //激活效果
                if (count >= 3)
                {
                    if (collision.gameObject.GetComponent<WhiteStone>())
                    {
                        //白水晶
                        WhiteStone a= collision.gameObject.GetComponent<WhiteStone>();
                        a.jiHuo = true;
                    }
                    else if (collision.gameObject.GetComponent<PurpleStone>())
                    {
                        //紫水晶
                        PurpleStone a = collision.gameObject.GetComponent<PurpleStone>();
                        a.jiHuo = true;
                    }
                    else if (collision.gameObject.GetComponent<TigerStone>())
                    {
                        //虎眼石
                        TigerStone a = collision.gameObject.GetComponent<TigerStone>();
                        a.jiHuo = true;
                    }
                    else if (collision.gameObject.GetComponent<MeiGuiShiYing>())
                    {
                        //玫瑰石英
                        MeiGuiShiYing a = collision.gameObject.GetComponent<MeiGuiShiYing>();
                        a.jiHuo = true;
                    }
                }

                collision.gameObject.GetComponent<AbstractItems>().UseItems(collision.gameObject.GetComponent<AbstractCharacter>());
                Destroy(this.gameObject);
            }
        }
    }
}
