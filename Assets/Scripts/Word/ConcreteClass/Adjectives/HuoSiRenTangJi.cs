using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 活死人汤剂(复活甲）
/// </summary>
class HuoSiRenTangJi : AbstractAdjectives
{
    /// <summary>作用目标</summary>
    public AI.MyState0 aimState;
    public override void Awake()
    {
        base.Awake();
        wordSort = WordSortEnum.adj;
        adjID = 2;
        wordName = "活死人汤剂";
        bookName = BookNameEnum.StudentOfWitch;
        description = "让角色获得一次复活的机会，但会失去身份和性格";
        chooseWay = ChooseWayEnum.canChoose;
        skillMode = gameObject.AddComponent<SpecialMode>();
        useAtFirst = false;


        aimState=this.GetComponent<AI.MyState0>();//2.获取目标（挂在目标上时）
        if (aimState != null)
        {
            //删掉触发死亡的条件
            foreach(AI.AbstractState state in aimState.allState)
            {
                state.triggers.Remove(state.triggers.Find(p=>p.id==AI.TriggerID.NoHealth));
            }
        }
    }

    override public void UseVerbs(AbstractCharacter aimCharacter)
    {
        base.UseVerbs(aimCharacter);
        if (!aimCharacter.buffs.ContainsKey(7) || aimCharacter.buffs[7] < 5)//最高叠5层
        {
            //1.给目标添加此脚本：该脚本在Start获取抽象角色类,并在Update等待触发效果
            aimCharacter.gameObject.AddComponent<HuoSiRenTangJi>();
            aimCharacter.trait = null;//行尸走肉：将性格变为空
            aimCharacter.AddBuff(7);
            aimCharacter.AddBuff(9);
        }
    }

    private void FixedUpdate()
    {
        //3.只用于挂在角色上的活汤脚本（已穿复活甲）
        if(aimState!=null)
        {
            if(aimState.character.hp<=0)
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
    }

    public override void SpecialAbility(AbstractCharacter aimCharacter)
    {
        
    }
    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null)
            return null;

        return "一位驼背的老女人从口袋里拿出了这瓶绿色的药剂“"+character.wordName+"既然你想获得永生，就试试它吧”说罢便发出如快散架的木椅子的笑声“只是要付出的代价也是相同的。”";
    }
}
