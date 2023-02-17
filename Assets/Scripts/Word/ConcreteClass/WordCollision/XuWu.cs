using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ����
/// </summary>
public class XuWu : WordCollisionShoot
{
    public override void Awake()
    {
        base.Awake();

    }
    private void Update()
    {
        //ʱ��������ٴ���
        if (VanishTime(10))
        {
            Destroy(this.gameObject);
        }
    }
    public override bool VanishTime(float time)
    {
        return base.VanishTime(time);
    }
    /// <summary>
    /// �κ�һ��Ϊtrigger����øú���
    /// ��Խ��ɫ����ʧ��ֱ��ʱ�������ʧ
    /// </summary>
    /// <param name="collision"></param>
    public override void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Character"))
        {
            this.GetComponent<Collider2D>().isTrigger = true;

            AbstractCharacter character = collision.gameObject.GetComponent<AbstractCharacter>();
            
            //��absWord��ֵ
            absWord = Shoot.abs;
            //�жϸô��������ݴ�/����/����
            //�Ȱ�absWord�ű����ڽ�ɫ���ϣ�Ȼ����ý�ɫ���ϵ�useAdj
            if (absWord.wordKind == WordKindEnum.verb)
            {
                AbstractVerbs b = this.GetComponent<AbstractVerbs>();
                collision.gameObject.AddComponent(b.GetType());
                character.skills.Add(b);

            }
            else if (absWord.wordKind == WordKindEnum.adj)
            {
                collision.gameObject.AddComponent(absWord.GetType());
                collision.gameObject.GetComponent<AbstractAdjectives>().UseAdj(collision.gameObject.GetComponent<AbstractCharacter>());
            }
            else if (absWord.wordKind == WordKindEnum.noun)
            {
                collision.gameObject.AddComponent(absWord.GetType());
                collision.gameObject.GetComponent<AbstractItems>().UseItems(collision.gameObject.GetComponent<AbstractCharacter>());
            }
        }
        this.GetComponent<Collider2D>().isTrigger = false;

    }

}
