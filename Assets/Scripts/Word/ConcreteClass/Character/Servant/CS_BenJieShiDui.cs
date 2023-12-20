
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CS_BenJieShiDui : ServantAbstract
{
    override public void Awake()
    {
        base.Awake();
        characterID = 2;
        wordName = "����ʿ��";
        bookName = BookNameEnum.ZooManual;

        hp = maxHp = 80;
        atk = 0;
        def = 20;
        psy = 10;
        san = 0;

        //mainProperty.Add("����", "��T");
        //trait = gameObject.AddComponent<Pride>();
        roleName = "�ӻ���";

        brief = "��ͨ�������ƶ���";
        description = "��ͨ�������ƶ���";


        Destroy(attackA);
        attackA = gameObject.AddComponent<CureMode>();
    }

    AbstractCharacter[] aims;
    public override bool AttackA()
    {//����ƽA
        if (myState.aim != null)
        {
            myState.character.CreateBullet(myState.aim.gameObject);
            if (myState.character.aAttackAudio != null)
            {
                myState.character.source.clip = myState.character.aAttackAudio;
                myState.character.source.Play();
            }
            myState.character.charaAnim.Play(AnimEnum.attack);
            //��ͨ����Ŀ��ΪѪ���ٷֱ���͵Ķ��ѣ��ָ�10Ѫ����������
            myState.aim.CreateFloatWord(
            attackA.UseMode(myState.character, 10, myState.aim)
            , FloatWordColor.heal, false);
            return true;
        }
        return false;
    }

   

    public override string ShowText(AbstractCharacter otherChara)
    {
        if (otherChara != null)
            return otherChara.wordName + "���ѿ�������һ�����ã�ϸ�����ݣ�ֻ������㣬����΢΢���о�ʱ��毻���ˮ���ж������������磬" + otherChara.wordName + "Ц������������ã����������ġ�";
        else
            return null;
    }
    public override string CriticalText(AbstractCharacter otherChara)
    {
        if (otherChara != null)
            return "���Ҿ�֪�������˲���ʣ�µ�Ҳ�����ҡ�������������һ�仨�꣬��" + otherChara.wordName + "��ȥ";
        else
            return null;
    }

    public override string LowHPText()
    {
        return "�������Ů��Ϣ���������ϻ���ա����㽫һ�����ӣ�һ��ʫ��پ��ڻ����С�";
    }
    public override string DieText()
    {
        return "�����񡭱�����á���������û˵��������˫�ۡ�";
    }


}

