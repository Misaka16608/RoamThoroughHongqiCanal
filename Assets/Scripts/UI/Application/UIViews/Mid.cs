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

        #region �ؼ��󶨱����������Զ����������ָ�
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
                string strContent = @"������������AAAAA�����ξ�����ȫ���ص����ﱣ����λ��λ�ں���ʡ�����������У���20����60������أ��������У������ڼ�����ѵ������£���̫��ɽ���޽����������ֵ�ˮ�����̣����˳�֮Ϊ���˹���ӡ���
������������1960��2�¶�������1969��7��֧�����׹���ȫ����ɣ���ʱ��ʮ�ꡣ�ù��̹���ƽ��1250��ɽͷ������151���ɲۣ�����211�������޽����ֽ�����12408����������ʯ��2225�������ף��������ܸ���ȫ��70.6���ɽ��ʯ���򡫺����δ��򣩣�����֧���ֲ�ȫ������
������ȫ��1500��������޽�������10�򡢺�ʱ��10���ΰ�󹤳̣��ǡ����й��漣��������Ϊ������ڰ˴��漣����";
                UIManager.Instance.Open(UIType.Tips, ObjectPool<TipsData>.Get().Set("�������羰��", strContent));
                roleController.Domove(BtnHqqfjq.transform.position, 0.5f);
            });
            BtnXtc.AddClick(() =>
            {
                string strContent = @"��ɽ��ʩ����ɳʯ�����ˡ������˵û�д��͹��ߣ�������Ҳû����ҵ�档��˶���С�Ƴ��ͳ�����Ϊʵ�õ����乤�ߡ������������Ľ���ʩ����С�Ƴ������÷������˼��£�������û��������Ҫ��";
                UIManager.Instance.Open(UIType.Tips, ObjectPool<TipsData>.Get().Set("С�Ƴ�", strContent));
                roleController.Domove(BtnXtc.transform.position, 0.5f);
            });
            BtnDq.AddClick(() =>
            {
                string strContent = @"�ں������ܸ���������Ů��ʱ��Ϊ�˷�������Ⱥ�����¹����������ʣ����ں��ϼ���������ľ�ţ����þ����������ں����ļ�������ľ�ű������������������Ҳֻ�ܴ�һ������ͨ��������Ӱ����ʩ�����ȡ�Ϊ��ȷ����Ѵ��ǰ�ܹ���������������Ǳ�����ɽ֮�䣬�����˿����ߡ����ڵ�ʱ���������صļ���ˮƽ��˵�����ȷ��һ�����£������ǲ���ʧ�ܡ������������֮�󣬿����ߴ��ĺӵİ��ߣ��ܵ�����Ů���ɽ����Ϊ�˼�������ߵ�ʹ��ǿ�ȣ��������ڻ���ˮ��ľ�֡�����ˮĥ��ԭ�����õ��������ϵ����������գ����ĺ��Ϲ�������11�������ߣ��ñ���ʯ�ҡ�ɳ��ˮ�ȴ�ɽ��ֱ���͵���ɽ�Ϲ��أ����ӿ���ʩ�����ȡ�";
                UIManager.Instance.Open(UIType.Tips, ObjectPool<TipsData>.Get().Set("����", strContent));
                roleController.Domove(BtnDq.transform.position, 0.5f);
            });
            BtnWzt.AddClick(() =>
            {
                string strContent = @"����������ͤ(ɽ�����������ȵ�Ϊ�ĺ�))
��������20����60���������������(�����������)�����ڼ�����ѵ������£���̫��ɽ���޽�����������ΰ�󹤳̡�����������Ϊ���й�ˮ���ǡ����ڹ����ϱ���Ϊ������ڰ˴��漣�����ں������޽������������γɵġ�������������ഴҵ���Ž�Э������˽���ס��ĺ��������񣬳�Ϊһ�ʱ���ľ���Ƹ���";
                UIManager.Instance.Open(UIType.Tips, ObjectPool<TipsData>.Get().Set("����ͤ", strContent));
                roleController.Domove(BtnWzt.transform.position, 0.5f);
            });
            BtnThyx.AddClick(() =>
            {
                string strContent = @"һ�����������̻�����ʲô�Ǽ��أ�

һ�������������Ͱ���һ���ܣ�

һ������������������������һ������ķᱮ��

���ǲ������ˣ�ȴ�������⣬

���ǲ���Ӣ�ۣ�ȴ�Ļ���ƪ��

����Ϊ�����еĿ��������

���Լ���Ѫ�⻯Ϊ����������Ļ�ʯ��

֧��������������
2023��7��1�����磬���й�������ӭ��102������֮�ʣ����й����һ�Ժ������ʦ��ѧԺ���������ɲ�ѧԺ�������죬�й����һ�Ժ�����ݳа��2023��ȹ����������𴫲������ƹ�������Ŀ��̫�зᱮ��������������Ӱ��չ�����й����һ�Ժ����¥�������������Ļ��չ���Խ��ټ�Ӱ����Ʒ��ȫ��λ����Ƕȡ�ʷʫ���չ���˼��������ƽ�������ߵĲ�������ӡ֤���й���������������׷�������Ҹ�����ĳ��ġ�";
                UIManager.Instance.Open(UIType.Tips, ObjectPool<TipsData>.Get().Set("̫��Ӱ��", strContent));
                roleController.Domove(BtnThyx.transform.position, 0.5f);
            });
            BtnHky.AddClick(() =>
            {
                string strContent = @"�����£��¸߰��ɣ�ɽ������ͻ��ʮ���ף����ϻ��ſ��Ĵ�ڡ�����ʱ��ɽ����ʱ���ɶ�ʯͷ���������ˣ����նӳ�����ɴ������Ķ�Ա������ӥչ���ڿ��е���ǧ���ɵ����Σ����ܵ������ڣ�������ʯ�����ǳ���л��ڰ��������Ǵ�ɽ�±���Ϊ�������¡���";
                UIManager.Instance.Open(UIType.Tips, ObjectPool<TipsData>.Get().Set("������", strContent));
                roleController.Domove(BtnHky.transform.position, 0.5f);
            });
            BtnQnc.AddClick(() =>
            {
                string strContent = @"���궴λ�ں������ܸ����δ�¬�ҹմ���ţ��ɽ�·������ܸ�������������궴�ӵ����ն�ʯ�ʼ�Ӳ��̫��ɽ����������μ��䶴��ͻ�����Ǵ�ȫ�����г��������300���������꣬��ȡ���С����궴�������궴�У���ͧ���У��ɾ�����ζ����ӵ��ۡ��Ķ��ظ��ܡ����������ǥ��������ճ��ա��ֳ����ݣ����ɣ����գ�����׷���Ƕ��������¡�������������������Ҷ��ɽ���Ǹ�Զ������ʡ��⾡���۵ס�";
                UIManager.Instance.Open(UIType.Tips, ObjectPool<TipsData>.Get().Set("���궴", strContent));
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
            Vector3 midPoint = (transform.position + target) / 2f; // �����м��
            midPoint.y = midPoint.y + 2f;
            Vector3[] path = new Vector3[] {
                transform.position,
                midPoint,
                target
            };
            //PathType.CatmullRom:�����߶���
            transform.DOPath(path, moveTime, PathType.CatmullRom, PathMode.TopDown2D).SetEase(Ease.OutQuad); // ʹ��DOPath��������������·������
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
