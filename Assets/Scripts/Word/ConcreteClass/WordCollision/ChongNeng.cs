using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 碰撞机制：递进 充能
/// </summary>
public class ChongNeng : WordCollisionShoot
{

    static public string s_description = "每次与墙壁碰撞都强化词条效果";
    static public string s_wordName = "递进 充能";

    /// <summary>碰撞次数 </summary>
    private int count = 0;
    Color color = Color.red + Color.white * 0.6f;
    Color colorWhite = new Color(1, 1, 1, 0);
    public override void Awake()
    {
        base.Awake();
        this.GetComponent<SpriteRenderer>().color = color;
        absWord = Shoot.abs;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
<<<<<<< HEAD
        if (CharacterManager.instance.pause)
            return;

=======
>>>>>>> 66fe0047b38250f01931638095da1ca5d7de0454
        if (collision.transform.tag == "wall")
        {
            count++;
            this.GetComponent<SpriteRenderer>().color -= colorWhite * 0.3f;
<<<<<<< HEAD
           
=======
            Debug.Log("(充能)碰撞次数现在是" + count);
>>>>>>> 66fe0047b38250f01931638095da1ca5d7de0454
        }
    }
    public override void OnTriggerEnter2D(Collider2D collision)
    {
        //给absWord赋值
        //absWord = Shoot.abs;

        if (collision.gameObject.layer == LayerMask.NameToLayer("Character"))
        {
            AbstractCharacter character = collision.gameObject.GetComponent<AbstractCharacter>();

            //判断该词条是形容词/动词/名词
            //先把absWord脚本挂在角色身上，然后调用角色身上的useAdj
            if (absWord.wordKind == WordKindEnum.verb)
            {
                AbstractVerbs b = this.GetComponent<AbstractVerbs>();
                character.AddVerb(collision.gameObject.AddComponent(b.GetType()) as AbstractVerbs);
<<<<<<< HEAD
  
=======
>>>>>>> 66fe0047b38250f01931638095da1ca5d7de0454
                Destroy(this.gameObject);

            }
            else if (absWord.wordKind == WordKindEnum.adj)
            {
                AbstractAdjectives adj=collision.gameObject.AddComponent(absWord.GetType()) as AbstractAdjectives;
                (adj as IChongNeng).ChongNeng(count);
                adj.UseAdj(collision.gameObject.GetComponent<AbstractCharacter>());
                print(this.gameObject.name);
                Destroy(this.gameObject);
            }
            else if (absWord.wordKind == WordKindEnum.noun)
            {
                AbstractItems item=collision.gameObject.AddComponent(absWord.GetType()) as AbstractItems;
                (item as IChongNeng).ChongNeng(count);
                item.UseItem(collision.gameObject.GetComponent<AbstractCharacter>());
                Destroy(this.gameObject);
            }
        }
    }
}

interface IChongNeng
{
    public void ChongNeng(int times);
}
