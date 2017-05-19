using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public static partial class PropertyDrawers {

	[CustomPropertyDrawer(typeof(BitFieldAttribute))]
	public class BitFieldDrawer : PropertyDrawer {

		private BitFieldAttribute _attributeValue = null;
		private BitFieldAttribute attributeValue {
			get {
				if (_attributeValue == null) _attributeValue = (BitFieldAttribute)attribute;
				return _attributeValue;
			}
		}


		public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
			label = EditorGUI.BeginProperty(position, label, property);
			Rect contentPosition = EditorGUI.PrefixLabel(position, label);

			property.intValue = EditorGUI.MaskField(contentPosition, property.intValue, attributeValue.valueList);
			EditorGUI.EndProperty();
		}

		public override float GetPropertyHeight(SerializedProperty property, GUIContent label) {
			return base.GetPropertyHeight(property, label);
		}
	}

}