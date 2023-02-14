using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ����
/// </summary>
public class JiHuo : WordCollisionShoot
{
    /// <summary>��ײ���� </summary>
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


        //��absWord��ֵ
        absWord = Shoot.abs;

        if (collision.gameObject.layer == LayerMask.NameToLayer("Character"))
        {
            AbstractCharacter character = collision.gameObject.GetComponent<AbstractCharacter>();

            //�жϸô��������ݴ�/����/����
            //�Ȱ�absWord�ű����ڽ�ɫ���ϣ�Ȼ����ý�ɫ���ϵ�useAdj
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
                //����Ч��
                if (count >= 3 && collision.gameObject.GetComponent<SanFaFeiLuoMeng>())
                {
                    //ɢ�������ɵ�
                    SanFaFeiLuoMeng a = collision.gameObject.GetComponent<SanFaFeiLuoMeng>();
                    a.jiHuo = true;
                }
                collision.gameObject.GetComponent<AbstractAdjectives>().UseAdj(collision.gameObject.GetComponent<AbstractCharacter>());
                Destroy(this.gameObject);
            }
            else if (absWord.wordKind == WordKindEnum.noun)
            {
                collision.gameObject.AddComponent(absWord.GetType());

                //����Ч��
                if (count >= 3)
                {
                    if (collision.gameObject.GetComponent<WhiteStone>())
                    {
                        //��ˮ��
                        WhiteStone a= collision.gameObject.GetComponent<WhiteStone>();
                        a.jiHuo = true;
                    }
                    else if (collision.gameObject.GetComponent<PurpleStone>())
                    {
                        //��ˮ��
                        PurpleStone a = collision.gameObject.GetComponent<PurpleStone>();
                        a.jiHuo = true;
                    }
                    else if (collision.gameObject.GetComponent<TigerStone>())
                    {
                        //����ʯ
                        TigerStone a = collision.gameObject.GetComponent<TigerStone>();
                        a.jiHuo = true;
                    }
                    else if (collision.gameObject.GetComponent<MeiGuiShiYing>())
                    {
                        //õ��ʯӢ
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
