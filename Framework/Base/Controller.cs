using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {
		
	protected void RegistListen(uint EventID,RegistFunction pFunction)
	{
		Facade.Singleton().RegistListen(EventID,pFunction);
	}
	protected void UnRegistListen(uint EventID,RegistFunction pFunction)
	{
		Facade.Singleton().UnRegistListen(EventID,pFunction);
	}
	protected void RegistEvent(uint EventID,RegistFunction pFunction)
	{	
		Facade.Singleton().RegistEvent(EventID,pFunction);
	}
	protected void UnRegistEvent(uint EventID,RegistFunction pFunction)
	{
		Facade.Singleton().UnRegistEvent(EventID,pFunction);
	}
	protected object SendEvent(uint EventID,object pSender)
	{
		return Facade.Singleton().SendEvent(EventID,pSender);
	}
}
