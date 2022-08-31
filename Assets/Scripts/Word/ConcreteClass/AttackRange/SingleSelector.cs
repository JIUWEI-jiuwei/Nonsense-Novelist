using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 单体寻找
/// </summary>
public class SingleSelector : IAttackRange
{
    private Situation[] firstResult, secondResult;
    private List<AbstractCharacter> result;
    public AbstractCharacter[] CaculateRange(int attackDistance, Situation situation, NeedCampEnum needCamp)
    {
        //射程筛
        firstResult= CollectionHelper.FindAll<Situation>(Situation.allSituation,p=>Situation.Distance(situation,p) <= attackDistance);
        //阵营筛
        CampEnum myCamp= situation.GetComponentInChildren<AbstractCharacter>().camp;
        secondResult= CollectionHelper.FindAll<Situation>(firstResult, p => isAim(myCamp, p.GetComponentInChildren<AbstractCharacter>().camp, needCamp));
        //升序
        CollectionHelper.OrderBy(secondResult, p => Situation.Distance(situation, p));
        //转角色
        result = new List<AbstractCharacter>();
        foreach(Situation s in secondResult)
        {
            result.Add(s.GetComponentInChildren<AbstractCharacter>());
        }
        return result.ToArray();
    }

    private bool isAim(CampEnum myCamp, CampEnum aimCamp, NeedCampEnum needCamp)
    {
        if(needCamp==NeedCampEnum.all)
            return true;
        if(needCamp==NeedCampEnum.friend && myCamp==aimCamp)
            return true;
        if(needCamp==NeedCampEnum.enemy && myCamp!=aimCamp)
            return true;

        return false;
    }
}
