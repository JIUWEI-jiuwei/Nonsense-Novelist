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
        skillMode = new ChangeATKMode();
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
    public override void Ability()
    {
        foreach (GameObject aim in aims)
        {
            aim.GetComponent<AbstractCharacter>().atk += (int)(aim.GetComponent<AbstractCharacter>().psy * 0.3f);
        }
        now += Time.deltaTime;
        if (now> skillEffectsTime)
        {
            foreach (GameObject aim in aims)
            {
                aim.GetComponent<AbstractCharacter>().atk -= (int)(aim.GetComponent<AbstractCharacter>().psy * 0.3f);
            }
        }
    }
}
