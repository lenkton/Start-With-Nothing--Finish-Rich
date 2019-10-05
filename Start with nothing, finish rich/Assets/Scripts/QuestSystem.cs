using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestSystem : MonoBehaviour
{
    private void Awake()
    {
        HideQuestMenu();
    }
    public List<Quest> Quests;
    [SerializeField]
    private CanvasGroup QuestMenu;
    private bool isQuestMenuVisible = false;

    public void ChangeQuestMenuState()
    {
        if (isQuestMenuVisible)
        {
            HideQuestMenu();
        }
        else
        {
            ShowQuestMenu();
        }
    }
    public void ShowQuestMenu()
    {
        QuestMenu.alpha = .8f;
        QuestMenu.blocksRaycasts = true;
        QuestMenu.interactable = true;
        isQuestMenuVisible = true;
    }
    public void HideQuestMenu()
    {
        QuestMenu.alpha = 0f;
        QuestMenu.blocksRaycasts = false;
        QuestMenu.interactable = false;
        isQuestMenuVisible = false;
    }
}
