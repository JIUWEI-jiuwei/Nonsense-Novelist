using System.Collections;
using System.Collections.Generic;
using UnityEngine;
class GunShoot : AbstractVerbs
{
    public override void Awake()
    {
        base.Awake();
        skillID = 10;
        wordName = "ǹ��";
        bookName = BookNameEnum.ElectronicGoal;
        description = "ѧ����������ö��ѻ�ø���Ļ��ᣬ����20�롣";
        skillMode = gameObject.AddComponent<DamageMode>();
        (skillMode as DamageMode).isPhysics = true;
        skillMode.attackRange =  new SingleSelector();
        skillEffectsTime = Mathf.Infinity;
        rarity = 1;
        needCD = 2;
        description = "ͨ�����ӵĹ��������岻�ḯ�ܣ��ٴλ������Ļ��ᡣ";

    }

    public override void UseVerbs(AbstractCharacter useCharacter)
    {
        base.UseVerbs(useCharacter);
        BasicAbility(useCharacter);
    }

    public override void BasicAbility(AbstractCharacter useCharacter)
    {
        AbstractCharacter aim = skillMode.CalculateAgain(attackDistance, useCharacter)[0];
        skillMode.UseMode(useCharacter, useCharacter.atk * (1 - aim.def / (aim.def + 20)),aim);
    }
    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        //if (character == null || aimState==null)
            //return null;

        return character.wordName + "����С��������������һ��Сȱ�ڣ�������֬�͹������С��ٽ���֬��������2��ͷ­����ֹͷ���ı��Ρ������������������ڼ����һ���£������Ϳ����������岻�������������ˡ�";

    }
}
