using UnityEditor;
using System;
using UnityEngine;

public class BitFieldAttribute : PropertyAttribute {

	public readonly string[] valueList;
	
	public BitFieldAttribute(Type enumType) {
		valueList = Enum.GetNames(enumType);
	}

	public BitFieldAttribute(string[] names) {
		valueList = names;
	}
}
