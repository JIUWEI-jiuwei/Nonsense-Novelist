using AI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 class MuNaiYi : AbstractCharacter
{
    override public void Awake()
    {
        base.Awake();
        characterID = 4;
        wordName = "ľ����";
        bookName = BookNameEnum.EgyptMyth;
        gender = GenderEnum.noGender;
        hp =maxHP  = 220;
        atk = 3;
        def = 4;
        psy = 4;
        san = 4;
        mainProperty.Add("��־","�з�T");
        trait=gameObject.AddComponent<Vicious>();
        roleName = "����";
        attackInterval = 2.2f;
        attackDistance = 300;
        reLifes++;//�����
        brief = "";
        description = "��Ĭ��������ĳ�������Ĺ��壬��С�㾫ͨħ����ʹ�á���˵��������Ȩ���߸�֮�����������߹��ڵ�������ĥ��ʹ���˻������ʱ���������ţ�ֱ�����������Զ���ĥ�𡣶������ϵ�ħ������Ҳ��Ť������ö񶾲������������������������ĵؽ����ϰ�ű���ʦ��������ħ����";
    }

    private void Start()
    {
        NoHealthTrigger noHealthTrigger= GetComponent<NoHealthTrigger>();
        noHealthTrigger.OnLive += OnLive;
    }

    /// <summary>
    /// ���
    /// </summary>
    public void OnLive()
    {
        atk += 10;
        def += 10;
        psy += 10;
        san += 10;
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
