using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
class WanShua : AbstractVerbs
{
    public override void Awake()
    {
        base.Awake();
        skillID = 3;
        wordName = "��ˣ";
        bookName = BookNameEnum.ZooManual;
        description = "ʹ�ѷ���á����ܡ�";
        skillMode = gameObject.AddComponent<UpATKMode>();
        skillEffectsTime = 7;
        rarity = 1;
        needCD = 4;
    }

    /// <summary>
    /// ����
    /// </summary>
    /// <param name="useCharacter">ʩ����</param>
    public override void UseVerbs(AbstractCharacter useCharacter)
    {
        base.UseVerbs(useCharacter);
        buffs.Add(skillMode.CalculateAgain(attackDistance, useCharacter)[0].gameObject.AddComponent<KangFen>());
        buffs[0].maxTime = skillEffectsTime;
    }

    public override string UseText()
    {
        AbstractCharacter character = this.GetComponent<AbstractCharacter>();
        if (character == null)
            return null;

        return "�ּ�ʢ�����һ������Ʈ���ڵء�\n"+character.wordName+"��Ʈ���ڵص��һ���£���ţ����������ᣬΪ�䰧��������л���ɻ����죬����������˭������";

    }
    
}
