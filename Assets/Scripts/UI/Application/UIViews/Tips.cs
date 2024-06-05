using System;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
using DG;
using DG.Tweening;

namespace SkierFramework
{
    public class TipsData
    {
        const string DefaultTitle = "����";
        const string DefaultContent = "����";

        public string Title { get; set; }
        public string Content { get; set; }
        public Image Image { get; set; }
        public TipsData Set(string title = DefaultTitle, string content = DefaultContent )
        {
            this.Title = title;
            this.Content = content;

            return this;
        }

    }

    public class Tips : UIView
    {

        #region �ؼ��󶨱����������Զ����������ָ�
#pragma warning disable 0649
        [ControlBinding]
        private Image TipsImage;
        [ControlBinding]
        private Text Title;
        [ControlBinding]
        private Text TextContent;
        [ControlBinding]
        private Button Close;
        [ControlBinding]
        private Scrollbar Scrollbar;

#pragma warning restore 0649
        #endregion



        TipsData tipsData;
        public override void OnInit(UIControlData uIControlData, UIViewController controller)
        {
            base.OnInit(uIControlData, controller);
            Close.AddClick(() =>
            {
                OnClose();
            });
            transform.localScale = Vector3.zero;
            Scrollbar.GetComponent<ScrollRect>().verticalNormalizedPosition = 1f;
        }

        public override void OnOpen(object userData)
        {
            base.OnOpen(userData);
            if (userData is TipsData tipsdata)
            {
                this.tipsData = tipsdata;
            }
            Title.text = tipsData.Title;
            TextContent.text = tipsData.Content;

            transform.DOScale(Vector3.one, 0.5f);
            // ���������ƶ������
            Scrollbar.GetComponent<ScrollRect>().verticalNormalizedPosition = 1f;
        }

        public override void OnAddListener()
        {
            base.OnAddListener();
        }

        public override void OnRemoveListener()
        {
            base.OnRemoveListener();
        }

        public override void OnClose()
        {
            transform.DOScale(Vector3.zero, 0.5f);
            base.OnClose();
            ObjectPool<TipsData>.Release(tipsData);
        }
    }
}
