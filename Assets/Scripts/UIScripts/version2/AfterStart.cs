using UnityEngine.UI;
using UnityEngine;

/// <summary>
/// combat after start
/// </summary>
public class AfterStart : MonoBehaviour
{
    /// <summary>��ɫ��ҪԤ���壨�ֶ��ң�</summary>
    private Transform charaShortInstance;
    /// <summary>��ɫ��ҪԤ�����¡</summary>
    private Transform charaShort;
    /// <summary></summary>
    private bool one;

    private void Start()
    {
        charaShortInstance = Resources.Load<Transform>("SecondStageLoad/CharacterShort");
    }
    private void OnMouseOver()
    {

        //��ɫ���
        GetComponent<SpriteRenderer>().color = new Color((float)255 / 255, (float)225 / 255, (float)189 / 255, (float)255 / 255);

        if (!one)
        {
            one = true;
            //��ʾ��ɫ��Ҫ��Ϣ(������)
            charaShort = Instantiate(charaShortInstance);
            charaShort.SetParent(transform.GetChild(4));
            charaShort.localScale = Vector3.one;

            //����ɫ��Ҫ��ֵ
            AbstractCharacter abschara = GetComponent<AbstractCharacter>();
            //name
            charaShort.GetChild(0).GetComponent<Text>().text = abschara.wordName;
            //HP
            charaShort.GetChild(1).GetComponentInChildren<Text>().text = abschara.hp.ToString() + "/" + abschara.maxHP.ToString();
            //ATK
            charaShort.GetChild(2).GetComponentInChildren<Text>().text = IntToString.SwitchATK(abschara.atk);
            //def
            charaShort.GetChild(3).GetComponentInChildren<Text>().text = IntToString.SwitchATK(abschara.def);
            //san
            charaShort.GetChild(4).GetComponentInChildren<Text>().text = IntToString.SwitchATK(abschara.san);
            //psy
            charaShort.GetChild(5).GetComponentInChildren<Text>().text = IntToString.SwitchATK(abschara.psy);
        }
    }
    private void OnMouseExit()
    {
        //��ɫ�ָ�
        GetComponent<SpriteRenderer>().color = new Color((float)255 / 255, (float)255 / 255, (float)255 / 255, (float)255 / 255);

        //��ɫ��Ҫ����ʾ
        Destroy(charaShort.gameObject);
    }
}
