using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �������ʵ�����ɫ/ǽ�ڵ���ײ
/// </summary>
public class WordCollisionShoot : MonoBehaviour
{
    /// <summary>�������� </summary>
    public AbstractWords0 absWord;
    /// <summary>��ʱ�� </summary>
    public float timer;

    public virtual void Awake()
    {
       
    }

    /// <summary>
    /// ����ʵ����ײ����ɫ��������ʩ�ӵ���ɫ����
    /// </summary>
    /// <param name="collision"></param>
    public virtual  void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Character"))
        {
            AbstractCharacter character = collision.gameObject.GetComponent<AbstractCharacter>();

            //�жϸô��������ݴ�/����/����
            //�Ȱ�absWord�ű����ڽ�ɫ���ϣ�Ȼ����ý�ɫ���ϵ�useAdj
            if (absWord.wordKind==WordKindEnum.verb)
            {
                AbstractVerbs b = this.GetComponent<AbstractVerbs>();
                collision.gameObject.AddComponent(b.GetType());
                character.skills.Add(b);
                Destroy(this.gameObject);

            }
            else if (absWord.wordKind==WordKindEnum.adj)
            {
                collision.gameObject.AddComponent(absWord.GetType());
                collision.gameObject.GetComponent<AbstractAdjectives>().UseAdj(collision.gameObject.GetComponent<AbstractCharacter>());
                Destroy(this.gameObject);
            }
            else if (absWord.wordKind==WordKindEnum.noun)
            {
                collision.gameObject.AddComponent(absWord.GetType());
                collision.gameObject.GetComponent<AbstractItems>().UseItems(collision.gameObject.GetComponent<AbstractCharacter>());
                Destroy(this.gameObject);
            }
        }
    }
    /// <summary>
    /// ��ʱ��(ʱ���������true
    /// </summary>
    /// <returns></returns>
    public virtual bool VanishTime(float time)
    {
        timer += Time.deltaTime;
        if (timer >= time)
        {
            timer = 0;
            return true;
        }
        return false;
    }
}
