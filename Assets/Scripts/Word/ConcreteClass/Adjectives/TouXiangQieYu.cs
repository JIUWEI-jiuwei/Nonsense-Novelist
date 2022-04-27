using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Õµœ„«‘”Ò
/// </summary>
class TouXiangQieYu : AbstractAdjectives
{
    public void Awake()
    {
        adjID = 1;
        wordName = "Õµœ„«‘”Ò";
        chooseWay = ChooseWayEnum.canChoose;
        banAim.Add(gameObject.AddComponent<Girl>());
        skillMode=gameObject.AddComponent<DamageMode>();
        useAtFirst = false;
    }

    
    override public void UseVerbs(AbstractCharacter character)
    {
        base.UseVerbs(character);
        character.GetComponent<AbstractCharacter>().psy -= 20;
        SpecialAbility();
    }
}
