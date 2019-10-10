# 指定したオブジェクト、子オブジェクトへのMeshColliderの一括追加と一括削除
## 概要
MeshRendererが付けられたオブジェクト(子オブジェクト含む)にMeshColliderを追加する機能<br>
MeshColliderをオブジェクトから削除する機能をUnityエディタに追加します（エディタ拡張）<br>

# 0 準備
本スクリプトはUnity上で動作します。<br>

[動作確認済みの環境]<br>
・Unity 2019 2.0f1<br>

## 0.1 導入
1．Unityを起動する<br>
2．以下のファイルをUnityに入れる<br>
・AddMeshColliderOnMapObject.cs<br>
・RemoveMeshColliderOnMapObject.cs<br>

## 0.2 メニュー一覧
以下のように表示されます<br>
![MenuList](https://github.com/MrSlip777/MapEditorScript/blob/picture/%E3%83%A1%E3%83%8B%E3%83%A5%E3%83%BC%E4%B8%80%E8%A6%A7.png)

# 1 MeshColliderを付ける方法
1. MapEditor→AddMeshColliderを押下する
2. オブジェクト欄にMeshColliderを付けたいオブジェクト（親オブジェクト）を設定する
![AddMeshCollider](https://github.com/MrSlip777/MapEditorScript/blob/picture/Addmeshcollider.png)
3. 追加ボタンを押下する

# 2 MeshColliderを削除する方法
1. MapEditor→RemoveMeshColliderを押下する
2. オブジェクト欄にMeshColliderを削除したいオブジェクト（親オブジェクト）を設定する
![RemoveMeshCollider](https://github.com/MrSlip777/MapEditorScript/blob/picture/Removemeshcollider.png)
3. 削除ボタンを押下する
