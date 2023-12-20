using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// 动词：沙浴
/// </summary>
class ShaYu : AbstractVerbs
{
    static public string s_description = "治疗10+100%<sprite name=\"san\">，消除所有负面状态";
    static public string s_wordName = "沙浴";
    public override void Awake()
    {
        base.Awake();
        skillID = 4;
        wordName = "沙浴";
        bookName = BookNameEnum.ZooManual;
<<<<<<< HEAD
        description = "治疗10+100%<sprite name=\"san\">，消除所有负面状态";
=======
        description = "治疗10+100%意志，消除所有负面状态";
>>>>>>> 66fe0047b38250f01931638095da1ca5d7de0454

        skillMode = gameObject.AddComponent<CureMode>();

        skillEffectsTime = Mathf.Infinity;
        rarity = 1;
        needCD = 4;
    }



    /// <summary>
    /// 亢奋
    /// </summary>
    /// <param name="useCharacter">施法者</param>
    public override void UseVerb(AbstractCharacter useCharacter)
    {
        base.UseVerb(useCharacter);
        BasicAbility(useCharacter);
    }


    public override void BasicAbility(AbstractCharacter useCharacter)
    {
        //治疗10+100%意志
        AbstractCharacter aim = skillMode.CalculateAgain(attackDistance, useCharacter)[0];
        aim.CreateFloatWord(
        skillMode.UseMode(useCharacter, 10+ useCharacter.san*useCharacter.sanMul*1, aim)
        , FloatWordColor.heal, true);
    }

    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null)
            return null;

        return "林间盛开的桃花随轻风飘落在地。\n"+character.wordName+"将飘落在地的桃花聚拢成团，并将其埋葬，为其哀悼。“花谢花飞花满天，红香消断有谁怜？”";

    }
    
}
