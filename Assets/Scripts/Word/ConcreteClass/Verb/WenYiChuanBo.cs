using System.Collections;
using System.Collections.Generic;
using UnityEngine;
class WenYiChuanBo : AbstractVerbs
{
    public override void Awake()
    {
        base.Awake();
        skillID = 11;
        wordName = "瘟疫传播";
        bookName = BookNameEnum.FluStudy;
        description = "学会防腐术，让队友获得复活的机会，持续20秒。";
        skillMode = gameObject.AddComponent<DamageMode>();
        (skillMode as DamageMode).isPhysics = true;
        skillMode.attackRange =  new SingleSelector();
        skillEffectsTime = 5;
        rarity = 2;
        needCD = 2;
        description = "通过复杂的工序，让肉体不会腐败，再次获得生存的机会。";

    }

    public override void UseVerbs(AbstractCharacter useCharacter)
    {
        base.UseVerbs(useCharacter);
        AbstractCharacter center = skillMode.CalculateAgain(attackDistance, useCharacter)[0];
        //中心得到传播
        buffs.Add(center.gameObject.AddComponent<ChuanBo>());
        //相邻得到患病
        AbstractCharacter[] neighbors = (buffs[0] as ChuanBo).GetNeighbor(center);
        foreach (AbstractCharacter n in neighbors)
        {
            buffs.Add(n.gameObject.AddComponent<Ill>());
        }
        //中心得到患病
        buffs.Add(center.gameObject.AddComponent<Ill>());

        foreach (AbstractBuff buff in buffs)
        {
            buff.maxTime = skillEffectsTime;
        }
    }

    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        //if (character == null || aimState==null)
            //return null;

        return character.wordName + "拿起小刀，将腹部开出一个小缺口，并将香脂油灌满其中。再将树脂填入名字2的头颅，防止头部的变形。接下来将他整个埋于碱粉中一个月，这样就可以做到肉体不被腐朽所困扰了。";

    }
}
