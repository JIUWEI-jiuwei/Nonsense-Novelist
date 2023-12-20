using AI;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.UI;

class Boss_Huaiyizhuyi : AbstractCharacter
{
    private bool hasLowThanHalf = false;
    override public void Awake()
    {
        base.Awake();
        characterID = 0;
        wordName = "怀疑主义";
        bookName = BookNameEnum.allBooks;
        gender = GenderEnum.noGender;
        camp = CampEnum.stranger;
        hp =maxHp  =250;
        atk = 10;
        def = 30;
        psy = 15;
        san = 30;
        maxSkillsCount = 3;
        trait =gameObject.AddComponent<Sentimental>();
        roleName = "思潮";
        attackInterval = 2.2f;
         attackDistance = 200;
        brief = "";
        description = "";


        situation = GameObject.Find("Circle5.5").GetComponentInChildren<Situation>();
        if (situation == null)
            print("situation5.5==null");
    }
    private void Start()
    {
        skillMode = gameObject.AddComponent<DamageMode>();
        
        myState.event_EveryZeroOne += IsHpLowThanHalf;

       this.AddVerb(gameObject.AddComponent<RenZhiGuHua>());
    }

     AbstractSkillMode skillMode;
    AbstractCharacter[] aims;
    
    float record;

    public void IsHpLowThanHalf()
    {
        if (hasLowThanHalf)
        {
            myState.event_EveryZeroOne -= IsHpLowThanHalf;
            return;
        }
        print("IsHpLowThanHalf++Cheak");
        if (hp <= (maxHp / 2))
        {
            print("IsHpLowThanHalf++trigger");
            hasLowThanHalf = true;

            //血量过半时，为自身增加caiyilian的技能
            this.AddVerb(gameObject.AddComponent<Caiyilian>());

        }
    }

    //public override bool AttackA()
    //{
    //    if (base.AttackA())
    //    {
    //        aims = skillMode.CalculateAgain(100, this);
    //        //夺取场上每个敌人5点意志力，加在自己身上
    //        foreach (AbstractCharacter aim in aims)
    //        {
    //            record = aim.san;
    //            aim.san -= 5;
    //            record = record - aim.san;
    //            san += record;
    //        }
    //        return true;s
    //    }
    //    return false;
    //}


    //public override bool AttackA()
    //{

    //    if (base.AttackA())
    //    {
    //        print("boss怀疑主义的大招释放了");
    //        /*对随机的角色A释放，让其不断攻击随机角色B，持续5秒，伤害结果降低50%
    //        结束后，被攻击者B随机攻击角色C（角色可以反复获得，即C也可以是A），效果一致，依据此循环，直到boss死亡
    //        简单来说，就是一个会无限传导的仇恨*/
    //        //随机找一个aim
    //        aims = skillMode.CalculateAgain(100, this);
    //        //给aim一个特殊buff，让其攻击B

    //        AbstractAdjectives adj = aims[0].gameObject.AddComponent<Caiyilian>();
    //        adj.UseAdj(aims[0].gameObject.GetComponent<AbstractCharacter>());
    //        //在增加了猜疑链buff后，角色寻找目标的机制会变成随机
    //        return true;
    //    }
    //    return false;

    //}
    public override string ShowText(AbstractCharacter otherChara)
    {
        if (otherChara != null)
            return otherChara.wordName + "早已看见多了一个妹妹，细看形容，只见泪光点点，娇喘微微，闲静时如姣花照水，行动处似弱柳扶风，" + otherChara.wordName + "笑道：“这个妹妹，我曾见过的”";
        else
            return null;
    }
    public override string CriticalText(AbstractCharacter otherChara)
    {
        if (otherChara != null)
            return "“我就知道，别人不挑剩下的也不给我。”林黛玉轻捻一朵花瓣，向" + otherChara.wordName + "飞去";
        else
            return null;
    }

    public override string LowHPText()
    {
        return "黛玉对侍女喘息道：“笼上火盆罢。”便将一对帕子，一叠诗稿焚尽于火盆中。";
    }
    public override string DieText()
    {
        return "“宝玉…宝玉…你好……”黛玉没说完便合上了双眼。";
    }

}
