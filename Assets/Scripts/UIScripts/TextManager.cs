
using UnityEngine;
using UnityEngine.UI;

///<summary>
///游戏中的文本内容(挂在TextManager身上
///</summary>
class TextManager : MonoBehaviour
{
    /// <summary>剧情标题</summary>
    public Text headline;
    /// <summary>关卡剧情</summary>
    public Text levelText;
    /// <summary>剧情脚本</summary>
    public BookNvWuXueTu firstText;
    /// <summary>获取关卡num的脚本</summary>
    public CharacterTranslateAndCamera characterTranslateAndCamera;

    private void Start()
    {
        //剧本标题+剧本内容
        if (characterTranslateAndCamera.chapterNum==1&&characterTranslateAndCamera.guanQiaNum == 0)
        {//第一章第一关
            headline.text = firstText.GetText(1,0,1);
            levelText.text = firstText.GetText(1, 1, 1) + firstText.GetText(1, 1, 2) + firstText.GetText(1, 1, 3);
        }
        if (characterTranslateAndCamera.chapterNum==1&&characterTranslateAndCamera.guanQiaNum == 1)
        {//第一章第二关
            headline.text = firstText.GetText(1,0,1);
            levelText.text = firstText.GetText(1, 2, 1) + firstText.GetText(1, 2, 2) + firstText.GetText(1, 2, 3);
        }
        if (characterTranslateAndCamera.chapterNum==2&&characterTranslateAndCamera.guanQiaNum == 0)
        {//第二章第一关
            headline.text = firstText.GetText(2,0,1);
            levelText.text = firstText.GetText(2, 1, 1) + firstText.GetText(2, 1, 2) + firstText.GetText(2, 1, 3);
        }
        if (characterTranslateAndCamera.chapterNum==2&&characterTranslateAndCamera.guanQiaNum == 1)
        {//第一章第二关
            headline.text = firstText.GetText(2,0,1);
            levelText.text = firstText.GetText(2, 2, 1) + firstText.GetText(2, 2, 2) + firstText.GetText(2, 2, 3);
        }
        if (characterTranslateAndCamera.chapterNum==2&&characterTranslateAndCamera.guanQiaNum == 2)
        {//第二章第三关
            headline.text = firstText.GetText(2,0,1);
            levelText.text = firstText.GetText(2, 3, 1) + firstText.GetText(2, 3, 2) + firstText.GetText(2, 3, 3);
        }



    }
}
