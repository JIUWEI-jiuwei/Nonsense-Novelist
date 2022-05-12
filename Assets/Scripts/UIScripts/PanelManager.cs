using UnityEngine;
using UnityEngine.UI;

///<summary>
///panel������
///</summary>
class PanelManager : MonoBehaviour
{
    /// <summary>��弰��ť</summary>
    public PanelInstance[] Pages1;
    public PanelInstance[] Pages2;
    public Button[] buttons1;
    public Button[] buttons2;
    /// <summary>��ťԭʼY����ť���ϵ�Y��ֵ</summary>
    public float btnUpY = 390f;
    public float originalY = 359f;
    public float g_btnUpY = 335f;
    public float g_originalY = 310f;

    private void Start()
    {
        OpenPanel(Pages1,Pages1[0], buttons1[0].GetComponent<RectTransform>(),btnUpY);
    }
    /// <summary>
    /// �򿪵�һ��panel+��һ����ť����
    /// </summary>
    /// <param name="pages">��ǰpanel����</param>
    /// <param name="page">��һ��panel</param>
    public void OpenPanel(PanelInstance[] pages,PanelInstance page, RectTransform btn0RT, float bttnUpY)
    {
        for (int i = 0; i < pages.Length; i++)
        {
            pages[i].gameObject.SetActive(false);
        }
        page.gameObject.SetActive(true);
        btn0RT.localPosition = new Vector3(btn0RT.localPosition.x, bttnUpY, btn0RT.localPosition.z);
    }
    /// <summary>
    /// ����buttoni˳������Ӧ��panel
    /// </summary>
    /// <param name="buttons">��ť����</param>
    /// <param name="pages">���Ӧ��panel����</param>
    public void OpenPanelByButtonName(Button[] buttons,PanelInstance[] pages)
    {
        var buttonSelf = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject;
        for (int i = 0; i < buttons.Length; i++)
        {
            if (buttons[i].name == buttonSelf.name)
            {
                CloseAllPanels(pages);
                if (pages[i].gameObject.activeSelf == false)
                    pages[i].gameObject.SetActive(true);
            }
            //�򿪹��µ������ʱ���򿪵ڶ������
            if (buttons[i].name == buttons1[3].name)
            {
                OpenPanel(Pages2, Pages2[0], buttons2[0].GetComponent<RectTransform>(), g_btnUpY);
            }
        }
    }
    /// <summary>
    /// �ر�����panel
    /// </summary>
    public void CloseAllPanels(PanelInstance[] pages)
    {
        for (int i = 0; i < pages.Length; i++)
        {
            pages[i].gameObject.SetActive(false);
        }
    }
    /// <summary>
    /// ѡ�еİ�ť����ƽ��
    /// </summary>
    /// <param name="buttons">�رյİ�ť����</param>
    /// <param name="originY">��ť�����λ��Y</param>
    /// <param name="bttnUpY">��ť���ߵ�λ��Y</param>
    public void ButtonTranslateUp(Button[] buttons, float originY,float bttnUpY)
    {
        var buttonSelf = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject;
        RectTransform rectTransform = buttonSelf.GetComponent<RectTransform>();
        AllButtonsDown(buttons, originY);
        rectTransform.localPosition = new Vector3(rectTransform.localPosition.x, bttnUpY, rectTransform.localPosition.z);
    }
    /// <summary>
    /// ���а�ť�ص����λ��
    /// </summary>
    /// <param name="buttons">�رյİ�ť����</param>
    /// <param name="originY">��ť�����λ��Y</param>
    public void AllButtonsDown(Button[] buttons,float originY)
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            RectTransform temp = buttons[i].GetComponent<RectTransform>();
            temp.localPosition = new Vector3(temp.localPosition.x, originY, temp.localPosition.z);
        }
    }
    /// <summary>
    /// ��һ�鰴ť
    /// </summary>
    public void TestTranslateUp()
    {
        ButtonTranslateUp(buttons1, originalY, btnUpY);
    }
    /// <summary>
    /// �ڶ��鰴ť
    /// </summary>
    public void TestTranslateUp2()
    {
        ButtonTranslateUp(buttons2, g_originalY, g_btnUpY);
    }
    /// <summary>
    /// ��һ��panel
    /// </summary>
    public void TestPanelChange()
    {
        OpenPanelByButtonName(buttons1,Pages1);
            }
    /// <summary>
    /// �ڶ���panel
    /// </summary>
    public void TestPanelChange2()
    {
        OpenPanelByButtonName(buttons2, Pages2);
    }

}
