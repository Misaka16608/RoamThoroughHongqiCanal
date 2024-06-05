using System;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
using static Launcher;

namespace SkierFramework
{
    public class Bottom : UIView
    {
        #region 控件绑定变量声明，自动生成请勿手改
#pragma warning disable 0649
        [ControlBinding]
        private Button BtnYunYou;
        [ControlBinding]
        private Button BtnLishi;
        [ControlBinding]
        private Button BtnContact;
        [ControlBinding]
        private Button BtnStore;
        [ControlBinding]
        private Button BtnXInXi;

#pragma warning restore 0649
        #endregion


        public override void OnInit(UIControlData uIControlData, UIViewController controller)
        {
            base.OnInit(uIControlData, controller);
            BtnYunYou.AddClick(() =>
            {
                UIVIewManager.Instance.NowOpenUI = UIType.Mid;
            });

            BtnXInXi.AddClick(() =>
            {
                UIVIewManager.Instance.NowOpenUI = UIType.PersonalMsgView;
            });

            BtnContact.AddClick(() =>
            {
                UIVIewManager.Instance.NowOpenUI = UIType.SocialContact;
            });

        }

        public override void OnOpen(object userData)
        {
            base.OnOpen(userData);
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
            base.OnClose();
        }
    }
}
