using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ����
/// </summary>
public class ChongNeng : WordCollisionShoot
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
                if (collision.gameObject.GetComponent<XinShenJiDang>())
                {
                    //���񼤵���
                    XinShenJiDang  a = collision.gameObject.GetComponent<XinShenJiDang>();
                    a.chongNeng = count;
                }
                else if (collision.gameObject.GetComponent<GuoMin>())
                {
                    //������
                    GuoMin a = collision.gameObject.GetComponent<GuoMin>();
                    a.chongNeng = count;
                }
                collision.gameObject.GetComponent<AbstractAdjectives>().UseAdj(collision.gameObject.GetComponent<AbstractCharacter>());
                Destroy(this.gameObject);
            }
            else if (absWord.wordKind == WordKindEnum.noun)
            {
                collision.gameObject.AddComponent(absWord.GetType());

                //����Ч��
                if (collision.gameObject.GetComponent<EXingZhongLiu>())
                {
                    //��������
                    EXingZhongLiu a = collision.gameObject.GetComponent<EXingZhongLiu>();
                    a.chongNeng = count;
                }

                collision.gameObject.GetComponent<AbstractItems>().UseItems(collision.gameObject.GetComponent<AbstractCharacter>());
                Destroy(this.gameObject);
            }
        }
    }
}
