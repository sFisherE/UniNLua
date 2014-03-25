using UnityEngine;
using System.Collections;
using NLua;
public class LuaTest : MonoBehaviour {
   public string luaFileToLoad;
	// Use this for initialization
	public static LuaTest instance;
	void Awake()
	{
		instance=this;
	}
	void Start () {
        Lua lua = new Lua();
        lua.DoFile(Unity3DIntegration.rootPath + "/" + luaFileToLoad);
        //lua.DoFile(Application.streamingAssetsPath + "/LuaRoot/" + luaFileToLoad);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void Test()
	{
	Debug.Log("@C#:Test");
	}
}
