using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// “œÀ·≈Á…‰
/// </summary>
class CHOOHShoot : AbstractVerbs
{
    public void Awake()
    {
        skillID = 7;
        wordName = "“œÀ·≈Á…‰";
        bookName = BookNameEnum.PHXTwist;
        attackDistance = 5;
        skillMode = gameObject.AddComponent<DamageMode>();
        skillMode.attackRange = new CircleAttackSelector();//
        attackDistance = 5;
        skillTime = 0;
        skillEffectsTime = 7;
        cd=maxCD=3;
        comsumeSP = 10;
        prepareTime = 0.3f;
        afterTime = 0;
        allowInterrupt = false;
        possibility = 0;
    }


    private float now = 0;//º∆ ±
    /// <summary>
    /// ∏Ø ¥£¨ø…µ˛º”9¥Œ£¨√ø¥Œ-2∑¿”˘
    /// </summary>
    public override void SpecialAbility(AbstractCharacter useCharacter)
    {
        
        for (int i = 0; i < aims.Length; i++)
        {
            AbstractCharacter a = aims[i].GetComponent<AbstractCharacter>();
            if (a.buffs[10] < 9)
            {
                a.def -= 2;
                a.AddBuff(10);
                now = 0;
            }
        }
    }
    override public void FixedUpdate()
    {
        base.FixedUpdate();
        if (now < skillEffectsTime)
        {
            now += Time.deltaTime;
        }
        else if (now >= skillEffectsTime)
        {
            for (int i = 0; i < aims.Length; i++)
            {
                AbstractCharacter a = aims[i].GetComponent<AbstractCharacter>();
                a.def += 2;
                a.RemoveBuff(10);
            }
        }
    }

    public override void UseVerbs(AbstractCharacter useCharacter)
    {
        base.UseVerbs(useCharacter);
        SpecialAbility(useCharacter);
    }
}
