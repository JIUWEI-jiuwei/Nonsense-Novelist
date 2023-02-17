using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordInformation : MonoBehaviour
{
    /// <summary>手动</summary>
    public Text title;
    /// <summary>手动</summary>
    public Text description;
    /// <summary>手动(是needCD的父物体)</summary>
    public Image energy;
    /// <summary>手动</summary>
    public Text needCD;

    public void ChangeInformation(AbstractWord0 word)
    {
        title.text = word.wordName;
        description.text=word.description;
        if(word.wordKind==WordKindEnum.verb)
        {
            needCD.text = ((AbstractVerbs)word).needCD.ToString();
            energy.enabled= true;
        }
        else
        {
            energy.enabled= false;
        }
    }
}
