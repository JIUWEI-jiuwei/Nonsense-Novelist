using System.Collections;
using System.Collections.Generic;
using UnityEngine;
class TuLingCeShi : AbstractVerbs
{
    public override void Awake()
    {
        base.Awake();
        skillID = 9;
        wordName = "ͼ�����";
        bookName = BookNameEnum.ElectronicGoal;
        description = "ʹ�����ܵ��ϴ����˺�";
        skillMode = gameObject.AddComponent<DamageMode>();
        (skillMode as DamageMode).isPhysics = false;
        skillMode.attackRange =  new SingleSelector();
        skillEffectsTime = Mathf.Infinity;
        rarity = 3;
        needCD = 4;
    

    }

    public override void UseVerbs(AbstractCharacter useCharacter)
    {
        base.UseVerbs(useCharacter);
        BasicAbility(useCharacter);
    }

    public override void BasicAbility(AbstractCharacter useCharacter)
    {
        AbstractCharacter aim = skillMode.CalculateAgain(attackDistance, useCharacter)[0];
        skillMode.UseMode(useCharacter, (aim.atk-aim.psy) * 10 * (1 - aim.san / (aim.san + 20)),aim);
    }
    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        //if (character == null || aimState==null)
            //return null;

        return character.wordName + "����С��������������һ��Сȱ�ڣ�������֬�͹������С��ٽ���֬��������2��ͷ­����ֹͷ���ı��Ρ������������������ڼ����һ���£������Ϳ����������岻�������������ˡ�";

    }
}
