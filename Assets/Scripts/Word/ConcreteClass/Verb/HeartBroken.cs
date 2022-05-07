using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 心碎
/// </summary>
class HeartBroken : AbstractVerbs
{
    public void Awake()
    {
        skillID = 2;
        wordName = "心碎";
        bookName = BookNameEnum.allBooks;
        description = "令目标心如刀绞。";
        nickname.Add( "刺痛");
        banAim.Add(gameObject.AddComponent<Sense>());
        skillMode = gameObject.AddComponent<DamageMode>();
        skillMode.attackRange = new CircleAttackSelector();//
        percentage = 1.5f;
        attackDistance = 999;
        skillTime = 0;
        skillEffectsTime = 3;
        cd=maxCD=5;
        comsumeSP = 5;
        prepareTime = 0.5f;
        afterTime = 1;
        allowInterrupt = false;
        possibility = 0;
    }

    private AbstractCharacter aimState;//目标的抽象角色类
    /// <summary>
    /// 造成150%精神力的伤害
    /// </summary>
    /// <param name="useCharacter">施法者</param>
    public override void UseVerbs(AbstractCharacter useCharacter)
    {
        base.UseVerbs(useCharacter);
        foreach (GameObject aim in aims)
        {
            aimState = aim.GetComponent<AbstractCharacter>();
            skillMode.UseMode(useCharacter,aim.GetComponent<AbstractCharacter>().psy * percentage *(1-aimState.def/(aimState.def+20)), aimState);
        }
        SpecialAbility(useCharacter);
    }

    private float now = 0;//计时
    private int[] records;//记录降低的精神力值
    /// <summary>
    /// 降低30%精神力,持续3秒
    /// </summary>
    public override void SpecialAbility(AbstractCharacter useCharacter)
    {
        records = new int[aims.Length];
        now = 0;
        for (int i=0;i<aims.Length;i++)
        {
            records[i] = (int)(aims[i].GetComponent<AbstractCharacter>().psy * 0.3f);
            aims[i].GetComponent<AbstractCharacter>().psy-=records [i];
        }
    }
    override public  void Update()
    {
        base.Update();
        if (now < skillEffectsTime)
        {
            now += Time.deltaTime;
        }
        else if (now >= skillEffectsTime)//时间到
        {
            for (int i = 0; i < aims.Length; i++)
            {
                aims[i].GetComponent<AbstractCharacter>().psy += records[i];
            }
        }
    }
}
