using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordInformation : MonoBehaviour
{

    [Header("【手动】各词种对应的图")]

    [Tooltip("动词对应的图")]public Sprite spriteVerb;
    [Tooltip("名词对应的图")]public Sprite spriteNoun;
    [Tooltip("形容词对应的图")]public Sprite spriteAdj;




    [Header("【手动】词条信息对应的组件")]

    [Tooltip("卡牌底图")]public Image wordkindBg;

    [Tooltip("卡牌种类文字")]public Text wordkindText;
    private string textVerb = "动词";
    private string textNoun = "名词";
    private string textAdj = "形容词";

    [Tooltip("显示CD的文字")]public Text needCD;
    [Tooltip("词条名称")]public Text title;
    [Tooltip("词条文字")]public Text description;
    [Tooltip("是needCD的父物体")] public Image energy;
    [Tooltip("词条图像")] public Image wordImage;

    /// <summary>手动：词条图像读取路径前缀（后加wordname）</summary>
    private string resAdrNoun= "WordImage/Noun/";
    private string resAdrAdj = "WordImage/Adj/";
    private string resAdrVerb = "WordImage/Verb/";
    private Sprite tepSprite;
    private string resName;


    [Header("默认的词语图像")]
    public Sprite defaultWordImage;
    public void ChangeInformation(AbstractWord0 word)
    {
     
        switch (word.wordKind)
        {
            case WordKindEnum.adj:
                {
                    wordkindBg.sprite = spriteAdj;
                    wordkindBg.SetNativeSize();
                    wordkindText.text = textAdj;

                    resName = resAdrNoun + "adj_" + ((AbstractAdjectives)word).adjID;
                    tepSprite = Resources.Load<Sprite>(resName);
                    if (tepSprite == null)
                        wordImage.sprite = defaultWordImage;
                    else
                        wordImage.sprite = Resources.Load<Sprite>(resName);
                }
                break;
            case WordKindEnum.noun:
                {
                    wordkindBg.sprite = spriteNoun;
                    wordkindBg.SetNativeSize();
                    wordkindText.text = textNoun;

                    resName = resAdrNoun + "noun_" + ((AbstractItems)word).itemID;
                    tepSprite = Resources.Load<Sprite>(resName);
                    if (tepSprite == null)
                        wordImage.sprite = defaultWordImage;
                    else
                        wordImage.sprite = Resources.Load<Sprite>(resName);
                }
                break;
            case WordKindEnum.verb:
                {
                    wordkindBg.sprite = spriteVerb;
                    wordkindBg.SetNativeSize();
                    wordkindText.text = textVerb;

                    resName = resAdrNoun + "verb_" + ((AbstractVerbs)word).skillID;
                    tepSprite = Resources.Load<Sprite>(resName);
                    if (tepSprite == null)
                        wordImage.sprite = defaultWordImage;
                    else
                        wordImage.sprite = Resources.Load<Sprite>(resName);
                }
                break;
        }

        title.text = word.wordName;
        description.text=word.description;

        if(word.wordKind==WordKindEnum.verb)
        {
            energy.enabled= true;
            needCD.text =/*word.wordName*/((AbstractVerbs)word).needCD.ToString();
            
        }
        else
        {
            energy.enabled= false;
        }
    }
}
