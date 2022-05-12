using UnityEngine;
using UnityEngine.UI;

///<summary>
///panel管理器
///</summary>
class PanelManager : MonoBehaviour
{
    /// <summary>面板及按钮</summary>
    public PanelInstance[] Pages1;
    public PanelInstance[] Pages2;
    public Button[] buttons1;
    public Button[] buttons2;
    /// <summary>按钮原始Y及按钮向上的Y数值</summary>
    public float btnUpY = 390f;
    public float originalY = 359f;
    public float g_btnUpY = 335f;
    public float g_originalY = 310f;

    private void Start()
    {
        OpenPanel(Pages1,Pages1[0], buttons1[0].GetComponent<RectTransform>(),btnUpY);
    }
    /// <summary>
    /// 打开第一个panel+第一个按钮上移
    /// </summary>
    /// <param name="pages">当前panel数组</param>
    /// <param name="page">第一个panel</param>
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
    /// 根据buttoni顺序打开相对应的panel
    /// </summary>
    /// <param name="buttons">按钮数组</param>
    /// <param name="pages">相对应的panel数组</param>
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
            //打开故事导入面板时，打开第二组面板
            if (buttons[i].name == buttons1[3].name)
            {
                OpenPanel(Pages2, Pages2[0], buttons2[0].GetComponent<RectTransform>(), g_btnUpY);
            }
        }
    }
    /// <summary>
    /// 关闭所有panel
    /// </summary>
    public void CloseAllPanels(PanelInstance[] pages)
    {
        for (int i = 0; i < pages.Length; i++)
        {
            pages[i].gameObject.SetActive(false);
        }
    }
    /// <summary>
    /// 选中的按钮向上平移
    /// </summary>
    /// <param name="buttons">关闭的按钮数组</param>
    /// <param name="originY">按钮最初的位置Y</param>
    /// <param name="bttnUpY">按钮升高的位置Y</param>
    public void ButtonTranslateUp(Button[] buttons, float originY,float bttnUpY)
    {
        var buttonSelf = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject;
        RectTransform rectTransform = buttonSelf.GetComponent<RectTransform>();
        AllButtonsDown(buttons, originY);
        rectTransform.localPosition = new Vector3(rectTransform.localPosition.x, bttnUpY, rectTransform.localPosition.z);
    }
    /// <summary>
    /// 所有按钮回到最初位置
    /// </summary>
    /// <param name="buttons">关闭的按钮数组</param>
    /// <param name="originY">按钮最初的位置Y</param>
    public void AllButtonsDown(Button[] buttons,float originY)
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            RectTransform temp = buttons[i].GetComponent<RectTransform>();
            temp.localPosition = new Vector3(temp.localPosition.x, originY, temp.localPosition.z);
        }
    }
    /// <summary>
    /// 第一组按钮
    /// </summary>
    public void TestTranslateUp()
    {
        ButtonTranslateUp(buttons1, originalY, btnUpY);
    }
    /// <summary>
    /// 第二组按钮
    /// </summary>
    public void TestTranslateUp2()
    {
        ButtonTranslateUp(buttons2, g_originalY, g_btnUpY);
    }
    /// <summary>
    /// 第一组panel
    /// </summary>
    public void TestPanelChange()
    {
        OpenPanelByButtonName(buttons1,Pages1);
            }
    /// <summary>
    /// 第二组panel
    /// </summary>
    public void TestPanelChange2()
    {
        OpenPanelByButtonName(buttons2, Pages2);
    }

}
