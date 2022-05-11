
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
///<summary>
///全局按钮管理
///</summary>
class ButtonManager : MonoBehaviour
{
    private float buttonZ = 31f;
    private RectTransform rectTransform;
    public PanelInstance[] Pages;
    public PanelInstance currentPanel;

    private void Awake()
    {
        for (int i = 0; i < Pages.Length; i++)
        {
            Pages[i].gameObject.AddComponent<PanelInstance>();
        }
    }
    private void Start()
    {
        rectTransform = GetComponent<RectTransform>();      
        if (Pages.Length <= 0)
        {
            return;
        }
        OpenPanel(Pages[0]);
    }
    /// <summary>
    /// 按钮向上平移
    /// </summary>
    public void ButtonTranslateUp()
    {
        rectTransform.localPosition = new Vector3(rectTransform.localPosition.x, rectTransform.localPosition.y + buttonZ, rectTransform.localPosition.z);
    }
    public void OpenPanel(PanelInstance page)
    {
        if (page == null)
        {
            return;
        }
        page.PanelBefore = currentPanel;
        currentPanel = page;
    }
}
