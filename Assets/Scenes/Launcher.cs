using SkierFramework;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    public GameObject Splash;

    void Start()
    {
        if (Splash == null)
        {
            Splash = GameObject.Find(nameof(Splash));
        }

        StartCoroutine(StartCor());
    }

    IEnumerator StartCor()
    {
        yield return StartCoroutine(ResourceManager.Instance.InitializeAsync());

        yield return UIManager.Instance.InitUIConfig();


        yield return UIManager.Instance.Preload(UIType.Mid);
        yield return UIManager.Instance.Preload(UIType.Bottom);
        yield return UIManager.Instance.Preload(UIType.SocialContact);
        yield return UIManager.Instance.Preload(UIType.Tips);
        Loading.Instance.StartLoading(EnterGameCor);

        if (Splash != null)
        {
            Splash.SetActive(false);
        }
    }

    IEnumerator EnterGameCor(Action<float, string> loadingRefresh)
    {
        loadingRefresh?.Invoke(0.2f, "Loading......");
        yield return new WaitForSeconds(0.5f);
        loadingRefresh?.Invoke(0.5f, "Loading......");
        yield return new WaitForSeconds(0.5f);
        loadingRefresh?.Invoke(0.6f, "Loading......");
        yield return new WaitForSeconds(0.5f);
        loadingRefresh?.Invoke(0.9f, "Loading......");
        yield return new WaitForSeconds(0.5f);
        loadingRefresh?.Invoke(1f, "Finished");
        yield return new WaitForSeconds(0.5f);

        //UIManager.Instance.Open(UIType.Top);
        UIVIewManager.Instance.NowOpenUI = UIType.Mid;

        UIManager.Instance.Open(UIType.Bottom);
    }

    public class UIVIewManager : Singleton<UIVIewManager>
    {
        private UIType nowOpenUI;
        bool isFirstView = true;
        public UIType NowOpenUI
        {
            get { return nowOpenUI; }
            set
            {
                if (nowOpenUI != value)
                {
                    ChangeUI(value);
                }
            }
        }
        public void ChangeUI(UIType uIType)
        {
            if (isFirstView)
            {
                UIManager.Instance.Open(uIType);
                nowOpenUI = uIType;
                isFirstView = false;
            }
            else
            {
                UIManager.Instance.Close(nowOpenUI);
                UIManager.Instance.Open(uIType);
                nowOpenUI = uIType;
            }
        }
    }
}
