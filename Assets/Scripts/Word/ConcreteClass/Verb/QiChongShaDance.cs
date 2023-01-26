using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 七重纱之舞
/// </summary>
class QiChongShaDance : AbstractVerbs
{
    public override void Awake()
    {
        base.Awake();
        skillID = 6;
        wordName = "七重纱之舞";
        bookName = BookNameEnum.Salome;
        description = "学会七重纱之舞，让周围所有友军恢复5点魔法。";
        skillMode = gameObject.AddComponent<SelfMode>();
        skillMode.attackRange = new SingleSelector();
        skillEffectsTime =10;
        rarity = 3;
        needCD=10;
        description = "每一重都会卸下一层薄纱的迷人舞蹈，让周围的友军充满力量。";
    }

    public override void UseVerbs(AbstractCharacter useCharacter)
    {
        base.UseVerbs(useCharacter);
        buffs.Add(gameObject.AddComponent<QiWu>());
        buffs[0].maxTime = skillEffectsTime;
    }

    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null)
            return null;

        return "伴着轻风与身上挂坠碰撞的金属声，" + character.wordName + "开始蹁跹起舞。周围的人们都纷纷被这翩若惊鸿的舞姿激励了，并且感觉充满了力量。";

    }
}
