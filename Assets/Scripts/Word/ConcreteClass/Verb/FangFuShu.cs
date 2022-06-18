using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 防腐术
/// </summary>
class FangFuShu : AbstractVerbs
{
    public override void Awake()
    {
        base.Awake();
        wordSort = WordSortEnum.verb;
        skillID = 7;
        wordName = "防腐术";
        bookName = BookNameEnum.EgyptMyth;
        description = "学会防腐术，让队友获得复活的机会，持续20秒。";
        skillMode = gameObject.AddComponent<CureMode>();
        skillMode.attackRange = new CircleAttackSelector();
        percentage = 0;
        attackDistance = 5;
        skillTime = 0;
        skillEffectsTime = 20;
        cd=maxCD=50;
        comsumeSP = 20;
        prepareTime = 0;
        afterTime = 0;
        allowInterrupt = false;
        possibility = 0;
        description = "通过复杂的工序，让肉体不会腐败，再次获得生存的机会。";

        aimState = this.GetComponent<AI.MyState0>();//2.获取目标（挂在目标上时）
        if (aimState != null)
        {
            //删掉触发死亡的条件
            foreach (AI.AbstractState state in aimState.allState)
            {
                state.triggers.Remove(state.triggers.Find(p => p.id == AI.TriggerID.NoHealth));
            }
        }
    }


    /// <summary>
    /// 复活，使队友获得20可复活的状态
    /// </summary>
    public override void SpecialAbility(AbstractCharacter useCharacter)
    {
        foreach(GameObject aim in aims)
        {
            AbstractCharacter a = aim.GetComponent<AbstractCharacter>();
            if (!a.buffs.ContainsKey(7) || a.buffs[7] < 5)//最高叠5层
            {
                //1.给目标添加此脚本：该脚本在Start获取抽象角色类,并在Update等待触发效果
                aim.AddComponent<FangFuShu>();
                a.AddBuff(7);
            }
        }
    }

    private float now = 0;//计时
    override public void FixedUpdate()
    {
        base.FixedUpdate();
        if (now < skillEffectsTime)
        {
            now += Time.deltaTime;
        }
        //3.只用于挂在角色上的脚本（已穿复活甲）
        if (aimState != null)
        {
            if (aimState.character.hp <= 0)
            {
                aimState.character.hp = aimState.character.maxHP;
                //添加回触发死亡的条件
                foreach (AI.AbstractState state in aimState.allState)
                {
                    state.triggers.Add(this.GetComponent<AI.NoHealthTrigger>());
                }
                aimState.character.RemoveBuff(7);
                Destroy(this);//销毁自己（脚本组件）
            }
        }
        //4.超时（20秒）
        if (aimState!=null && now >= skillEffectsTime)
        {
            //添加回触发死亡的条件
            foreach (AI.AbstractState state in aimState.allState)
            {
                state.triggers.Add(this.GetComponent<AI.NoHealthTrigger>());
            }
            aimState.character.RemoveBuff(7);
            Destroy(this);//销毁自己（脚本组件）
        }
    }

    /// <summary>作用目标</summary>
    public AI.MyState0 aimState;
    public override void UseVerbs(AbstractCharacter useCharacter)
    {
        base.UseVerbs(useCharacter);
        SpecialAbility(useCharacter);
    }

    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null || aimState==null)
            return null;

        return character.wordName + "拿起小刀，将"+aimState.character.wordName+"腹部开出一个小缺口，并将香脂油灌满其中。再将树脂填入名字2的头颅，防止头部的变形。接下来将他整个埋于碱粉中一个月，这样就可以做到肉体不被腐朽所困扰了。";

    }
}
