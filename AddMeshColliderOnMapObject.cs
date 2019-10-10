/*
 * MeshRendererが付けられているオブジェクトにMeshColliderを付けるUnityエディタ拡張
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

public class AddMeshColliderMenu : EditorWindow{
    public Object source;
    static AddMeshColliderOnMapObject m_OparateMeshCollider = new AddMeshColliderOnMapObject();

    [MenuItem("MapEditor/MeshCollider/追加")]
    private static void ApplySettingMenu()
    {
        EditorWindow.GetWindow<AddMeshColliderMenu>( "AddMeshCollider" );
    }

    private void OnGUI()
    {
        // 試しにラベルを表示
        EditorGUILayout.LabelField( "対象オブジェクトを選択してください（親オブジェクト）" );
        source = EditorGUILayout.ObjectField(source, typeof(GameObject), true);

        if( GUI.Button ( new Rect( 0.0f, 40.0f, 120.0f, 20.0f), "追加") ){
			m_OparateMeshCollider.AddMeshCollider((GameObject)source);
		}
    }
}

public class AddMeshColliderOnMapObject : MonoBehaviour {

    //コンポーネントを取得して該当コンポーネントを追加
    public void AddMeshCollider(GameObject target)
    {
        Component[] components = target.GetComponentsInChildren<Component>();
        foreach(Component component in components)
        {
            if (component.GetType().Name == "MeshRenderer")
            {
                if(component.gameObject.GetComponent<MeshCollider>() == null)
                {
                    component.gameObject.AddComponent<MeshCollider>();
                    
                }
            }
        }
    }
}