using System;

namespace PuertsStaticWrap
{
    public static class AutoStaticCodeRegister
    {
        public static void Register(Puerts.JsEnv jsEnv)
        {
            jsEnv.AddLazyStaticWrapLoader(typeof(UnityEngine.Vector2), UnityEngine_Vector2_Wrap.GetRegisterInfo);
                
                
            jsEnv.AddLazyStaticWrapLoader(typeof(UnityEngine.Vector3), UnityEngine_Vector3_Wrap.GetRegisterInfo);
                
                
            jsEnv.AddLazyStaticWrapLoader(typeof(UnityEngine.Color), UnityEngine_Color_Wrap.GetRegisterInfo);
                
                
            jsEnv.AddLazyStaticWrapLoader(typeof(UnityEngine.SceneManagement.Scene), UnityEngine_SceneManagement_Scene_Wrap.GetRegisterInfo);
                
                
            jsEnv.AddLazyStaticWrapLoader(typeof(UnityEngine.Object), UnityEngine_Object_Wrap.GetRegisterInfo);
                
                
            jsEnv.AddLazyStaticWrapLoader(typeof(UnityEngine.Application), UnityEngine_Application_Wrap.GetRegisterInfo);
                
                
            jsEnv.AddLazyStaticWrapLoader(typeof(UnityEngine.SystemInfo), UnityEngine_SystemInfo_Wrap.GetRegisterInfo);
                
                
            jsEnv.AddLazyStaticWrapLoader(typeof(System.Array), System_Array_Wrap.GetRegisterInfo);
                
                
            jsEnv.AddLazyStaticWrapLoader(typeof(UnityEngine.Component), UnityEngine_Component_Wrap.GetRegisterInfo);
                
                
            jsEnv.AddLazyStaticWrapLoader(typeof(UnityEngine.AsyncOperation), UnityEngine_AsyncOperation_Wrap.GetRegisterInfo);
                
                
            jsEnv.AddLazyStaticWrapLoader(typeof(UnityEngine.Resources), UnityEngine_Resources_Wrap.GetRegisterInfo);
                
                
            jsEnv.AddLazyStaticWrapLoader(typeof(UnityEngine.TextAsset), UnityEngine_TextAsset_Wrap.GetRegisterInfo);
                
                
            jsEnv.AddLazyStaticWrapLoader(typeof(UnityEngine.GameObject), UnityEngine_GameObject_Wrap.GetRegisterInfo);
                
                
            jsEnv.AddLazyStaticWrapLoader(typeof(UnityEngine.Transform), UnityEngine_Transform_Wrap.GetRegisterInfo);
                
                
            jsEnv.AddLazyStaticWrapLoader(typeof(UnityEngine.RectTransform), UnityEngine_RectTransform_Wrap.GetRegisterInfo);
                
                
            jsEnv.AddLazyStaticWrapLoader(typeof(UnityEngine.CanvasGroup), UnityEngine_CanvasGroup_Wrap.GetRegisterInfo);
                
                
            jsEnv.AddLazyStaticWrapLoader(typeof(UnityEngine.AssetBundle), UnityEngine_AssetBundle_Wrap.GetRegisterInfo);
                
                
            jsEnv.AddLazyStaticWrapLoader(typeof(UnityEngine.Sprite), UnityEngine_Sprite_Wrap.GetRegisterInfo);
                
                
            jsEnv.AddLazyStaticWrapLoader(typeof(UnityEngine.UI.Graphic), UnityEngine_UI_Graphic_Wrap.GetRegisterInfo);
                
                
            jsEnv.AddLazyStaticWrapLoader(typeof(UnityEngine.UI.Image), UnityEngine_UI_Image_Wrap.GetRegisterInfo);
                
                
            jsEnv.AddLazyStaticWrapLoader(typeof(UnityEngine.UI.Text), UnityEngine_UI_Text_Wrap.GetRegisterInfo);
                
                
            jsEnv.AddLazyStaticWrapLoader(typeof(UnityEngine.UI.Button), UnityEngine_UI_Button_Wrap.GetRegisterInfo);
                
                
            jsEnv.AddLazyStaticWrapLoader(typeof(UnityEngine.UI.Toggle), UnityEngine_UI_Toggle_Wrap.GetRegisterInfo);
                
                
            jsEnv.AddLazyStaticWrapLoader(typeof(UnityEngine.UI.ToggleGroup), UnityEngine_UI_ToggleGroup_Wrap.GetRegisterInfo);
                
                
            jsEnv.AddLazyStaticWrapLoader(typeof(UnityEngine.UI.Slider), UnityEngine_UI_Slider_Wrap.GetRegisterInfo);
                
                
            jsEnv.AddLazyStaticWrapLoader(typeof(UnityEngine.UI.Button.ButtonClickedEvent), UnityEngine_UI_Button_ButtonClickedEvent_Wrap.GetRegisterInfo);
                
                
            jsEnv.AddLazyStaticWrapLoader(typeof(UnityEngine.Events.UnityEvent), UnityEngine_Events_UnityEvent_Wrap.GetRegisterInfo);
                
                
            jsEnv.AddLazyStaticWrapLoader(typeof(UnityEngine.Events.UnityEventBase), UnityEngine_Events_UnityEventBase_Wrap.GetRegisterInfo);
                
                
            jsEnv.AddLazyStaticWrapLoader(typeof(UnityEngine.PlayerPrefs), UnityEngine_PlayerPrefs_Wrap.GetRegisterInfo);
                
                
            jsEnv.AddLazyStaticWrapLoader(typeof(UnityEngine.Video.VideoPlayer), UnityEngine_Video_VideoPlayer_Wrap.GetRegisterInfo);
                
                
            jsEnv.AddLazyStaticWrapLoader(typeof(UnityEngine.Video.VideoClip), UnityEngine_Video_VideoClip_Wrap.GetRegisterInfo);
                
                
            jsEnv.AddLazyStaticWrapLoader(typeof(UnityEngine.Behaviour), UnityEngine_Behaviour_Wrap.GetRegisterInfo);
                
                
            jsEnv.AddLazyStaticWrapLoader(typeof(UnityEngine.Animator), UnityEngine_Animator_Wrap.GetRegisterInfo);
                
                
            jsEnv.AddLazyStaticWrapLoader(typeof(UnityEngine.Animation), UnityEngine_Animation_Wrap.GetRegisterInfo);
                
                
            jsEnv.AddLazyStaticWrapLoader(typeof(UnityEngine.AI.NavMeshAgent), UnityEngine_AI_NavMeshAgent_Wrap.GetRegisterInfo);
                
                
            jsEnv.AddLazyStaticWrapLoader(typeof(UnityEngine.EventSystems.PointerEventData), UnityEngine_EventSystems_PointerEventData_Wrap.GetRegisterInfo);
                
                
            jsEnv.AddLazyStaticWrapLoader(typeof(TMPro.TMP_Text), TMPro_TMP_Text_Wrap.GetRegisterInfo);
                
                
            jsEnv.AddLazyStaticWrapLoader(typeof(TMPro.TMP_InputField), TMPro_TMP_InputField_Wrap.GetRegisterInfo);
                
                
            jsEnv.AddLazyStaticWrapLoader(typeof(TMPro.TMP_Dropdown), TMPro_TMP_Dropdown_Wrap.GetRegisterInfo);
                
                
            jsEnv.AddLazyStaticWrapLoader(typeof(TestForTS), TestForTS_Wrap.GetRegisterInfo);
                
                
            jsEnv.AddLazyStaticWrapLoader(typeof(Au.TS.GameObjectExtension), Au_TS_GameObjectExtension_Wrap.GetRegisterInfo);
                
                
            jsEnv.AddLazyStaticWrapLoader(typeof(Au.TS.TSApp), Au_TS_TSApp_Wrap.GetRegisterInfo);
                
                
            jsEnv.AddLazyStaticWrapLoader(typeof(Au.TS.Messages.MonoCollision), Au_TS_Messages_MonoCollision_Wrap.GetRegisterInfo);
                
                
            jsEnv.AddLazyStaticWrapLoader(typeof(Au.TS.Messages.MonoDestroy), Au_TS_Messages_MonoDestroy_Wrap.GetRegisterInfo);
                
                
            jsEnv.AddLazyStaticWrapLoader(typeof(Au.TS.Messages.MonoDrag), Au_TS_Messages_MonoDrag_Wrap.GetRegisterInfo);
                
                
            jsEnv.AddLazyStaticWrapLoader(typeof(Au.TS.Messages.MonoEnable), Au_TS_Messages_MonoEnable_Wrap.GetRegisterInfo);
                
                
            jsEnv.AddLazyStaticWrapLoader(typeof(Au.TS.Messages.MonoFixedUpdate), Au_TS_Messages_MonoFixedUpdate_Wrap.GetRegisterInfo);
                
                
            jsEnv.AddLazyStaticWrapLoader(typeof(Au.TS.Messages.MonoLateUpdate), Au_TS_Messages_MonoLateUpdate_Wrap.GetRegisterInfo);
                
                
            jsEnv.AddLazyStaticWrapLoader(typeof(Au.TS.Messages.MonoPointer), Au_TS_Messages_MonoPointer_Wrap.GetRegisterInfo);
                
                
            jsEnv.AddLazyStaticWrapLoader(typeof(Au.TS.Messages.MonoStart), Au_TS_Messages_MonoStart_Wrap.GetRegisterInfo);
                
                
            jsEnv.AddLazyStaticWrapLoader(typeof(Au.TS.Messages.MonoTrigger), Au_TS_Messages_MonoTrigger_Wrap.GetRegisterInfo);
                
                
            jsEnv.AddLazyStaticWrapLoader(typeof(Au.TS.Messages.MonoUpdate), Au_TS_Messages_MonoUpdate_Wrap.GetRegisterInfo);
                
                
        }
    }
}