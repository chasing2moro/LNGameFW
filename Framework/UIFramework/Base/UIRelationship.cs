using UnityEngine;
using System.Collections;
using System.Collections.Generic;
class RelationList
{
	public UIProperty NodeProperty;
	public List<RelationList> ChildList = new List<RelationList>();
}
public class UIRelationship : MonoBehaviour {

	// Use this for initialization
	RelationList pRelationList = new RelationList();
	
	void Awake () 
	{
		AddUIPropertyInList(transform, pRelationList);
		//Debug.Log(pRelationList.ChildList[0].ChildList[0].NodeProperty.name);
	}
	
	void AddUIPropertyInList(Transform Node, RelationList pList)
	{
		if(Node.GetComponent<UIProperty>() != null)
		{
			pList.NodeProperty = Node.GetComponent<UIProperty>();
		}
		for(int i = 0; i < Node.childCount; i++)
		{
			RelationList Tmp = new RelationList();
			AddUIPropertyInList(Node.GetChild(i), Tmp);
			pList.ChildList.Add(Tmp);
		}
	}
	
	public UIProperty GetUIPropertyWithUIName(string Name)
	{
		//Debug.Log(Name+" ");
		return GetUIPropertyWithName(Name, pRelationList);
	}

	UIProperty GetUIPropertyWithName(string Name, RelationList pList)
	{
		//Debug.Log(Name+" "+pList.NodeProperty);
		if(pList.NodeProperty)
		{
			if(pList.NodeProperty.name == Name)
				return pList.NodeProperty;
		}
		foreach(RelationList Tmp in pList.ChildList)
		{
			UIProperty TmpProperty = GetUIPropertyWithName(Name, Tmp);
			if(TmpProperty != null)
			{
				return TmpProperty;
			}
		}
		return null;
	}

}
