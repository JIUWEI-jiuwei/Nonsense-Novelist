using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// 动词：玩耍
/// </summary>
class WanShua : AbstractVerbs
{
    public override void Awake()
    {
        base.Awake();
        skillID = 3;
        wordName = "玩耍";
        bookName = BookNameEnum.ZooManual;
        description = "使友方亢奋，持续15s";

        skillMode = gameObject.AddComponent<UpATKMode>();

        skillEffectsTime = 15;
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
        buffs.Add(skillMode.CalculateAgain(attackDistance, useCharacter)[0].gameObject.AddComponent<KangFen>());
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
