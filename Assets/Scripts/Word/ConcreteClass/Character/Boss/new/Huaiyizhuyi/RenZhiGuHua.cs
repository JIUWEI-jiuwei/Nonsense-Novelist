using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RenZhiGuHua : AbstractVerbs
{

    public override void Awake()
    {
        base.Awake();
        skillID = 2;
        wordName = "��֪�̻�";
        bookName = BookNameEnum.HongLouMeng;
        description = "����ü�������һ��ʱ���������棬�����������ʱ�˺�ʩ���ߡ�";
        skillMode = gameObject.AddComponent<UpPSYMode>();
        skillEffectsTime = Mathf.Infinity;
        rarity = 3;
        needCD = 4;
        attackDistance = 100;
        print("renzhiguhua��ʼ��");
    }

    /// <summary>
    /// ����
    /// </summary>
    /// <param name="useCharacter">ʩ����</param>
    public override void UseVerb(AbstractCharacter useCharacter)
    {
        base.UseVerb(useCharacter);
        print("renzhiguhua   UseVerb");

        //���_aimCount��ʩ��Ŀ��
        int _aimCount = 3;
        AbstractCharacter[] _randomCharacter= skillMode.CalculateRandom(attackDistance, useCharacter,true);

        if (_aimCount <_randomCharacter.Length)
        {//���Ͻ�ɫ����3��ʱ�������ȡ
            //ȷ��ʩ��Ŀ�겻�ظ�
            List<int> _array = new List<int>();
            for (int i = 0; i < _aimCount; i++)
            {
                int number = Random.Range(0, _randomCharacter.Length);
                while (_array.Contains(number))
                {
                    number = Random.Range(0, _randomCharacter.Length);
                }
                _array.Add(number);
                buffs.Add(_randomCharacter[_array[i]].gameObject.AddComponent<Renzhiguhua_buff>());
                print("��֪�̻��ԣ�" + _randomCharacter[_array[i]].wordName+"ִ��"+i);
            }
        }
        else 
        { //���Ͻ�ɫС������ʱ��ȫ�����衣
            print("��֪�̻���Ŀ�����������ϵĽ�ɫ����"+ _randomCharacter.Length);
            for (int i = 0; i < _randomCharacter.Length; i++)
            {
                buffs.Add(_randomCharacter[i].gameObject.AddComponent<Renzhiguhua_buff>());
                print("��֪�̻��ԣ�" + _randomCharacter[i].wordName + "ִ��i");
            }
        }
    }

    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null)
            return null;

        return "�ּ�ʢ�����һ������Ʈ���ڵء�\n" + character.wordName + "��Ʈ���ڵص��һ���£���ţ����������ᣬΪ�䰧��������л���ɻ����죬����������˭������";

    }
}
