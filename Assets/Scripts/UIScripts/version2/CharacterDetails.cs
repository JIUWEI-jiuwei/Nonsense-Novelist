using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

///<summary>
///��ɫ��ϸ��Ϣ��壨���ڸ�����Ԥ���屾��
///</summary>
class CharacterDetails : MonoBehaviour
{
    public Text[] texts1;
    public Text[] texts2;
    public Text[] texts3;
    public Text[] texts4;    
    public Image charaName;
    public Image charaImage;
    public Image bookImage;
    public GameObject wordPrefab;
    public Transform nounTF;
    public Transform verbTF;
    private bool isFirstNoun;
    private bool isFirstVerb;
    private bool isFirstAdj;
    public Transform statePanel;
    public GameObject stateImage;

    /// <summary>��ȡmousedown�ű� </summary>
    private MouseDown mouseDown;

    //��������
    //public GameObject importantPanel;
    //private List<GameObject> importantImage=new List<GameObject>();
    //public GameObject imagePrefab;

    private void Start()
    {
        mouseDown= GameObject.Find("MainCamera").GetComponent<MouseDown>();

        #region ��ȡ��Ҫ֮��(����)
        /*
        //for (int i = 0; i < mouseDown.abschara.importantNum.Count; i++)
        {
            GameObject a = Instantiate(imagePrefab);
            importantImage.Add(a);
            //importantImage[i].GetComponent<Image>().sprite = Resources.Load<Sprite>("FirstStageLoad/" + "head" + mouseDown.abschara.importantNum[i].ToString());
            //importantImage[i].transform.SetParent(importantPanel.transform);
            a.transform.localScale = new Vector3(1, 1, 1);//�������SetParent����
        }*/
        #endregion

        ///0����ҳ��Ϣ
        //��ɫ����ͼƬ
        charaName.sprite = Resources.Load<Sprite>("FirstStageLoad/" + "Character_" + mouseDown.abschara.wordName);
        charaImage.sprite = Resources.Load<Sprite>("FirstStageLoad/" + mouseDown.abschara.wordName);

        //�鱾ͼƬ
        bookImage.sprite = Resources.Load<Sprite>("FirstStage/Book/" +mouseDown.abschara.bookName.ToString());
        //print(mouseDown.abschara.bookName.ToString());

        //��ɫ��ݣ����ԣ����½ǵĶ�ֽƬ
        texts4[0].text = mouseDown.abschara.roleName;

        //4������ҳ��Ϣ���
        texts3[0].text = mouseDown.abschara.description;

    }
    private void Update()
    {
        //1��״̬ҳ��Ϣ���
        //HP
        texts1[0].text = mouseDown.abschara.hp.ToString() + "/" + mouseDown.abschara.maxHP.ToString();
        //ATK
        texts1[1].text = IntToString.SwitchATK(mouseDown.abschara.atk);
        //def
        texts1[2].text = IntToString.SwitchATK(mouseDown.abschara.def);
        //san
        texts1[3].text = IntToString.SwitchATK(mouseDown.abschara.san);
        //psy
        texts1[4].text = IntToString.SwitchATK(mouseDown.abschara.psy);

        AdjDetails();


        //2������ҳ��Ϣ���
        NounDetails();

        //3������ҳ��Ϣ���
        VerbDetails();

    }
    /// <summary>
    /// 2��������Ϣ���
    /// </summary>
    private void NounDetails()
    {
        if (!isFirstNoun)
        {
            isFirstNoun = true;
            AbstractItems[] items = mouseDown.abschara.gameObject.GetComponents<AbstractItems>();

            //ȫ������һ��
            for (int i = 0; i < items.Length; i++)
            {
                GameObject word = Instantiate(wordPrefab);
                word.AddComponent(items[i].GetType());
                word.transform.SetParent(nounTF);
                word.transform.localScale = Vector3.one;

                //����ͼƬ

                //ͬһ�ʵ�����
                for (int j = i + 1; j < items.Length; j++)
                {
                    if (items[i].itemID == items[j].itemID)
                    {
                        word.transform.GetChild(0).GetComponent<WordCountText>().count++;
                    }
                }
            }
            //ȥ��
            for (int i = 0; i < nounTF.childCount; i++)
            {
                for (int j = i + 1; j < nounTF.childCount; j++)
                {
                    if (nounTF.GetChild(i).GetComponent<AbstractItems>().itemID == nounTF.GetChild(j).GetComponent<AbstractItems>().itemID)
                    {
                        Destroy(nounTF.GetChild(j).gameObject);
                    }
                }
            }

        }
    }
    /// <summary>
    /// 3������ҳ��Ϣ���
    /// </summary>
    private void VerbDetails()
    {
        if (!isFirstVerb)
        {
            isFirstVerb = true;
            AbstractVerbs[] verbs = mouseDown.abschara.gameObject.GetComponents<AbstractVerbs>();

            //ȫ������һ��
            for (int i = 0; i < verbs.Length; i++)
            {
                GameObject word = Instantiate(wordPrefab);
                word.AddComponent(verbs[i].GetType());
                word.transform.SetParent(nounTF);
                word.transform.localScale = Vector3.one;

                //����ͼƬ

                //ͬһ�ʵ�����
                for (int j = i + 1; j < verbs.Length; j++)
                {
                    if (verbs[i].skillID == verbs[j].skillID)
                    {
                        word.transform.GetChild(0).GetComponent<WordCountText>().count++;
                    }
                }
            }
            //ȥ��
            for (int i = 0; i < verbTF.childCount; i++)
            {
                for (int j = i + 1; j < verbTF.childCount; j++)
                {
                    if (verbTF.GetChild(i).GetComponent<AbstractVerbs>().skillID == verbTF.GetChild(j).GetComponent<AbstractVerbs>().skillID)
                    {
                        Destroy(verbTF.GetChild(j).gameObject);
                    }
                }
            }

        }
    }
    /// <summary>
    /// 1��״̬����Ϣ
    /// </summary>
    private void AdjDetails()
    {
        if (!isFirstAdj)
        {
            isFirstAdj = true;
            AbstractAdjectives[] adj = mouseDown.abschara.gameObject.GetComponents<AbstractAdjectives>();

            //ȫ������һ��
            for (int i = 0; i < adj.Length; i++)
            {
                GameObject word = Instantiate(stateImage);
                word.AddComponent(adj[i].GetType());
                word.transform.SetParent(statePanel);
                word.transform.localScale = Vector3.one;

                //����ͼƬ

                //ͬһ�ʵ�����
                for (int j = i + 1; j < adj.Length; j++)
                {
                    if (adj[i].adjID == adj[j].adjID)
                    {
                        word.transform.GetChild(0).GetComponent<WordCountText>().count++;
                    }
                }
            }
            //ȥ��
            for (int i = 0; i < statePanel.childCount; i++)
            {
                for (int j = i + 1; j < statePanel.childCount; j++)
                {
                    if (statePanel.GetChild(i).GetComponent<AbstractAdjectives>().adjID == statePanel.GetChild(j).GetComponent<AbstractAdjectives>().adjID)
                    {
                        Destroy(statePanel.GetChild(j).gameObject);
                    }
                }
            }

        }
    }

    /// <summary>
    /// �������Ĺرհ�ť����Ԥ����ҽű�����ֵ��
    /// </summary>
    public void CloseCharaPanel()
    {
        Destroy(this.transform.parent.gameObject);
        Time.timeScale = 1f;
        mouseDown.isShow = false;
    }
}
