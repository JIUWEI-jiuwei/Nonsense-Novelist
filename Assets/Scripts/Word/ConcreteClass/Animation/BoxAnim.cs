using UnityEngine;

///<summary>
///³é½±ºÐ¶¯»­
///</summary>
class BoxAnim : MonoBehaviour
{
    private string anim1;
    private string anim2;
    private string anim3;
    private string anim4;
    private string anim5;
    private string anim6;
    private string anim7;
    public AnimationActor animActor;
    private void Awake()
    {
        animActor = new AnimationActor(GetComponent<Animation>());
    }
}
