using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class GameMgr : MonoSingleton<GameMgr>
{

    //战斗相关
    private static List<Type> combatStart = new List<Type>();

    //关闭界面相关
    private GameObject exitPanel;
    GameObject exitObj;
    Button exitButton;
    Button cancelButton;
    bool hasOpenExit = false;


    private void Start()
    {
        exitPanel = Resources.Load<GameObject>("UI/exitPanel");
    }
    private void FixedUpdate()
    {
        if (hasOpenExit) return;
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            exitObj = Instantiate(exitPanel);
            Time.timeScale = 0f;
            hasOpenExit = true;
            exitButton = exitObj.transform.GetComponentsInChildren<Button>()[0];
            cancelButton = exitObj.transform.GetComponentsInChildren<Button>()[1];
            exitButton.onClick.AddListener(ExitButton);
            cancelButton.onClick.AddListener(BackToGame);
        }
    }
    public void ExitButton()
    {
        Application.Quit();
    }
    public void BackToGame()
    {
        Destroy(exitObj.gameObject);
        Time.timeScale = 1f;
        hasOpenExit = false;
    }

    public List<Type> GetCombatStartList()
    {
        return combatStart;
    }
    public int GetListLength()
    {
        return combatStart.Count;
    }
    public void SetCombatStartList(List<Type> _list)
    {
        combatStart.Clear();
        combatStart = _list;
    }
    public void AddCombatStartList(List<Type> _list)
    {
        foreach (var _i in _list)
        {
            if (!combatStart.Contains(_i))
                combatStart.Add(_i);
        }
 
        
    }
    public void RemoveCombatStartList(List<Type> _list)
    {
        foreach (var _i in _list)
        {
            if (combatStart.Contains(_i))
                combatStart.Remove(_i);
        }
    }
    public void AddBookList(BookNameEnum _book)
    {
        switch (_book)
        {
            case BookNameEnum.HongLouMeng:
                {
                    AddCombatStartList(AllSkills.hlmList_all);
                }
                break;
            case BookNameEnum.CrystalEnergy:
                {
                    AddCombatStartList(AllSkills.crystalList_all);
                }
                break;
            case BookNameEnum.ZooManual:
                {
                    AddCombatStartList(AllSkills.animalList_all);
                }
                break;
            case BookNameEnum.PHXTwist:
                {
                    AddCombatStartList(AllSkills.maYiDiGuoList_all);
                }
                break;
            case BookNameEnum.FluStudy:
                {
                    AddCombatStartList(AllSkills.liuXingBXList_all);
                }
                break;
            case BookNameEnum.EgyptMyth:
                {
                    AddCombatStartList(AllSkills.aiJiShenHuaList_all);
                }
                break;
            case BookNameEnum.ElectronicGoal:
                {
                    AddCombatStartList(AllSkills.humanList_all);
                }
                break;
        }
    }
}
