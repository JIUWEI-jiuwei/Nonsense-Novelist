using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 服药
/// </summary>
class FuYao : AbstractVerbs
{
    public override void Awake()
    {
        base.Awake();
        wordSort = WordSortEnum.verb;
        skillID = 5;
        wordName = "服药";
        bookName = BookNameEnum.HongLouMeng;
        description = "学会服药，恢复20点生命，解除负面效果。";
        banUse.Add(gameObject.AddComponent<Biology>());
        skillMode = gameObject.AddComponent<CureMode>();
        skillMode.attackRange = new SingleSelector();
        percentage = Mathf.Infinity;//回满(不用此变量）
        attackDistance = 2;
        skillTime = 0;
        skillEffectsTime = 0;
        cd=maxCD=6;
        comsumeSP = 0;
        prepareTime = 0.5f;
        afterTime = 0;
        allowInterrupt = false;
        possibility = 0;
        description = "";
    }
    /// <summary>
    /// 回满血
    /// </summary>
    /// <param name="useCharacter">施法者</param>
    public override void UseVerbs(AbstractCharacter useCharacter)
    {
        useCharacter.teXiao.PlayTeXiao("LengXiangWan");
        base.UseVerbs(useCharacter);
        foreach (AbstractCharacter aim in aims)
        {
            aim.hp = aim.maxHP;
        }
        SpecialAbility(useCharacter);
    }
    /// <summary>
    /// 解除所有负面状态
    /// </summary>
    public override void SpecialAbility(AbstractCharacter useCharacter)
    {
        useCharacter.dizzyTime = 0;
    }

    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null)
            return null;

        return character.wordName + "曾从一海上来的僧人学得一仙方，给名字2服下了这仙方，名为冷香丸。";

    }
}
