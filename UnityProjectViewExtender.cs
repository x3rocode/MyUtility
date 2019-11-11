public class UnityProjectViewExtender
{
    [MenuItem("Assets/HamsterLibs/Tool/CopyGUID")]
    public static void GUIDCopy()
    {
        var guid = AssetDatabase.AssetPathToGUID(AssetDatabase.GetAssetPath(Selection.activeObject));
        var textEditor = new TextEditor();
        textEditor.text = guid;
        textEditor.SelectAll();
        textEditor.Copy(); 
        Debug.Log("GUID Copy ! => " + guid);
    } 
}
