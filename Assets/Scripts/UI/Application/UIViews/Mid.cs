using System;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;
using DG.Tweening;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.Events;

namespace SkierFramework
{
    

    public class Mid : UIView
    {

        #region 控件绑定变量声明，自动生成请勿手改
#pragma warning disable 0649
        [ControlBinding]
        private Button BtnHqqfjq;
        [ControlBinding]
        private Button BtnXtc;
        [ControlBinding]
        private Button BtnDq;
        [ControlBinding]
        private Button BtnWzt;
        [ControlBinding]
        private Button BtnThyx;
        [ControlBinding]
        private Button BtnHky;
        [ControlBinding]
        private Button BtnQnc;
        [ControlBinding]
        private Button BtnSwitchRole;

#pragma warning restore 0649
        #endregion



        RoleController roleController;

        public override void OnInit(UIControlData uIControlData, UIViewController controller)
        {
            base.OnInit(uIControlData, controller);

            RoleManager.Instance.InstantiateRoleAsync(transform);

            RoleManager.Instance.RoleUpdate += (rc)=>
            {
                roleController = rc;
                RoleManager.Instance.SetPosition(new Vector3(-150,-320));
                Debug.Log("UpDate!");
            };

            BtnHqqfjq.AddClick(() =>
            {
                string strContent = @"红旗渠，国家AAAAA级旅游景区，全国重点文物保护单位，位于河南省安阳市林州市，是20世纪60年代林县（今林州市）人民在极其艰难的条件下，从太行山腰修建的引漳入林的水利工程，被人称之为“人工天河”。
红旗渠工程于1960年2月动工，至1969年7月支渠配套工程全面完成，历时近十年。该工程共削平了1250座山头，架设151座渡槽，开凿211个隧洞，修建各种建筑物12408座，挖砌土石达2225万立方米，红旗渠总干渠全长70.6公里（山西石城镇～河南任村镇），干渠支渠分布全市乡镇。
红旗渠全长1500公里、参与修建人数近10万、耗时近10年的伟大工程，是“新中国奇迹”，被誉为“世界第八大奇迹”。";
                UIManager.Instance.Open(UIType.Tips, ObjectPool<TipsData>.Get().Set("红旗渠风景区", strContent));
                roleController.Domove(BtnHqqfjq.transform.position, 0.5f);
            });
            BtnXtc.AddClick(() =>
            {
                string strContent = @"在山间施工，沙石的清运、回填，别说没有大型工具，就是有也没有作业面。因此独轮小推车就成了最为实用的运输工具。整个红旗渠的建设施工，小推车的作用发到到了极致，功不可没、至关重要！";
                UIManager.Instance.Open(UIType.Tips, ObjectPool<TipsData>.Get().Set("小推车", strContent));
                roleController.Domove(BtnXtc.transform.position, 0.5f);
            });
            BtnDq.AddClick(() =>
            {
                string strContent = @"在红旗渠总干渠修至仙女峰时，为了方便修渠群众上下工和运输物资，便在河上架起了三座木桥，但好景不长，由于河流湍急，三座木桥被冲垮两座，大量物资也只能从一座桥上通过，严重影响了施工进度。为了确保在汛期前能够完成修渠任务，他们便在两山之间，架起了空运线。对于当时红旗渠工地的技术水平来说，这的确是一件难事，但他们不怕失败。经过多次试验之后，空运线从漳河的岸边，架到了仙女峰半山腰。为了减轻空运线的使用强度，修渠民众还把水打木轮、驱动水磨的原理，引用到空运线上当动力。最终，在漳河上共架起了11条空运线，用编筐把石灰、沙、水等从山下直接送到了山上工地，大大加快了施工进度。";
                UIManager.Instance.Open(UIType.Tips, ObjectPool<TipsData>.Get().Set("荡桥", strContent));
                roleController.Domove(BtnDq.transform.position, 0.5f);
            });
            BtnWzt.AddClick(() =>
            {
                string strContent = @"红旗渠望漳亭(山腰红旗渠、谷底为漳河))
红旗渠是20世纪60年代，安阳市林县(今河南林州市)人民在极其艰难的条件下，从太行山腰修建的引漳入林伟大工程。红旗渠被称为“中国水长城”，在国际上被誉为“世界第八大奇迹”。在红旗渠修建过程中孕育形成的“自力更生、艰苦创业、团结协作、无私奉献”的红旗渠精神，成为一笔宝贵的精神财富。";
                UIManager.Instance.Open(UIType.Tips, ObjectPool<TipsData>.Get().Set("望漳亭", strContent));
                roleController.Domove(BtnWzt.transform.position, 0.5f);
            });
            BtnThyx.AddClick(() =>
            {
                string strContent = @"一条红旗渠，教会人民什么是坚守！

一条红旗渠，练就百姓一身技能！

一条红旗渠，在人民心中铸造一座不朽的丰碑！

他们不是名人，却誉满中外，

他们不是英雄，却改换新篇，

他们为了心中的渴望与信念，

将自己的血肉化为红旗渠精神的基石，

支撑着它的流传！
2023年7月1日上午，在中国共产党迎来102岁生日之际，由中国国家画院、安阳师范学院、红旗渠干部学院联合主办，中国国家画院美术馆承办的2023年度国家艺术基金传播交流推广资助项目“太行丰碑——红旗渠精神影像展”在中国国家画院明德楼三层颂厅拉开帷幕。展览以近百件影像作品，全方位、多角度、史诗般地展现了艰苦岁月里平凡修渠者的不凡形象，印证了中国共产党带领人民追求美好幸福生活的初心。";
                UIManager.Instance.Open(UIType.Tips, ObjectPool<TipsData>.Get().Set("太行影像", strContent));
                roleController.Domove(BtnThyx.transform.position, 0.5f);
            });
            BtnHky.AddClick(() =>
            {
                string strContent = @"虎口崖，崖高百丈，山崖向外突出十余米，像老虎张开的大口。修渠时，山崖上时有松动石头掉下来砸人，除险队长任羊成带着他的队员，像雄鹰展翅在空中荡秋千，飞荡数次，才能荡进虎口，除掉险石，人们称这叫虎口拔牙，于是此山崖被称为“虎口崖”。";
                UIManager.Instance.Open(UIType.Tips, ObjectPool<TipsData>.Get().Set("虎口崖", strContent));
                roleController.Domove(BtnHky.transform.position, 0.5f);
            });
            BtnQnc.AddClick(() =>
            {
                string strContent = @"青年洞位于红旗渠总干渠任村卢家拐村西牛岭山下方，是总干渠最长的隧洞。青年洞从地势险恶，石质坚硬的太行山腰穿过。因参加凿洞的突击队是从全县民工中抽调出来的300名优秀青年，故取名叫“青年洞”。青年洞中，游艇穿行，可尽情体味“天河荡舟”的独特感受。“铁姑娘打钎”、“凌空除险”现场表演，怀旧，惊险，带你追忆那段难忘岁月。春来绿树成荫，秋至红叶满山，登高远眺，三省风光尽收眼底。";
                UIManager.Instance.Open(UIType.Tips, ObjectPool<TipsData>.Get().Set("青年洞", strContent));
                roleController.Domove(BtnQnc.transform.position, 0.5f);
            });
            BtnSwitchRole.AddClick(() =>
            {
                UIManager.Instance.Open(UIType.SelectRole);
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

    public class RoleController : MonoBehaviour
    {

        public void Domove(Vector3 target, float moveTime)
        {
            Vector3 midPoint = (transform.position + target) / 2f; // 计算中间点
            midPoint.y = midPoint.y + 2f;
            Vector3[] path = new Vector3[] {
                transform.position,
                midPoint,
                target
            };
            //PathType.CatmullRom:抛物线动画
            transform.DOPath(path, moveTime, PathType.CatmullRom, PathMode.TopDown2D).SetEase(Ease.OutQuad); // 使用DOPath方法创建抛物线路径动画
        }
    }

    public enum RoleChoose
    {
        Role1,
        Role2,
        Role3,
    }
    public class RoleManager : Singleton<RoleManager>
    {
        readonly string pathRole1 = @"Assets/AssetsPackage/UI/Prefabs/Role1.prefab";
        readonly string pathRole2 = @"Assets/AssetsPackage/UI/Prefabs/Role2.prefab";
        readonly string pathRole3 = @"Assets/AssetsPackage/UI/Prefabs/Role3.prefab";
        public GameObject Go {  get; private set; }
        public RoleController RoleController { get; private set; }
        public Action<RoleController> RoleUpdate;
        private RoleChoose nowRole;
        public RoleChoose NowRole
        {
            get { return nowRole; }
            set
            {
                if(nowRole != value && Go != null)
                {
                    nowRole = value;
                    InstantiateRoleAsync(Go.transform.parent);
                }
            }
        }

        public override void OnInitialize()
        {
            NowRole = RoleChoose.Role1;
        }
        public string GetRolePath(RoleChoose roleChoose)
        {
            switch(roleChoose)
            {
                case RoleChoose.Role1: return pathRole1;
                case RoleChoose.Role2: return pathRole2;
                case RoleChoose.Role3: return pathRole3;
                default:
                return null;
            }
        }
        public void SetPosition(Vector3 localPosition)
        {
            Go.transform.localPosition = localPosition;
        }
        public AsyncOperationHandle InstantiateRoleAsync(Transform parent)
        {
            return ResourceManager.Instance.InstantiateAsync(GetRolePath(nowRole), (go) =>
            {
                go.transform.parent = parent;
                go.transform.localPosition = Vector3.zero;
                go.transform.localRotation = Quaternion.identity;
                go.transform.localScale = Vector3.one;

                DestroyRole();

                RoleController = go.GetOrAddComponent<RoleController>();
                Go = go;

                RoleUpdate?.Invoke(RoleController);
            });
        }

        public void DestroyRole()
        {
            if(Go != null)
            {
                ResourceManager.Instance.Recycle(Go);
            }
        }
    }
}
