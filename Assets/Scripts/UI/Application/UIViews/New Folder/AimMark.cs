using UnityEngine;

// ������־�Ŀ�����
public class AimMark : MonoBehaviour
{
    [SerializeField]
    private Animator animator;
    public Canvas ParentCanvas;                   // �����ڵ�Canvas
    public Camera CanvasCamera;                   // Canvas����Ⱦ���
    public RectTransform ParentRectTransform;     // ���ڵ��RectTransform    
    public Transform Target;                      // ������Ŀ��
    public Camera mainCamera;                                  // ��Ϸ���������� 
    private Camera MainCamera
    {
        get
        {
            if (mainCamera == null)
            {
                mainCamera = Camera.main;
            }
            return mainCamera;
        }
    }

    // ָ��һ����ʾ������־����Ļ��Χ
    private Rect ViewProtRect { get; } = new Rect(0f, 0f, 1f, 1f);
    // ��¼��һ֡�Ƿ��ڷ�Χ�ڵ�״̬�����ں͵�ǰ״̬�Աȵõ�ת����˲��
    private bool IsInScreen { get; set; }

    public void Setup(Canvas rootCanvas, RectTransform rootRectTransform, Transform target)
    {
        ParentCanvas = rootCanvas;
        ParentRectTransform = rootRectTransform;
        CanvasCamera = ParentCanvas.worldCamera;
        SetAimTarget(target);
    }

    public void SetAimTarget(Transform target)
    {
        Target = target;
        IsInScreen = false;
    }

    public void PlayLockAnimation(bool isLock)
    {
        if (isLock)
            animator.SetTrigger("Lock");
        else
            animator.SetTrigger("UnLock");
    }

    private void LateUpdate()
    {
        if (Target == null)
        {
            Destroy(gameObject);
            return;
        }

        if (IsTargetInScreen())
        {
            if (!IsInScreen)
            {
                IsInScreen = true;
                //PlayLockAnimation(true);
            }

            // ��Target����������ת��ת������Ļ���꣬�ٽ���ת������RectTransform�ڵľֲ�����
            var screenPoint = RectTransformUtility.WorldToScreenPoint(MainCamera, Target.position);
            if (RectTransformUtility.ScreenPointToLocalPointInRectangle(ParentRectTransform, screenPoint, CanvasCamera, out var vector2))
            {
                transform.localPosition = vector2;
            }
        }
        else
        {
            transform.localPosition = new Vector3(2000, 2000);
            if (IsInScreen)
            {
                IsInScreen = false;
                //PlayLockAnimation(false);
            }
        }
    }

    // �ж����������Ƿ��ڿ��ӷ�Χ��
    private bool IsTargetInScreen()
    {
        // ת��Ŀ���������������Ļ����
        var point = MainCamera.WorldToViewportPoint(Target.position);

        // ��Ļ�����zֵ��������Ľ������Զ����֮�䣬���Ҵ�����Ļ��Χ�ڣ�����ʾ���������ڿ��ӷ�Χ��
        var isInScreen = point.z > MainCamera.nearClipPlane && point.z < MainCamera.farClipPlane && ViewProtRect.Contains(point) && Target.gameObject.activeInHierarchy;

        return isInScreen ;
    }
}
