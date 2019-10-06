using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public abstract class ThingManager<T> : MonoBehaviour where T:ScriptableObject 
{

    [SerializeField]
    GameObject prefub=null;


    
    public List<T> Things;
    [SerializeField]
    private CanvasGroup Menu=null;
    [SerializeField]
    private GameObject Content = null;
    private bool isMenuVisible = false;

    private void Awake()
    {
        HideMenu();
    }
    public void ChangeMenuState()
    {
        if (isMenuVisible)
        {
            HideMenu();
        }
        else
        {
            ShowMenu();
        }
    }
    public void ShowMenu()
    {
        Menu.alpha = .8f;
        Menu.blocksRaycasts = true;
        Menu.interactable = true;
        isMenuVisible = true;
    }
    public void HideMenu()
    {
        Menu.alpha = 0f;
        Menu.blocksRaycasts = false;
        Menu.interactable = false;
        isMenuVisible = false;
    }

    public void Add(T thing)
    {
        Things.Add(thing);
        GameObject cg = Instantiate(prefub);
        cg.transform.SetParent(Content.transform);
        Fill(cg,thing);
    }

    protected abstract void Fill(GameObject gameObject, T scriptableObject);

    public void Delete(T thing)
    {
        Things.Remove(thing);
    }

    
}
