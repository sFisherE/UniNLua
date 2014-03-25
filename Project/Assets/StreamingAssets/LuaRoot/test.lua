UnityEngine=luanet.UnityEngine
--Debug=UnityEngine.Debug
luanet.load_assembly "Assembly-CSharp"
local LuaTest=luanet.import_type "LuaTest"
local luaTest=LuaTest.instance
luaTest:Test()

print("hello nlua")