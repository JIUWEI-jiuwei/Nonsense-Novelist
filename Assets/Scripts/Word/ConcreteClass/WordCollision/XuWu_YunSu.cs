using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 碰撞机制：通感 虚无
/// </summary>
public class XuWu_YunSu : WordCollisionShoot
{

    bool hasShootOut = false;
    Rigidbody2D rb;
    Coroutine coroutineTimer=null;

    Color color = Color.blue;
    public override void Awake()
    {
        base.Awake();

        color.a = 100;
        this.GetComponent<SpriteRenderer>().color= color;


        this.gameObject.GetComponent<Collider2D>().sharedMaterial = Resources.Load<PhysicsMaterial2D>("Other/word_noF");
        this.gameObject.GetComponent<Collider2D>().isTrigger = true;
        rb = GetComponent<Rigidbody2D>();

        //absWord = Shoot.abs;
    }
    private void Update()
    {
        //时间结束销毁词条

        if (rb.velocity.sqrMagnitude < 0.1f)
            return;

        if (hasShootOut)
            return;

        hasShootOut = true;

        if (coroutineTimer != null)
            StopCoroutine(coroutineTimer);
        coroutineTimer=StartCoroutine(Timer());

        
    }

IEnumerator Timer()
{
    yield return new WaitForSeconds(10);
    Destroy(this.gameObject);
    print("虚无纸条摧毁");
        StopAllCoroutines();
}


    /// <summary>
    /// 任何一方为trigger则调用该函数
    /// 穿越角色不消失，直至时间结束消失
    /// </summary>
    /// <param name="collision"></param>
    public override void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Character"))
        {
            AbstractCharacter character = collision.gameObject.GetComponent<AbstractCharacter>();

            //给absWord赋值
            //absWord = Shoot.abs;
            print(absWord.wordName + "被虚无给了角色" + character.name);

            //判断该词条是形容词/动词/名词
            //先把absWord脚本挂在角色身上，然后调用角色身上的useAdj
            if (absWord.wordKind == WordKindEnum.verb)
            {
                AbstractVerbs b = this.GetComponent<AbstractVerbs>();
               
               // collision.gameObject.AddComponent(b.GetType());

                character.AddVerb(collision.gameObject.AddComponent(b.GetType()) as AbstractVerbs);

            }
            else if (absWord.wordKind == WordKindEnum.adj)
            {
                AbstractAdjectives adj = collision.gameObject.AddComponent(absWord.GetType()) as AbstractAdjectives;
                adj.UseAdj(collision.gameObject.GetComponent<AbstractCharacter>());
            }
            else if (absWord.wordKind == WordKindEnum.noun)
            {
                AbstractItems noun = collision.gameObject.AddComponent(absWord.GetType()) as AbstractItems;
                noun.UseItem(collision.gameObject.GetComponent<AbstractCharacter>());
            }
        }

    }
}
