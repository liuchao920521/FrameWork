using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LuaInterface;
using System.IO;

namespace WZQ
{
	public class LuaManager : MonoBehaviour
	{
		private LuaState lua;
		//private LuaLoader loader;
		private LuaLooper loop = null;
		void Awake()
		{
			lua = new LuaState();
			lua.LuaSetTop(0);
			LuaBinder.Bind(lua);
			DelegateFactory.Init();
			LuaCoroutine.Register(lua, this);
		}
	}
}
