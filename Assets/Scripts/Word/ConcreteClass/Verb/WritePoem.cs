using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 赋诗
/// </summary>
class WritePoem : AbstractVerbs
{
    public void Awake()
    {
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
    /// <summary>
    /// 提升30%精神力的攻击力,持续5秒
    /// </summary>
    public override void SpecialAbility(AbstractCharacter useCharacter)
    {
        foreach (GameObject aim in aims)
        {
            skillMode.UseMode(null,aim.GetComponent<AbstractCharacter>().psy * 0.3f, aim.GetComponent<AbstractCharacter>());
        }
        
    }
    override public void Update()
    {
        base.Update();
        if (now < skillEffectsTime)
        {
            now += Time.deltaTime;
        }
        else if (now > skillEffectsTime)
        {
            foreach (GameObject aim in aims)
            {
                skillMode.UseMode(null, -aim.GetComponent<AbstractCharacter>().psy * 0.3f, aim.GetComponent<AbstractCharacter>());
            }

        }
    }

    public override void UseVerbs(AbstractCharacter useCharacter)
    {
        base.UseVerbs(useCharacter);
        SpecialAbility(useCharacter);
    }
}
