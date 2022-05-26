
using UnityEngine;
using UnityEngine.UI;

///<summary>
///��Ϸ�е��ı�����(����TextManager����
///</summary>
class TextManager : MonoBehaviour
{
    /// <summary>�������</summary>
    public Text headline;
    /// <summary>�ؿ�����</summary>
    public Text levelText;
    /// <summary>����ű�</summary>
    public BookNvWuXueTu firstText;
    /// <summary>��ȡ�ؿ�num�Ľű�</summary>
    public CharacterTranslateAndCamera characterTranslateAndCamera;

    private void Start()
    {
        //�籾����+�籾����
        if (characterTranslateAndCamera.chapterNum==1&&characterTranslateAndCamera.guanQiaNum == 0)
        {//��һ�µ�һ��
            headline.text = firstText.GetText(1,0,1);
            levelText.text = firstText.GetText(1, 1, 1) + firstText.GetText(1, 1, 2) + firstText.GetText(1, 1, 3);
        }
        if (characterTranslateAndCamera.chapterNum==1&&characterTranslateAndCamera.guanQiaNum == 1)
        {//��һ�µڶ���
            headline.text = firstText.GetText(1,0,1);
            levelText.text = firstText.GetText(1, 2, 1) + firstText.GetText(1, 2, 2) + firstText.GetText(1, 2, 3);
        }
        if (characterTranslateAndCamera.chapterNum==2&&characterTranslateAndCamera.guanQiaNum == 0)
        {//�ڶ��µ�һ��
            headline.text = firstText.GetText(2,0,1);
            levelText.text = firstText.GetText(2, 1, 1) + firstText.GetText(2, 1, 2) + firstText.GetText(2, 1, 3);
        }
        if (characterTranslateAndCamera.chapterNum==2&&characterTranslateAndCamera.guanQiaNum == 1)
        {//��һ�µڶ���
            headline.text = firstText.GetText(2,0,1);
            levelText.text = firstText.GetText(2, 2, 1) + firstText.GetText(2, 2, 2) + firstText.GetText(2, 2, 3);
        }
        if (characterTranslateAndCamera.chapterNum==2&&characterTranslateAndCamera.guanQiaNum == 2)
        {//�ڶ��µ�����
            headline.text = firstText.GetText(2,0,1);
            levelText.text = firstText.GetText(2, 3, 1) + firstText.GetText(2, 3, 2) + firstText.GetText(2, 3, 3);
        }



    }
}
