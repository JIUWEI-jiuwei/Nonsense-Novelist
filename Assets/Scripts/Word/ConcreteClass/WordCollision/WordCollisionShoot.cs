using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 负责词条实体与角色/墙壁的碰撞
/// </summary>
public class WordCollisionShoot : MonoBehaviour
{
    public AbstractWords0 absWord;


    private void Awake()
    {
       
    }
    private void Start()
    {
        
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

            //判断该词条是形容词/动词/名词
            //先把absWord脚本挂在角色身上，然后调用角色身上的useAdj
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
}
