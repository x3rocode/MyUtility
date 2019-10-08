#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace UnityEngine.UIElements
{   public static class UIExtention
    {
  
        public static VisualElement GetUxmlByPath(string path)
        {
            VisualTreeAsset asset = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>(path);
            if (asset == null) return null;
            return asset.CloneTree();
        }
        public static StyleSheet GetUssByPath(string path)
        {
            StyleSheet asset = AssetDatabase.LoadAssetAtPath<StyleSheet>(path);
            if (asset == null) return null;
            return asset;
        }

        public static void LoadUxml(this VisualElement element, string path)
        {
            VisualTreeAsset asset = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>(path);
            VisualElement temp = asset.CloneTree();
            element = temp;
        }
        public static void LoadSheet(this VisualElement element, string path)
        {
            StyleSheet asset = AssetDatabase.LoadAssetAtPath<StyleSheet>(path);
            element.styleSheets.Add(asset);
        }

        public static void LoadUxmlAndSheet(this VisualElement element, string uxmlPath, string ussPath)
        {
            element.LoadUxml(uxmlPath);
            element.LoadSheet(ussPath);
        }

        public static T FindChildByName<T>(this VisualElement element, string name) where T : VisualElement
        {
            var builder = element.Query().Name(name);
            var build = builder.Build().First();
            if (build == null)
                return null;

            return build as T;
        }

        public static T FindChildByChild<T>(this VisualElement element, string className) where T : VisualElement
        {
            var builder = element.Query().Class(className);
            var build = builder.Build().First();
            if (build == null)
                return null;

            return build as T;
        }
        public static List<T> FindChildsByClass<T>(this VisualElement element, string className) where T : VisualElement
        {
            var builder = element.Query().Class(className);
            var build = builder.Build().ToList();
            if (build == null)
                return null;

            return build as List<T>;
        }
    }
}
#endif
