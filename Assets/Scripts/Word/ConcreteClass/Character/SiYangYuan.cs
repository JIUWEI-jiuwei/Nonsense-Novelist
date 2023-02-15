using AI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// ����Ա
/// </summary>
class SiYangYuan : AbstractCharacter
{
    override public void Awake()
    {
        base.Awake();
        characterID = 11;
        wordName = "����Ա";
        bookName = BookNameEnum.ZooManual;
        gender = GenderEnum.noGender;
        hp =maxHP  = 100;
        atk = 0;
        def = 5;
        psy = 3;
        san = 5;
        trait=gameObject.AddComponent<Mercy>();
        roleName = "����Ա";
        attackInterval = 2.2f;
        attackDistance = 500;
    }
    private void Start()
    {
        attackState = GetComponent<AttackState>();
        Destroy(attackState.attackA);
        attackState.attackA = gameObject.AddComponent<CureMode>();
    }

    AttackState attackState;
    AbstractCharacter[] aims;
    public override void AttackA()
    {
        base.AttackA();
        //����ƽA
        myState.aim = null;
        if (myState.character.aAttackAudio != null)
        {
            myState.character.source.clip = myState.character.aAttackAudio;
            myState.character.source.Play();
        }
        myState.character.charaAnim.Play(AnimEnum.attack);
        aims=attackState.attackA.CalculateAgain(100, this);
        CollectionHelper.OrderBy(aims, p=>p.hp);
        //��ͨ����Ŀ��ΪѪ���ٷֱ���͵Ķ��ѣ��ָ�120%��־��Ѫ�����Լ������ܡ�״̬
        attackState.attackA.UseMode(myState.character, san * 1.2f, aims[0]);
        aims[0].gameObject.AddComponent<KangFen>().maxTime = 5;
    }

    public override void CreateBullet(GameObject aimChara)
    {
        base.CreateBullet(aimChara);
        DanDao danDao = bullet.GetComponent<DanDao>();
        danDao.aim = aimChara;
        danDao.bulletSpeed = 0.5f;
        danDao.birthTransform = this.transform;
        ARPGDemo.Common.GameObjectPool.instance.CreateObject(bullet.gameObject.name, bullet.gameObject, this.transform.position, aimChara.transform.rotation);

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
