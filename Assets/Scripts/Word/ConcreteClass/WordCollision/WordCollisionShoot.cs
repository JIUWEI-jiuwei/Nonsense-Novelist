using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �������ʵ�����ɫ/ǽ�ڵ���ײ
/// </summary>
public class WordCollisionShoot : MonoBehaviour
{
    public AbstractWords0 absWord;





    /// <summary>
    /// ����ʵ����ײ����ɫ��������ʩ�ӵ���ɫ����
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Character"))
        {
            AbstractCharacter character = collision.gameObject.GetComponent<AbstractCharacter>();

            //�жϸô��������ݴʻ��Ƕ���
            if (absWord.GetType() == typeof(AbstractVerbs))
            {
                AbstractVerbs b = this.GetComponent<AbstractVerbs>();
                collision.gameObject.AddComponent(b.GetType());
                character.skills.Add(b);
                Destroy(this.gameObject);

            }
            else if (absWord.GetType() == typeof(AbstractAdjectives))
            {
                this.GetComponent<AbstractAdjectives>().UseAdj(collision.gameObject.GetComponent<AbstractCharacter>());
                Destroy(this.gameObject);
            }
        }
    }
}
