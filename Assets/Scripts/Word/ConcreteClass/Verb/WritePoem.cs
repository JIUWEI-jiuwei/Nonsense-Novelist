using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 赋诗
/// </summary>
class WritePoem : AbstractVerbs
{
    public override void Awake()
    {
        base.Awake();
        wordSort = WordSortEnum.verb;
        skillID = 1;
        wordName = "赋诗";
        bookName = BookNameEnum.HongLouMeng;
        description = "吟诗作对，好不快活";
        nickname.Add("作诗");
        attackDistance = 5;
        skillMode = gameObject.AddComponent<UpATKMode>();
        skillMode.attackRange = new CircleAttackSelector();//
        attackDistance = 5;
        skillTime = 0;
        skillEffectsTime = 5;
        cd=maxCD=18;
        comsumeSP = 10;
        prepareTime = 2;
        afterTime = 0;
        allowInterrupt = true;
        possibility = 0;
    }

    private float now = 0;//计时
    private float[] records;//记录提升的攻击力
    /// <summary>
    /// 提升30%精神力的攻击力,持续5秒
    /// </summary>
    public override void SpecialAbility(AbstractCharacter useCharacter)
    {
        records=new float[aims.Length];
        now = 0;
        for(int i=0;i<aims.Length;i++)
        {
            AbstractCharacter a = aims[i].GetComponent<AbstractCharacter>();
            records[i] = a.psy * 0.3f;
            skillMode.UseMode(null,records[i], a);
            a.AddBuff(1);
        }
        
    }
    override public void FixedUpdate()
    {
        base.FixedUpdate();
        if (now < skillEffectsTime)
        {
            now += Time.deltaTime;
        }
        else if (now >= skillEffectsTime &&records!=null)
        {
            for (int i = 0; i < aims.Length; i++)
            {
                AbstractCharacter a=aims[i].GetComponent<AbstractCharacter>();
                a.atk -=records[i];
                a.RemoveBuff(1);
            }
            records = null;
        }
    }

    public override void UseVerbs(AbstractCharacter useCharacter)
    {
        base.UseVerbs(useCharacter);
        SpecialAbility(useCharacter);
    }
}
