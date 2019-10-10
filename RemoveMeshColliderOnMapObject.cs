/*
 * 指定したオブジェクトのMeshRendererを削除するUnityエディタ拡張
 *
 * (C)2019 slip
 * This software is released under the MIT License.
 * http://opensource.org/licenses/mit-license.php
 * [Twitter]: https://twitter.com/kjmch2s/
 *
 * 利用規約：
 *  作者に無断で改変、再配布が可能で、利用形態（商用、18禁利用等）
 *  についても制限はありません。
 *  このスクリプトはもうあなたのものです。
 * 
 */

using UnityEngine;
using UnityEditor;

public class RemoveMeshColliderMenu : EditorWindow{
    public Object source;
    static RemoveMeshColliderOnMapObject m_OparateMeshCollider = new RemoveMeshColliderOnMapObject();

    [MenuItem("MapEditor/MeshCollider/削除")]
    private static void ApplySettingMenu()
    {
        EditorWindow.GetWindow<RemoveMeshColliderMenu>( "RemoveMeshCollider" );
    }

    private void OnGUI()
    {
        // 試しにラベルを表示
        EditorGUILayout.LabelField( "対象オブジェクトを選択してください（親オブジェクト）" );
        source = EditorGUILayout.ObjectField(source, typeof(GameObject), true);

        if( GUI.Button ( new Rect( 0.0f, 40.0f, 120.0f, 20.0f), "削除") ){
			m_OparateMeshCollider.RemoveMeshCollider((GameObject)source);
		}
    }
}

public class RemoveMeshColliderOnMapObject : MonoBehaviour {

    //コンポーネントを取得して該当コンポーネントを削除
    public void RemoveMeshCollider(GameObject target)
    {
        Component[] components = target.GetComponentsInChildren<Component>();
        foreach(Component component in components)
        {
            if (component.GetType().Name == "MeshCollider")
            {
                DestroyImmediate(component);
            }
        }
    }
}