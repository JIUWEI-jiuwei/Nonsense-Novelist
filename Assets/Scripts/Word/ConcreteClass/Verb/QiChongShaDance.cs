using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 七重纱之舞
/// </summary>
class QiChongShaDance : AbstractVerbs
{
    public void Awake()
    {
        skillID = 6;
        wordName = "七重纱之舞";
        bookName = BookNameEnum.Salome;
        banUse.Add(gameObject.AddComponent<Girl>());
        skillMode = gameObject.AddComponent<SpecialMode>();
        skillMode.attackRange = new CircleAttackSelector();
        percentage = 5;// 让所有友军回复5点SP
        attackDistance = 7;
        skillTime = 0;
        skillEffectsTime = 0;
        cd=maxCD=5;
        comsumeSP = 0;
        prepareTime = 0;
        afterTime = 0;
        allowInterrupt = false;
        possibility = 0;
    }
    /// <summary>
    /// 让所有友军回复5点SP
    /// </summary>
    /// <param name="useCharacter">施法者</param>
    public override void UseVerbs(AbstractCharacter useCharacter)
    {
        base.UseVerbs(useCharacter);
        foreach (GameObject aim in aims)
        {
            AbstractCharacter aimState= aim.GetComponent<AbstractCharacter>();
            skillMode.UseMode(useCharacter,percentage, aimState);
        }
    }

    public override string PlaySentence()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null)
            return null;

        return "伴着轻风与身上挂坠碰撞的金属声，" + character.wordName + "开始蹁跹起舞。周围的人们都纷纷被这翩若惊鸿的舞姿激励了，并且感觉充满了力量。";

    }
}
