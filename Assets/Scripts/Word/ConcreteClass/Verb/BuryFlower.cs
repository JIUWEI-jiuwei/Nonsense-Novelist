using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 葬花
/// </summary>
class BuryFlower : AbstractVerbs
{
    public void Awake()
    {
        skillID = 3;
        wordName = "葬花";
        bookName = BookNameEnum.HongLouMeng;
        description = "平生葬花杀人，我以落花剑葬你，不枉你异人之名";
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
       timer = 0;
    }

    private AI.AttackState attackState;//
    private int flowerNum;//花数量
    private float timer;//计时器


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
        else if (timer >= skillTime)
        {
            attackState = null;
            this.GetComponent<AbstractCharacter>().psy += flowerNum;
            flowerNum = 0;
        }
    }

    public override string PlaySentence()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null)
            return null;

        return "林间盛开的桃花随轻风飘落在地。\n" + character.wordName + "将飘落在地的桃花聚拢成团，并将其埋葬，为其哀悼。";

    }

}
