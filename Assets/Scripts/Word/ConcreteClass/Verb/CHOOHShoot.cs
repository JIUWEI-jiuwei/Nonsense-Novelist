using System.Collections;
using System.Collections.Generic;
using UnityEngine;
class CHOOHShoot : AbstractVerbs
{
    public override void Awake()
    {
        base.Awake();
        skillID = 13;
        wordName = "��������";
        bookName = BookNameEnum.PHXTwist;
        description = "ѧ���������䣬���150%���������˺�������2���������";
        skillMode = gameObject.AddComponent<DamageMode>();
        (skillMode as DamageMode).isPhysics= true;
        skillMode.attackRange = new SingleSelector();
        skillEffectsTime = 12;
        rarity = 1;
        needCD = 1;
        description = "��ȫ�������ټ�ѹ��������Ķ�Һ���Ը�ʴ���ס�";
    }


    public override void UseVerbs(AbstractCharacter useCharacter)
    {
        base.UseVerbs(useCharacter);
        buffs.Add(skillMode.CalculateAgain(attackDistance, useCharacter)[0].gameObject.AddComponent<FuShi>());
        buffs[0].maxTime = skillEffectsTime;
        BasicAbility(useCharacter);
    }

    public override void BasicAbility(AbstractCharacter useCharacter)
    {
        AbstractCharacter aim = skillMode.CalculateAgain(attackDistance, useCharacter)[0];
        skillMode.UseMode(useCharacter, useCharacter.atk*0.25f * (1 - aim.def / (aim.def + 20)), aim);
    }

    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null)
            return null;

        return character.wordName + "�Ķ����Լ����������壬ͻȻ�����������������һ�����Ե�Һ�壬��������������2��������";

    }
}
