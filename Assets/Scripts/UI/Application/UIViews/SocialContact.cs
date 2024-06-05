using System;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
using System.Collections;

namespace SkierFramework
{

    public class UITestItem : UILoopItem
    {
        #region 控件绑定变量声明，自动生成请勿手改
#pragma warning disable 0649
        [ControlBinding]
        private Image HeadImage;
        [ControlBinding]
        private Text NickName;
        [ControlBinding]
        private Text ChatContent;

#pragma warning restore 0649
        #endregion


        public override void OnInit()
        {
            base.OnInit();
        }

        public override void CheckSelect(int index)
        {
            base.CheckSelect(index);
        }

        protected override void OnUpdateData(IList dataList, int index, object userData)
        {
            base.OnUpdateData(dataList, index, userData);
        }
    }

    public class SocialContact : UIView
    {
        #region 控件绑定变量声明，自动生成请勿手改
		#pragma warning disable 0649
		[ControlBinding]
		private UIScrollView UIScrollView;
		[ControlBinding]
		private GameObject ChatItem;

		#pragma warning restore 0649
#endregion



        public override void OnInit(UIControlData uIControlData, UIViewController controller)
        {
            base.OnInit(uIControlData, controller);

            UIScrollView.OnSelectChanged += (index) =>
            {
                Debug.Log("选中了：" + index);
            };
        }

        public override void OnOpen(object userData)
        {
            base.OnOpen(userData);

            // 模拟10个数据
            List<int> list = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(i);
            }
            UIScrollView.UpdateList(list, ChatItem, typeof(UILoopItem));

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
