using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// 葬花
/// </summary>
class BuryFlower : AbstractVerbs
{
    public override void Awake()
    {
        base.Awake();
        skillID = 2;
        wordName = "葬花";
        bookName = BookNameEnum.HongLouMeng;
        description = "自身获得“花瓣”";
        skillMode = gameObject.AddComponent<UpPSYMode>();
        skillEffectsTime = Mathf.Infinity;
        rarity = 3;
        needCD = 2;
    }

    /// <summary>
    /// 花瓣
    /// </summary>
    /// <param name="useCharacter">施法者</param>
    public override void UseVerbs(AbstractCharacter useCharacter)
    {
        base.UseVerbs(useCharacter);
        buffs.Add(skillMode.CalculateAgain(attackDistance, useCharacter)[0].gameObject.AddComponent<HuaBan>());
        buffs[0].maxTime = skillEffectsTime;
    }

    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null)
            return null;

        return "林间盛开的桃花随轻风飘落在地。\n"+character.wordName+"将飘落在地的桃花聚拢成团，并将其埋葬，为其哀悼。“花谢花飞花满天，红香消断有谁怜？”";

    }
    
}
