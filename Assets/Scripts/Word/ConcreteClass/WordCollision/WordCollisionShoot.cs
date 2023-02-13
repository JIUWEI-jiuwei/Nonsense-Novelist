using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 负责词条实体与角色/墙壁的碰撞
/// </summary>
public class WordCollisionShoot : MonoBehaviour
{
    private AbstractWords0 absWord;


    private void Awake()
    {
        absWord = this.GetComponent<AbstractWords0>();
    }


    /// <summary>
    /// 词条实体碰撞到角色，将词条施加到角色身上
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Character"))
        {
            AbstractCharacter character = collision.gameObject.GetComponent<AbstractCharacter>();

            //判断该词条是形容词还是动词
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
