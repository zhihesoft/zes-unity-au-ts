using Puerts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

namespace Au.TS
{
    /// <summary>
    /// Get types of JSWrap attribute
    /// </summary>
    [Configure]
    public static class JSWrapper
    {
        [Binding]
        public static IEnumerable<Type> DefaultBindings
        {
            get
            {
                return new Type[]
                {
                    // unity engine
                    typeof(ScreenOrientation),
                    typeof(ScaleMode),

                    typeof(Vector2),
                    typeof(Vector3),
                    typeof(Color),
                    typeof(Scene),
                    typeof(Ray),
                    typeof(RaycastHit),
                    typeof(LayerMask),

                    typeof(UnityEngine.Object),
                    typeof(Application),
                    typeof(SystemInfo),
                    typeof(Array),
                    typeof(Component),
                    typeof(AsyncOperation),
                    typeof(Resources),
                    typeof(TextAsset),
                    typeof(GameObject),
                    typeof(Transform),
                    typeof(RectTransform),
                    typeof(CanvasGroup),
                    typeof(AssetBundle),
                    typeof(Sprite),
                    typeof(Graphic),
                    typeof(Image),
                    typeof(Text),
                    typeof(Button),
                    typeof(Toggle),
                    typeof(ToggleGroup),
                    typeof(Slider),
                    typeof(Button.ButtonClickedEvent),
                    typeof(UnityEvent),
                    typeof(UnityEventBase),
                    typeof(PlayerPrefs),
                    typeof(VideoPlayer),
                    typeof(VideoClip),
                    typeof(Behaviour),
                    typeof(Animator),
                    typeof(Animation),
                    typeof(AnimationClip),
                    typeof(UnityEngine.AI.NavMeshAgent),
                    typeof(PointerEventData),
                    typeof(AnimationCurve),
                    typeof(Screen),
                    typeof(Collider),
                    typeof(Collision),
                    typeof(CanvasScaler),
                    typeof(RawImage),
                    typeof(RenderTexture),
                    typeof(Texture),
                    typeof(AudioListener),
                    typeof(AudioSource),
                    typeof(AudioClip),

                    typeof(TMP_Text),
                    typeof(TMP_InputField),
                    typeof(TMP_Dropdown),

                };
            }
        }

        [Binding]
        public static IEnumerable<Type> Bind
        {
            get
            {
                List<Type> typesList = new List<Type>();

                var wrapTypes = from assembly in AppDomain.CurrentDomain.GetAssemblies()
                                where !(assembly.ManifestModule is System.Reflection.Emit.ModuleBuilder)
                                from type in assembly.GetTypes()
                                where type.IsDefined(typeof(JSWrapAttribute), false)
                                select type;

                typesList.AddRange(wrapTypes);
                return typesList;
            }
        }

        [Filter]
        public static bool Filter(MemberInfo mb)
        {
            Dictionary<string, Type> ignoreMethods = new Dictionary<string, Type>{
                { "PlayOnGamepad", typeof(AudioSource) },
                { "DisableGamepadOutput", typeof(AudioSource) },
                { "SetGamepadSpeakerMixLevel" ,typeof(AudioSource) },
                { "SetGamepadSpeakerMixLevelDefault", typeof(AudioSource) },
                { "SetGamepadSpeakerRestrictedAudio", typeof(AudioSource) },
                { "GamepadSpeakerOutputTyp", typeof(AudioSource) },
                { "gamepadSpeakerOutputType", typeof(AudioSource) },
                { "imageContentsHash", typeof(Texture) },
            };
            if (mb.IsDefined(typeof(JSIgnoreAttribute), false))
            {
                // Debug.Log($"{mb} is ignore");
                return true;
            }

            if (ignoreMethods.TryGetValue(mb.Name, out var type))
            {
                if (mb.DeclaringType == type)
                {
                    return true;
                }
            }

            if (mb.Name == "OnRebuildRequested")
            {
                return true;
            }
            return false;
        }
    }
}
