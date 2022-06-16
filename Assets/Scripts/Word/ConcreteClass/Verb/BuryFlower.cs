using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 葬花
/// </summary>
class BuryFlower : AbstractVerbs
{
    public override void Awake()
    {
        base.Awake();
        wordSort = WordSortEnum.verb;
        skillID = 3;
        wordName = "葬花";
        bookName = BookNameEnum.HongLouMeng;
        description = "将纷纷落英聚拢于一团，并埋葬至土壤中。此举能让自己的精神更强大";
        skillMode = gameObject.AddComponent<UpPSYMode>();
        skillMode.attackRange = new CircleAttackSelector();//
        attackDistance = 0;
        skillTime = 7;
        skillEffectsTime = 0;
        cd=maxCD=40;
        comsumeSP = 15;
        prepareTime = 1f;
        afterTime = 0;
        allowInterrupt = true;
        possibility = 0;

    }

    /// <summary>
    /// 开启技能后，每次被本角色攻击的单位将产生1朵落花，可以无限叠加，直到持续时间结束，结束时所有花飞到本角色手中，并将其埋葬，每朵收集的花提升1点精神力
    /// </summary>
    public override void SpecialAbility(AbstractCharacter useCharacter)
    {
       attackState= useCharacter.gameObject.GetComponent<AI.AttackState>();
        useChara = useCharacter;
       timer = 0;
    }

    private AI.AttackState attackState;//
    private int flowerNum;//花数量
    private float timer;//计时器
    private AbstractCharacter useChara;

    /// <summary>
    /// 攻击产生落花
    /// </summary>
    public void Update()
    {
        //没暂停游戏&&处于释放期间&&平A了,增加落花
        if (Time.deltaTime!=0 && attackState!=null && attackState.attackAtime == 0)
            flowerNum++;
    }

    
    /// <summary>
    /// 计时
    /// </summary>
    public override void FixedUpdate()
    {
        base.FixedUpdate();
        if (timer < skillTime)
        {
            timer += Time.deltaTime;
        }
        else if (timer >= skillTime)//相当于落花数量的精神力提高
        {
            attackState = null;
            if (useChara != null)
            {
                useChara.psy += flowerNum;
            }
            flowerNum = 0;
        }
    }

    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null)
            return null;

        return "林间盛开的桃花随轻风飘落在地。\n"+character.wordName+"将飘落在地的桃花聚拢成团，并将其埋葬，为其哀悼。“花谢花飞花满天，红香消断有谁怜？”";

    }

}
