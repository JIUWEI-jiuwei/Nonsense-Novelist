using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 赋诗
/// </summary>
class WritePoem : AbstractVerbs
{
    public override void Awake()
    {
        base.Awake();
        wordSort = WordSortEnum.verb;
        skillID = 1;
        wordName = "赋诗";
        bookName = BookNameEnum.HongLouMeng;
        description = "学会赋诗，可让周围的友军亢奋，获得30%精神力的攻击加成。";
        nickname.Add("作诗");
        attackDistance = 5;
        skillMode = gameObject.AddComponent<UpATKMode>();
        skillMode.attackRange = new CircleAttackSelector();//
        attackDistance = 5;
        skillTime = 0;
        skillEffectsTime = 5;
        cd = 18;
        maxCD=18;
        comsumeSP = 10;
        prepareTime = 2;
        afterTime = 0;
        allowInterrupt = true;
        possibility = 0;
    }

    private float now = 0;//计时
    private float[] records;//记录提升的攻击力
    /// <summary>
    /// 提升30%精神力的攻击力,持续5秒
    /// </summary>
    public override void SpecialAbility(AbstractCharacter useCharacter)
    {
        records=new float[aims.Length];
        now = 0;
        for(int i=0;i<aims.Length;i++)
        {
            AbstractCharacter a = aims[i].GetComponent<AbstractCharacter>();
            records[i] = a.psy * 0.3f;
            skillMode.UseMode(null,records[i], a);
            a.AddBuff(1);
        }
        
    }
    override public void FixedUpdate()
    {
        base.FixedUpdate();
        if (now < skillEffectsTime)
        {
            now += Time.deltaTime;
        }
        else if (now >= skillEffectsTime &&records!=null)
        {
            for (int i = 0; i < aims.Length; i++)
            {
                AbstractCharacter a=aims[i].GetComponent<AbstractCharacter>();
                a.atk -=records[i];
                a.RemoveBuff(1);
            }
            records = null;
        }
    }

    public override void UseVerbs(AbstractCharacter useCharacter)
    {
        base.UseVerbs(useCharacter);
        SpecialAbility(useCharacter);
    }

    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null)
            return null;

        return character.wordName + "被身边的美景所震撼，不由得诗性大发，颂唱起了诗歌“登山则情满于山，观海则情溢于海，吟咏之间，吐纳珠玉之声”。";

    }
}
