using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 茶杯
/// </summary>
class TeaCup : AbstractItems
{
    public override void Awake()
    {
        base.Awake();
        itemID = 1;
        wordName = "茶杯";
        bookName = BookNameEnum.HongLouMeng;
        description = "一个相当精致的茶杯，提升3点意志";
        VoiceEnum = MaterialVoiceEnum.Ceram;
        rarity = 0;
    }

    public override void UseItems(AbstractCharacter chara)
    {
        base.UseItems(chara);
        chara.psy += 2;
    }

    public override void UseVerbs()
    {
        base.UseVerbs();

    }

    public override void End()
    {
        base.End();
        aim.psy-= 2;
    }

    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null)
            return null;

            return character.wordName+"拿出了一个上大下小的碧绿方形茶杯。";
        
    }
}
