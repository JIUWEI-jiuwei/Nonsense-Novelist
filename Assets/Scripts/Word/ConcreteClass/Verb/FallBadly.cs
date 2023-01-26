using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ˤ
/// </summary>
class FallBadly : AbstractVerbs
{
    public override void Awake()
    {
        base.Awake();
        skillID = 15;
        wordName = "ˤ";
        bookName = BookNameEnum.allBooks;
        description = "ѧ��ˤ�����150%���������˺�����ѣ1.5�롣";
        nickname.Add("��");
        nickname.Add("˦");
        nickname.Add("Ͷ��");
        skillMode = gameObject.AddComponent<DamageMode>();
        (skillMode as DamageMode).isPhysics = true;
        skillMode.attackRange = new SingleSelector();
        skillEffectsTime = 2f;
        rarity = 1;
        needCD=2;
    }

    public override void UseVerbs(AbstractCharacter useCharacter)
    {
        base.UseVerbs(useCharacter);
        buffs.Add(skillMode.CalculateAgain(attackDistance, useCharacter)[0].gameObject.AddComponent<Dizzy>());
        buffs[0].maxTime = skillEffectsTime;
        SpecialAbility(useCharacter);
    }

    public override void SpecialAbility(AbstractCharacter useCharacter)
    {
        AbstractCharacter aim = skillMode.CalculateAgain(attackDistance, useCharacter)[0];
        skillMode.UseMode(useCharacter, useCharacter.atk*0.2f * (1 - aim.def / (aim.def + 20)), aim);
    }
    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null)
            return null;

        return  character.wordName + "���Ҽ��������˳�ȥ��";

    }
}
