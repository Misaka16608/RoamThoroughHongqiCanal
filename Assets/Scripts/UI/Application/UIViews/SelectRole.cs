using System;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
using DG.Tweening;

namespace SkierFramework
{
    public class StateToggle
    {
        public Action RoleChanged;
        public void AddListener(Toggle toggle, int indx)
        {
            toggle.onValueChanged.AddListener((isOn) =>
            {
                if (isOn)
                {
                    RoleChoose item = RoleChoose.Role1 + indx;
                    RoleManager.Instance.NowRole = item;
                    RoleChanged?.Invoke();
                }
            });
        }
    }

    public class SelectRole : UIView
    {
        #region 控件绑定变量声明，自动生成请勿手改
		#pragma warning disable 0649
		[ControlBinding]
		private RectTransform ToggleGroup;

#pragma warning restore 0649
        #endregion

        StateToggle stateToggle;
        public override void OnInit(UIControlData uIControlData, UIViewController controller)
        {
            base.OnInit(uIControlData, controller);
            transform.localScale = Vector3.zero;

            if (stateToggle == null)
            {
                stateToggle = new StateToggle();
                stateToggle.RoleChanged += () =>
                {
                    OnClose();
                };
            }

            for (int i = 0; i < ToggleGroup.childCount ; i++){
                Toggle togle = ToggleGroup.GetChild(i).GetOrAddComponent<Toggle>();
                stateToggle.AddListener(togle, i);
            }
        }

        public override void OnOpen(object userData)
        {
            base.OnOpen(userData);
            transform.DOScale(Vector3.one, 0.5f);
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
        }
    }
}
