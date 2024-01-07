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
                AbstractAdjectives adj = collision.gameObject.AddComponent(absWord.GetType()) as AbstractAdjectives;
                (adj as IJiHuo).JiHuo(count >= 3);
                adj.UseAdj(collision.gameObject.GetComponent<AbstractCharacter>());
                Destroy(this.gameObject);
            }
            else if (absWord.wordKind == WordKindEnum.noun)
            {
                AbstractItems adj = collision.gameObject.AddComponent(absWord.GetType()) as AbstractItems;
                (adj as IJiHuo).JiHuo(count>=3);
                adj.UseItem(collision.gameObject.GetComponent<AbstractCharacter>());
                Destroy(this.gameObject);
            }
        }
    }
}
interface IJiHuo
{
    public void JiHuo(bool value);
}
