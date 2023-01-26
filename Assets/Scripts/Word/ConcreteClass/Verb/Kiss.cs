using System.Collections;
using System.Collections.Generic;
using UnityEngine;
class Kiss : AbstractVerbs
{
    public override void Awake()
    {
        base.Awake();
        skillID = 7;
        wordName = "����";
        bookName = BookNameEnum.Salome;
        description = "ѧ����������ö��ѻ�ø���Ļ��ᣬ����20�롣";
        skillMode = gameObject.AddComponent<DamageMode>();
        (skillMode as DamageMode).isPhysics = false;
        skillMode.attackRange =  new SingleSelector();
        skillEffectsTime = 10;
        rarity = 2;
        needCD = 6;
        description = "ͨ�����ӵĹ��������岻�ḯ�ܣ��ٴλ������Ļ��ᡣ";

    }

    public override void UseVerbs(AbstractCharacter useCharacter)
    {
        base.UseVerbs(useCharacter);
        buffs.Add(skillMode.CalculateAgain(attackDistance, useCharacter)[0].gameObject.AddComponent<FuHuo>());
        buffs[0].maxTime = skillEffectsTime;
        SpecialAbility(useCharacter);
    }

    public override void SpecialAbility(AbstractCharacter useCharacter)
    {
        AbstractCharacter aim = skillMode.CalculateAgain(attackDistance, useCharacter)[0];
        skillMode.UseMode(useCharacter, useCharacter.psy * 2 * (1 - aim.san / (aim.san + 20)),aim);
    }
    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        //if (character == null || aimState==null)
            //return null;

        return character.wordName + "����С��������������һ��Сȱ�ڣ�������֬�͹������С��ٽ���֬��������2��ͷ­����ֹͷ���ı��Ρ������������������ڼ����һ���£������Ϳ����������岻�������������ˡ�";

    }
}
