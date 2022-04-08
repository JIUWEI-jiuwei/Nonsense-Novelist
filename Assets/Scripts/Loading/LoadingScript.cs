using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// ���س����ű������г���ͨ�ã���������ϣ�
///</summary>
public class LoadingScript : MonoBehaviour
{
    public string LoadingSceneName;//��unity�︳ֵ��Ҫ���صĳ�����
    public LoadingSlider loadingSlider;//�м��ؽ���������Unity��
    /// <summary>����</summary>
    public AsyncOperation a;
    public void OnEnable()//�Ǽ��ػ��泡������Ϊ������, ����ת����ʱ�����ô˽ű�
    {
       a = SceneManager.LoadSceneAsync(LoadingSceneName);
        if(loadingSlider != null)
       a.allowSceneActivation = false;
    }
    public void Update()
    {
        if (loadingSlider != null)
        {
            loadingSlider.realValue = a.progress;//ͬ�����ؽ���
            if (loadingSlider.showValue >= 0.9f)//��չʾ�Ľ�������0.9�ˣ�����ת����
            {
                a.allowSceneActivation = true;
            }//�¸�����һ��ʼ���Ⱥ����롾���س�������ͬ�ķ��棬�ͽ�����0.9�Ľ�������֮���ý�������1~3�������ٵ�1����󳷵���ͬ����
        }
    }
    
}
