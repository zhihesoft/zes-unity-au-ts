
declare module 'csharp' {
    //keep type incompatibility / 此属性保持类型不兼容
    const __keep_incompatibility: unique symbol;
    namespace CSharp {
        interface $Ref<T> {
            value: T
        }
        namespace System {
            interface Array$1<T> extends System.Array {
                get_Item(index: number):T;
                set_Item(index: number, value: T):void;
            }
        }
        interface $Task<T> {}
        namespace UnityEngine {
            /** Base class for all entities in Unity Scenes. */
            class GameObject extends UnityEngine.Object
            {
                protected [__keep_incompatibility]: never;
                /** The Transform attached to this GameObject. */
                public get transform(): UnityEngine.Transform;
                /** The layer the GameObject is in. */
                public get layer(): number;
                public set layer(value: number);
                /** The local active state of this GameObject. (Read Only) */
                public get activeSelf(): boolean;
                /** Defines whether the GameObject is active in the Scene. */
                public get activeInHierarchy(): boolean;
                /** Gets and sets the GameObject's StaticEditorFlags. */
                public get isStatic(): boolean;
                public set isStatic(value: boolean);
                /** The tag of this game object. */
                public get tag(): string;
                public set tag(value: string);
                /** Scene that the GameObject is part of. */
                public get scene(): UnityEngine.SceneManagement.Scene;
                /** Scene culling mask Unity uses to determine which scene to render the GameObject in. */
                public get sceneCullingMask(): bigint;
                public get gameObject(): UnityEngine.GameObject;
                /** Creates a game object with a primitive mesh renderer and appropriate collider. * @param type The type of primitive object to create.
                */
                public static CreatePrimitive ($type: UnityEngine.PrimitiveType) : UnityEngine.GameObject
                /** Returns the component of Type type if the game object has one attached, null if it doesn't. * @param type The type of Component to retrieve.
                */
                public GetComponent ($type: System.Type) : UnityEngine.Component
                /** Returns the component with name type if the GameObject has one attached, null if it doesn't. * @param type The type of Component to retrieve.
                */
                public GetComponent ($type: string) : UnityEngine.Component
                /** Returns the component of Type type in the GameObject or any of its children using depth first search.
                * @param type The type of Component to retrieve.
                * @returns A component of the matching type, if found. 
                */
                public GetComponentInChildren ($type: System.Type, $includeInactive: boolean) : UnityEngine.Component
                /** Returns the component of Type type in the GameObject or any of its children using depth first search.
                * @param type The type of Component to retrieve.
                * @returns A component of the matching type, if found. 
                */
                public GetComponentInChildren ($type: System.Type) : UnityEngine.Component
                /** Retrieves the component of Type type in the GameObject or any of its parents.
                * @param type Type of component to find.
                * @returns Returns a component if a component matching the type is found. Returns null otherwise. 
                */
                public GetComponentInParent ($type: System.Type, $includeInactive: boolean) : UnityEngine.Component
                /** Retrieves the component of Type type in the GameObject or any of its parents.
                * @param type Type of component to find.
                * @returns Returns a component if a component matching the type is found. Returns null otherwise. 
                */
                public GetComponentInParent ($type: System.Type) : UnityEngine.Component
                /** Returns all components of Type type in the GameObject. * @param type The type of component to retrieve.
                */
                public GetComponents ($type: System.Type) : System.Array$1<UnityEngine.Component>
                public GetComponents ($type: System.Type, $results: System.Collections.Generic.List$1<UnityEngine.Component>) : void
                /** Returns all components of Type type in the GameObject or any of its children children using depth first search. Works recursively. * @param type The type of Component to retrieve.
                * @param includeInactive Should Components on inactive GameObjects be included in the found set?
                */
                public GetComponentsInChildren ($type: System.Type) : System.Array$1<UnityEngine.Component>
                /** Returns all components of Type type in the GameObject or any of its children children using depth first search. Works recursively. * @param type The type of Component to retrieve.
                * @param includeInactive Should Components on inactive GameObjects be included in the found set?
                */
                public GetComponentsInChildren ($type: System.Type, $includeInactive: boolean) : System.Array$1<UnityEngine.Component>
                public GetComponentsInParent ($type: System.Type) : System.Array$1<UnityEngine.Component>
                /** Returns all components of Type type in the GameObject or any of its parents. * @param type The type of Component to retrieve.
                * @param includeInactive Should inactive Components be included in the found set?
                */
                public GetComponentsInParent ($type: System.Type, $includeInactive: boolean) : System.Array$1<UnityEngine.Component>
                /** Gets the component of the specified type, if it exists.
                * @param type The type of component to retrieve.
                * @param component The output argument that will contain the component or null.
                * @returns Returns true if the component is found, false otherwise. 
                */
                public TryGetComponent ($type: System.Type, $component: $Ref<UnityEngine.Component>) : boolean
                /** Returns one active GameObject tagged tag. Returns null if no GameObject was found. * @param tag The tag to search for.
                */
                public static FindWithTag ($tag: string) : UnityEngine.GameObject
                public SendMessageUpwards ($methodName: string, $options: UnityEngine.SendMessageOptions) : void
                public SendMessage ($methodName: string, $options: UnityEngine.SendMessageOptions) : void
                public BroadcastMessage ($methodName: string, $options: UnityEngine.SendMessageOptions) : void
                /** Adds a component class of type componentType to the game object. C# Users can use a generic version. */
                public AddComponent ($componentType: System.Type) : UnityEngine.Component
                /** ActivatesDeactivates the GameObject, depending on the given true or false/ value. * @param value Activate or deactivate the object, where true activates the GameObject and false deactivates the GameObject.
                */
                public SetActive ($value: boolean) : void
                /** Is this game object tagged with tag ? * @param tag The tag to compare.
                */
                public CompareTag ($tag: string) : boolean
                public static FindGameObjectWithTag ($tag: string) : UnityEngine.GameObject
                /** Returns an array of active GameObjects tagged tag. Returns empty array if no GameObject was found. * @param tag The name of the tag to search GameObjects for.
                */
                public static FindGameObjectsWithTag ($tag: string) : System.Array$1<UnityEngine.GameObject>
                /** Calls the method named methodName on every MonoBehaviour in this game object and on every ancestor of the behaviour. * @param methodName The name of the method to call.
                * @param value An optional parameter value to pass to the called method.
                * @param options Should an error be raised if the method doesn't exist on the target object?
                */
                public SendMessageUpwards ($methodName: string, $value: any, $options: UnityEngine.SendMessageOptions) : void
                /** Calls the method named methodName on every MonoBehaviour in this game object and on every ancestor of the behaviour. * @param methodName The name of the method to call.
                * @param value An optional parameter value to pass to the called method.
                * @param options Should an error be raised if the method doesn't exist on the target object?
                */
                public SendMessageUpwards ($methodName: string, $value: any) : void
                /** Calls the method named methodName on every MonoBehaviour in this game object and on every ancestor of the behaviour. * @param methodName The name of the method to call.
                * @param value An optional parameter value to pass to the called method.
                * @param options Should an error be raised if the method doesn't exist on the target object?
                */
                public SendMessageUpwards ($methodName: string) : void
                /** Calls the method named methodName on every MonoBehaviour in this game object. * @param methodName The name of the method to call.
                * @param value An optional parameter value to pass to the called method.
                * @param options Should an error be raised if the method doesn't exist on the target object?
                */
                public SendMessage ($methodName: string, $value: any, $options: UnityEngine.SendMessageOptions) : void
                /** Calls the method named methodName on every MonoBehaviour in this game object. * @param methodName The name of the method to call.
                * @param value An optional parameter value to pass to the called method.
                * @param options Should an error be raised if the method doesn't exist on the target object?
                */
                public SendMessage ($methodName: string, $value: any) : void
                /** Calls the method named methodName on every MonoBehaviour in this game object. * @param methodName The name of the method to call.
                * @param value An optional parameter value to pass to the called method.
                * @param options Should an error be raised if the method doesn't exist on the target object?
                */
                public SendMessage ($methodName: string) : void
                /** Calls the method named methodName on every MonoBehaviour in this game object or any of its children. */
                public BroadcastMessage ($methodName: string, $parameter: any, $options: UnityEngine.SendMessageOptions) : void
                /** Calls the method named methodName on every MonoBehaviour in this game object or any of its children. */
                public BroadcastMessage ($methodName: string, $parameter: any) : void
                /** Calls the method named methodName on every MonoBehaviour in this game object or any of its children. */
                public BroadcastMessage ($methodName: string) : void
                /** Finds a GameObject by name and returns it. */
                public static Find ($name: string) : UnityEngine.GameObject
                public constructor ($name: string)
                public constructor ()
                public constructor ($name: string, ...components: System.Type[])
            }
            /** Base class for all objects Unity can reference. */
            class Object extends System.Object
            {
                protected [__keep_incompatibility]: never;
            }
            /** The various primitives that can be created using the GameObject.CreatePrimitive function. */
            enum PrimitiveType
            { Sphere = 0, Capsule = 1, Cylinder = 2, Cube = 3, Plane = 4, Quad = 5 }
            /** Base class for everything attached to GameObjects. */
            class Component extends UnityEngine.Object
            {
                protected [__keep_incompatibility]: never;
            }
            /** Options for how to send a message. */
            enum SendMessageOptions
            { RequireReceiver = 0, DontRequireReceiver = 1 }
            /** Position, rotation and scale of an object. */
            class Transform extends UnityEngine.Component implements System.Collections.IEnumerable
            {
                protected [__keep_incompatibility]: never;
            }
            /** MonoBehaviour is the base class from which every Unity script derives. */
            class MonoBehaviour extends UnityEngine.Behaviour
            {
                protected [__keep_incompatibility]: never;
                /** Disabling this lets you skip the GUI layout phase. */
                public get useGUILayout(): boolean;
                public set useGUILayout(value: boolean);
                /** Allow a specific instance of a MonoBehaviour to run in edit mode (only available in the editor). */
                public get runInEditMode(): boolean;
                public set runInEditMode(value: boolean);
                public IsInvoking () : boolean
                public CancelInvoke () : void
                /** Invokes the method methodName in time seconds. */
                public Invoke ($methodName: string, $time: number) : void
                /** Invokes the method methodName in time seconds, then repeatedly every repeatRate seconds. */
                public InvokeRepeating ($methodName: string, $time: number, $repeatRate: number) : void
                /** Cancels all Invoke calls with name methodName on this behaviour. */
                public CancelInvoke ($methodName: string) : void
                /** Is any invoke on methodName pending? */
                public IsInvoking ($methodName: string) : boolean
                /** Starts a coroutine named methodName. */
                public StartCoroutine ($methodName: string) : UnityEngine.Coroutine
                /** Starts a coroutine named methodName. */
                public StartCoroutine ($methodName: string, $value: any) : UnityEngine.Coroutine
                /** Starts a Coroutine. */
                public StartCoroutine ($routine: System.Collections.IEnumerator) : UnityEngine.Coroutine
                /** Stops the first coroutine named methodName, or the coroutine stored in routine running on this behaviour. * @param methodName Name of coroutine.
                * @param routine Name of the function in code, including coroutines.
                */
                public StopCoroutine ($routine: System.Collections.IEnumerator) : void
                /** Stops the first coroutine named methodName, or the coroutine stored in routine running on this behaviour. * @param methodName Name of coroutine.
                * @param routine Name of the function in code, including coroutines.
                */
                public StopCoroutine ($routine: UnityEngine.Coroutine) : void
                /** Stops the first coroutine named methodName, or the coroutine stored in routine running on this behaviour. * @param methodName Name of coroutine.
                * @param routine Name of the function in code, including coroutines.
                */
                public StopCoroutine ($methodName: string) : void
                public StopAllCoroutines () : void
                /** Logs message to the Unity Console (identical to Debug.Log). */
                public static print ($message: any) : void
                public constructor ()
            }
            /** Behaviours are Components that can be enabled or disabled. */
            class Behaviour extends UnityEngine.Component
            {
                protected [__keep_incompatibility]: never;
            }
            /** MonoBehaviour.StartCoroutine returns a Coroutine. Instances of this class are only used to reference these coroutines, and do not hold any exposed properties or functions. */
            class Coroutine extends UnityEngine.YieldInstruction
            {
                protected [__keep_incompatibility]: never;
            }
            /** Base class for all yield instructions. */
            class YieldInstruction extends System.Object
            {
                protected [__keep_incompatibility]: never;
            }
        }
        namespace System {
            class Object
            {
                protected [__keep_incompatibility]: never;
            }
            class Enum extends System.ValueType implements System.IFormattable, System.IComparable, System.IConvertible
            {
                protected [__keep_incompatibility]: never;
            }
            class ValueType extends System.Object
            {
                protected [__keep_incompatibility]: never;
            }
            interface IFormattable
            {
            }
            interface IComparable
            {
            }
            interface IConvertible
            {
            }
            class Type extends System.Reflection.MemberInfo implements System.Runtime.InteropServices._MemberInfo, System.Runtime.InteropServices._Type, System.Reflection.ICustomAttributeProvider, System.Reflection.IReflect
            {
                protected [__keep_incompatibility]: never;
            }
            class String extends System.Object implements System.ICloneable, System.IComparable, System.IComparable$1<string>, System.IConvertible, System.Collections.Generic.IEnumerable$1<number>, System.Collections.IEnumerable, System.IEquatable$1<string>
            {
                protected [__keep_incompatibility]: never;
            }
            interface ICloneable
            {
            }
            interface IComparable$1<T>
            {
            }
            class Char extends System.ValueType implements System.IComparable, System.IComparable$1<number>, System.IConvertible, System.IEquatable$1<number>
            {
                protected [__keep_incompatibility]: never;
            }
            interface IEquatable$1<T>
            {
            }
            class Boolean extends System.ValueType implements System.IComparable, System.IComparable$1<boolean>, System.IConvertible, System.IEquatable$1<boolean>
            {
                protected [__keep_incompatibility]: never;
            }
            class Array extends System.Object implements System.Collections.IStructuralComparable, System.Collections.IStructuralEquatable, System.ICloneable, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList
            {
                protected [__keep_incompatibility]: never;
            }
            class Void extends System.ValueType
            {
                protected [__keep_incompatibility]: never;
            }
            class Int32 extends System.ValueType implements System.IFormattable, System.ISpanFormattable, System.IComparable, System.IComparable$1<number>, System.IConvertible, System.IEquatable$1<number>
            {
                protected [__keep_incompatibility]: never;
            }
            interface ISpanFormattable
            {
            }
            class UInt64 extends System.ValueType implements System.IFormattable, System.ISpanFormattable, System.IComparable, System.IComparable$1<bigint>, System.IConvertible, System.IEquatable$1<bigint>
            {
                protected [__keep_incompatibility]: never;
            }
            class Single extends System.ValueType implements System.IFormattable, System.ISpanFormattable, System.IComparable, System.IComparable$1<number>, System.IConvertible, System.IEquatable$1<number>
            {
                protected [__keep_incompatibility]: never;
            }
        }
        namespace System.Reflection {
            class MemberInfo extends System.Object implements System.Runtime.InteropServices._MemberInfo, System.Reflection.ICustomAttributeProvider
            {
                protected [__keep_incompatibility]: never;
            }
            interface ICustomAttributeProvider
            {
            }
            interface IReflect
            {
            }
        }
        namespace System.Runtime.InteropServices {
            interface _MemberInfo
            {
            }
            interface _Type
            {
            }
        }
        namespace System.Collections.Generic {
            interface IEnumerable$1<T> extends System.Collections.IEnumerable
            {
            }
            interface IReadOnlyList$1<T> extends System.Collections.Generic.IEnumerable$1<T>, System.Collections.IEnumerable, System.Collections.Generic.IReadOnlyCollection$1<T>
            {
            }
            interface IReadOnlyCollection$1<T> extends System.Collections.Generic.IEnumerable$1<T>, System.Collections.IEnumerable
            {
            }
            interface IList$1<T> extends System.Collections.Generic.IEnumerable$1<T>, System.Collections.IEnumerable, System.Collections.Generic.ICollection$1<T>
            {
            }
            interface ICollection$1<T> extends System.Collections.Generic.IEnumerable$1<T>, System.Collections.IEnumerable
            {
            }
            class List$1<T> extends System.Object implements System.Collections.Generic.IReadOnlyList$1<T>, System.Collections.ICollection, System.Collections.Generic.IEnumerable$1<T>, System.Collections.IEnumerable, System.Collections.Generic.IList$1<T>, System.Collections.Generic.IReadOnlyCollection$1<T>, System.Collections.IList, System.Collections.Generic.ICollection$1<T>
            {
                protected [__keep_incompatibility]: never;
            }
        }
        namespace System.Collections {
            interface IEnumerable
            {
            }
            interface IStructuralComparable
            {
            }
            interface IStructuralEquatable
            {
            }
            interface ICollection extends System.Collections.IEnumerable
            {
            }
            interface IList extends System.Collections.ICollection, System.Collections.IEnumerable
            {
            }
            interface IEnumerator
            {
            }
        }
        namespace UnityEngine.SceneManagement {
            /** Run-time data structure for *.unity file. */
            class Scene extends System.ValueType
            {
                protected [__keep_incompatibility]: never;
            }
        }
            class TestForTS extends System.Object
            {
                protected [__keep_incompatibility]: never;
                public GetHello () : string
                public NoneFunc () : string
                public constructor ()
            }
    }
    export = CSharp;
}
