using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 偷香窃玉
/// </summary>
class TouXiangQieYu : AbstractAdjectives
{
    public override void Awake()
    {
        base.Awake();
        wordSort = WordSortEnum.adj;
        adjID = 1;
        wordName = "偷香窃玉";
        bookName = BookNameEnum.HongLouMeng;
        description = "与女性偷情，并不负责的离去，留下独自神伤";
        chooseWay = ChooseWayEnum.canChoose;
        banAim.Add(gameObject.AddComponent<Girl>());
        skillMode=gameObject.AddComponent<DamageMode>();
        useAtFirst = false;
    }

    
    
    override public void UseVerbs(AbstractCharacter aimCharacter)
    {
        base.UseVerbs(aimCharacter);
        skillMode.UseMode(null, 20 *(1- aimCharacter.san/(aimCharacter.san+20)), aimCharacter);
    }

    public override void SpecialAbility(AbstractCharacter aimCharacter)
    {
       
    }

    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null)
            return null;

        return character.wordName + "说“琏二爷，这样不好吧。”";

    }
}
