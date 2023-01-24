using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
///<summary>
///�����ק
///</summary>
class MouseDrag : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    /// <summary>ͼ��λ��</summary>
    private RectTransform rectTrans;
    /// <summary>���۸�����λ��</summary>
    private Transform gridPanel;
    /// <summary>���۸�����λ�ã����ڲ��ԣ�</summary>
    private Transform gridPanelForTest;
    /// <summary>����������λ��</summary>
    private Transform wordPanel;
    /// <summary>����������λ��</summary>
    private Transform testPanel;
    /// <summary>CanvasGroup���</summary>
    private CanvasGroup canvasGroup;
    /// <summary>�������ϵļ��ܽű�</summary>
    private AbstractWords0 absWord;

    /// <summary>���ݴʵļ���ԲȦ</summary>
    public GameObject adjCircle;
    /// <summary>���ʵļ���ԲȦ</summary>
    public GameObject verbCircle;
    /// <summary>���ݴ�ԲȦ���ص�λ��</summary>
    private Transform parentCircleTF;
    /// <summary>��Чsummary>
    private AudioSource audioSource;
    /// <summary>��Чsummary>
    private AudioSource audioSource_cantuse;
    /// <summary>��������</summary>
    public GameObject wordDetail;
    private GameObject otherCanvas;

    private void Start()
    {
        rectTrans = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        absWord = GetComponent<AbstractWords0>();
        otherCanvas = GameObject.Find("MainCanvas");
        FindGrid();
        if (SceneManager.GetActiveScene().name == "Combat")
        {
            audioSource = GameObject.Find("AudioSource_wirte").GetComponent<AudioSource>();
            audioSource_cantuse = GameObject.Find("AudioSource_CantUse").GetComponent<AudioSource>();
        }
    }
    /// <summary>
    /// ��ʼ��ק
    /// </summary>
    /// <param name="eventData"></param>
    public void OnBeginDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = false;
        canvasGroup.alpha = 0.5f;
    }
    /// <summary>
    /// ������ק
    /// </summary>
    /// <param name="eventData"></param>
    public void OnDrag(PointerEventData eventData)
    {
        //�������λ��ƫ��
        foreach (Canvas canvas in FindObjectsOfType<Canvas>())
        {
            if (canvas.name == "MainCanvas")
            {
                rectTrans.anchoredPosition += eventData.delta / canvas.scaleFactor;
            }
        }
    }
    /// <summary>
    /// ��ק����
    /// </summary>
    /// <param name="eventData"></param>
    public void OnEndDrag(PointerEventData eventData)
    {
        canvasGroup.blocksRaycasts = true;
        canvasGroup.alpha = 1f;
        //��δʹ�ã���ص����λ��
        if (rectTrans != null)
        {
            FindGrid();
        }
        //��UI������ק����ɫ����
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
        if (hit.collider != null)
        {
            if (hit.collider.gameObject.layer == LayerMask.NameToLayer("Character"))
            {
                //���Ŵ�����ק��ȥ����Ч
                audioSource.Play();
                AbstractCharacter character = hit.collider.gameObject.GetComponent<AbstractCharacter>();

                //�жϸô��������ݴʻ��Ƕ���
                if (absWord.wordSort == WordSortEnum.verb)
                {
                    AbstractVerbs b = this.GetComponent<AbstractVerbs>();
                    
                    //if(CanUseVerb(character, b))//����ܹ�ʹ�õ���ɫ����
                    {
                        hit.collider.gameObject.AddComponent(b.GetType());
                        character.skills.Add(b);
                        //character.realSkills = character.GetComponents<AbstractVerbs>();
                        Destroy(this.gameObject);
                    }
                    /*else//����
                    {
                        audioSource_cantuse.Play();
                    }*/
                }
                else if (absWord.wordSort == WordSortEnum.adj)
                {
                    //if (CanUseAdj(character, absWord.GetComponent<AbstractAdjectives>()))
                    {
                        this.GetComponent<AbstractAdjectives>().UseVerbs(hit.collider.gameObject.GetComponent<AbstractCharacter>());
                        Destroy(this.gameObject);
                    }
                    /*else
                    {
                        audioSource_cantuse.Play();
                    }*/
                }
            }
        }
    }
    
    

    /// <summary>
    /// ������λ���뿨��λ����ƥ��
    /// </summary>
    public void FindGrid()
    {
        foreach (Canvas canvas in FindObjectsOfType<Canvas>())
        {
            if (canvas.name == "MainCanvas")
            {
                gridPanel = canvas.transform.Find("GridPanel");
                wordPanel = canvas.transform.Find("WordPanel");
                testPanel = canvas.transform.Find("TestPanel");
                gridPanelForTest = canvas.transform.Find("GridPanelForTest");
            }
        }
        if (wordPanel!=null)
        {
            for (int i = 0; i < wordPanel.childCount; i++)
            {
                wordPanel.GetChild(i).position = gridPanel.GetChild(i).position;
            }
            for (int i = 0; i < testPanel.childCount; i++)
            {
                testPanel.GetChild(i).position = gridPanelForTest.GetChild(i).position;
            }
        }       
    }
    /// <summary>
    /// �鿴������ϸ��Ϣ
    /// </summary>
    public void ShowDetails()
    {
        //��ȡ������
        Transform a = Instantiate(wordDetail, otherCanvas.transform).transform.GetChild(0).GetChild(0);
        a.transform.GetChild(0).GetComponent<Text>().text = this.GetComponent<AbstractWords0>().wordName;
        a.transform.GetChild(1).GetComponent<Text>().text = this.GetComponent<AbstractWords0>().description;
        Time.timeScale = 0;
    }
    
}
