﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UnityEngine_ParticleSystemWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UnityEngine.ParticleSystem), typeof(UnityEngine.Component));
		L.RegFunction("SetParticles", SetParticles);
		L.RegFunction("GetParticles", GetParticles);
		L.RegFunction("SetCustomParticleData", SetCustomParticleData);
		L.RegFunction("GetCustomParticleData", GetCustomParticleData);
		L.RegFunction("GetPlaybackState", GetPlaybackState);
		L.RegFunction("SetPlaybackState", SetPlaybackState);
		L.RegFunction("GetTrails", GetTrails);
		L.RegFunction("SetTrails", SetTrails);
		L.RegFunction("Simulate", Simulate);
		L.RegFunction("Play", Play);
		L.RegFunction("Pause", Pause);
		L.RegFunction("Stop", Stop);
		L.RegFunction("Clear", Clear);
		L.RegFunction("IsAlive", IsAlive);
		L.RegFunction("Emit", Emit);
		L.RegFunction("TriggerSubEmitter", TriggerSubEmitter);
		L.RegFunction("ResetPreMappedBufferMemory", ResetPreMappedBufferMemory);
		L.RegFunction("New", _CreateUnityEngine_ParticleSystem);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("isPlaying", get_isPlaying, null);
		L.RegVar("isEmitting", get_isEmitting, null);
		L.RegVar("isStopped", get_isStopped, null);
		L.RegVar("isPaused", get_isPaused, null);
		L.RegVar("particleCount", get_particleCount, null);
		L.RegVar("time", get_time, set_time);
		L.RegVar("randomSeed", get_randomSeed, set_randomSeed);
		L.RegVar("useAutoRandomSeed", get_useAutoRandomSeed, set_useAutoRandomSeed);
		L.RegVar("proceduralSimulationSupported", get_proceduralSimulationSupported, null);
		L.RegVar("main", get_main, null);
		L.RegVar("emission", get_emission, null);
		L.RegVar("shape", get_shape, null);
		L.RegVar("velocityOverLifetime", get_velocityOverLifetime, null);
		L.RegVar("limitVelocityOverLifetime", get_limitVelocityOverLifetime, null);
		L.RegVar("inheritVelocity", get_inheritVelocity, null);
		L.RegVar("lifetimeByEmitterSpeed", get_lifetimeByEmitterSpeed, null);
		L.RegVar("forceOverLifetime", get_forceOverLifetime, null);
		L.RegVar("colorOverLifetime", get_colorOverLifetime, null);
		L.RegVar("colorBySpeed", get_colorBySpeed, null);
		L.RegVar("sizeOverLifetime", get_sizeOverLifetime, null);
		L.RegVar("sizeBySpeed", get_sizeBySpeed, null);
		L.RegVar("rotationOverLifetime", get_rotationOverLifetime, null);
		L.RegVar("rotationBySpeed", get_rotationBySpeed, null);
		L.RegVar("externalForces", get_externalForces, null);
		L.RegVar("noise", get_noise, null);
		L.RegVar("collision", get_collision, null);
		L.RegVar("trigger", get_trigger, null);
		L.RegVar("subEmitters", get_subEmitters, null);
		L.RegVar("textureSheetAnimation", get_textureSheetAnimation, null);
		L.RegVar("lights", get_lights, null);
		L.RegVar("trails", get_trails, null);
		L.RegVar("customData", get_customData, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateUnityEngine_ParticleSystem(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				UnityEngine.ParticleSystem obj = new UnityEngine.ParticleSystem();
				ToLua.PushSealed(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: UnityEngine.ParticleSystem.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetParticles(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes<LuaInterface.LuaOut<UnityEngine.ParticleSystem.Particle>>(L, 2))
			{
				UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)ToLua.CheckObject(L, 1, typeof(UnityEngine.ParticleSystem));
				UnityEngine.ParticleSystem.Particle[] arg0 = null;
				obj.SetParticles(arg0);
				return 0;
			}
			else if (count == 2 && TypeChecker.CheckTypes<UnityEngine.ParticleSystem>(L, 2))
			{
				UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)ToLua.CheckObject(L, 1, typeof(UnityEngine.ParticleSystem));
				Unity.Collections.NativeArray<UnityEngine.ParticleSystem.Particle> arg0;
				//obj.SetParticles(arg0);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes<LuaInterface.LuaOut<UnityEngine.ParticleSystem.Particle>, int>(L, 2))
			{
				UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)ToLua.CheckObject(L, 1, typeof(UnityEngine.ParticleSystem));
				UnityEngine.ParticleSystem.Particle[] arg0 = null;
				int arg1 = (int)LuaDLL.lua_tonumber(L, 3);
				obj.SetParticles(arg0, arg1);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes<int>(L, 2))
			{
				UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)ToLua.CheckObject(L, 1, typeof(UnityEngine.ParticleSystem));
				Unity.Collections.NativeArray<UnityEngine.ParticleSystem.Particle> arg0;
				int arg1 = (int)LuaDLL.lua_tonumber(L, 3);
				//obj.SetParticles(arg0, arg1);
				return 0;
			}
			else if (count == 4 && TypeChecker.CheckTypes<LuaInterface.LuaOut<UnityEngine.ParticleSystem.Particle>, int, int>(L, 2))
			{
				UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)ToLua.CheckObject(L, 1, typeof(UnityEngine.ParticleSystem));
				UnityEngine.ParticleSystem.Particle[] arg0 = null;
				int arg1 = (int)LuaDLL.lua_tonumber(L, 3);
				int arg2 = (int)LuaDLL.lua_tonumber(L, 4);
				obj.SetParticles(arg0, arg1, arg2);
				return 0;
			}
			else if (count == 4 && TypeChecker.CheckTypes<int, int>(L, 2))
			{
				UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)ToLua.CheckObject(L, 1, typeof(UnityEngine.ParticleSystem));
				Unity.Collections.NativeArray<UnityEngine.ParticleSystem.Particle> arg0;
				int arg1 = (int)LuaDLL.lua_tonumber(L, 3);
				int arg2 = (int)LuaDLL.lua_tonumber(L, 4);
				//obj.SetParticles(arg0, arg1, arg2);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.ParticleSystem.SetParticles");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetParticles(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes<LuaInterface.LuaOut<UnityEngine.ParticleSystem.Particle>>(L, 2))
			{
				UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)ToLua.CheckObject(L, 1, typeof(UnityEngine.ParticleSystem));
				UnityEngine.ParticleSystem.Particle[] arg0 = null;
				int o = obj.GetParticles(arg0);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 2 && TypeChecker.CheckTypes<UnityEngine.ParticleSystem>(L, 2))
			{
				UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)ToLua.CheckObject(L, 1, typeof(UnityEngine.ParticleSystem));
				Unity.Collections.NativeArray<UnityEngine.ParticleSystem.Particle> arg0;
				//int o = obj.GetParticles(arg0);
				//LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 3 && TypeChecker.CheckTypes<LuaInterface.LuaOut<UnityEngine.ParticleSystem.Particle>, int>(L, 2))
			{
				UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)ToLua.CheckObject(L, 1, typeof(UnityEngine.ParticleSystem));
				UnityEngine.ParticleSystem.Particle[] arg0 = null;
				int arg1 = (int)LuaDLL.lua_tonumber(L, 3);
				int o = obj.GetParticles(arg0, arg1);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 3 && TypeChecker.CheckTypes<int>(L, 2))
			{
				UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)ToLua.CheckObject(L, 1, typeof(UnityEngine.ParticleSystem));
				Unity.Collections.NativeArray<UnityEngine.ParticleSystem.Particle> arg0;
				int arg1 = (int)LuaDLL.lua_tonumber(L, 3);
				//int o = obj.GetParticles(arg0, arg1);
				//LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 4 && TypeChecker.CheckTypes<LuaInterface.LuaOut<UnityEngine.ParticleSystem.Particle>, int, int>(L, 2))
			{
				UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)ToLua.CheckObject(L, 1, typeof(UnityEngine.ParticleSystem));
				UnityEngine.ParticleSystem.Particle[] arg0 = null;
				int arg1 = (int)LuaDLL.lua_tonumber(L, 3);
				int arg2 = (int)LuaDLL.lua_tonumber(L, 4);
				int o = obj.GetParticles(arg0, arg1, arg2);
				LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else if (count == 4 && TypeChecker.CheckTypes<int, int>(L, 2))
			{
				UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)ToLua.CheckObject(L, 1, typeof(UnityEngine.ParticleSystem));
				Unity.Collections.NativeArray<UnityEngine.ParticleSystem.Particle> arg0;
				int arg1 = (int)LuaDLL.lua_tonumber(L, 3);
				int arg2 = (int)LuaDLL.lua_tonumber(L, 4);
				//int o = obj.GetParticles(arg0, arg1, arg2);
				//LuaDLL.lua_pushinteger(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.ParticleSystem.GetParticles");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetCustomParticleData(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)ToLua.CheckObject(L, 1, typeof(UnityEngine.ParticleSystem));
			System.Collections.Generic.List<UnityEngine.Vector4> arg0 = (System.Collections.Generic.List<UnityEngine.Vector4>)ToLua.CheckObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Vector4>));
			UnityEngine.ParticleSystemCustomData arg1 = (UnityEngine.ParticleSystemCustomData)ToLua.CheckObject(L, 3, typeof(UnityEngine.ParticleSystemCustomData));
			obj.SetCustomParticleData(arg0, arg1);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetCustomParticleData(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)ToLua.CheckObject(L, 1, typeof(UnityEngine.ParticleSystem));
			System.Collections.Generic.List<UnityEngine.Vector4> arg0 = (System.Collections.Generic.List<UnityEngine.Vector4>)ToLua.CheckObject(L, 2, typeof(System.Collections.Generic.List<UnityEngine.Vector4>));
			UnityEngine.ParticleSystemCustomData arg1 = (UnityEngine.ParticleSystemCustomData)ToLua.CheckObject(L, 3, typeof(UnityEngine.ParticleSystemCustomData));
			int o = obj.GetCustomParticleData(arg0, arg1);
			LuaDLL.lua_pushinteger(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetPlaybackState(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)ToLua.CheckObject(L, 1, typeof(UnityEngine.ParticleSystem));
			UnityEngine.ParticleSystem.PlaybackState o = obj.GetPlaybackState();
			ToLua.PushValue(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetPlaybackState(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)ToLua.CheckObject(L, 1, typeof(UnityEngine.ParticleSystem));
			UnityEngine.ParticleSystem.PlaybackState arg0 = StackTraits<UnityEngine.ParticleSystem.PlaybackState>.Check(L, 2);
			obj.SetPlaybackState(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetTrails(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)ToLua.CheckObject(L, 1, typeof(UnityEngine.ParticleSystem));
			UnityEngine.ParticleSystem.Trails o = obj.GetTrails();
			ToLua.PushValue(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int SetTrails(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)ToLua.CheckObject(L, 1, typeof(UnityEngine.ParticleSystem));
			UnityEngine.ParticleSystem.Trails arg0 = StackTraits<UnityEngine.ParticleSystem.Trails>.Check(L, 2);
			obj.SetTrails(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Simulate(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)ToLua.CheckObject(L, 1, typeof(UnityEngine.ParticleSystem));
				float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
				obj.Simulate(arg0);
				return 0;
			}
			else if (count == 3)
			{
				UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)ToLua.CheckObject(L, 1, typeof(UnityEngine.ParticleSystem));
				float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
				bool arg1 = LuaDLL.luaL_checkboolean(L, 3);
				obj.Simulate(arg0, arg1);
				return 0;
			}
			else if (count == 4)
			{
				UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)ToLua.CheckObject(L, 1, typeof(UnityEngine.ParticleSystem));
				float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
				bool arg1 = LuaDLL.luaL_checkboolean(L, 3);
				bool arg2 = LuaDLL.luaL_checkboolean(L, 4);
				obj.Simulate(arg0, arg1, arg2);
				return 0;
			}
			else if (count == 5)
			{
				UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)ToLua.CheckObject(L, 1, typeof(UnityEngine.ParticleSystem));
				float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
				bool arg1 = LuaDLL.luaL_checkboolean(L, 3);
				bool arg2 = LuaDLL.luaL_checkboolean(L, 4);
				bool arg3 = LuaDLL.luaL_checkboolean(L, 5);
				obj.Simulate(arg0, arg1, arg2, arg3);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.ParticleSystem.Simulate");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Play(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)ToLua.CheckObject(L, 1, typeof(UnityEngine.ParticleSystem));
				obj.Play();
				return 0;
			}
			else if (count == 2)
			{
				UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)ToLua.CheckObject(L, 1, typeof(UnityEngine.ParticleSystem));
				bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
				obj.Play(arg0);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.ParticleSystem.Play");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Pause(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)ToLua.CheckObject(L, 1, typeof(UnityEngine.ParticleSystem));
				obj.Pause();
				return 0;
			}
			else if (count == 2)
			{
				UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)ToLua.CheckObject(L, 1, typeof(UnityEngine.ParticleSystem));
				bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
				obj.Pause(arg0);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.ParticleSystem.Pause");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Stop(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)ToLua.CheckObject(L, 1, typeof(UnityEngine.ParticleSystem));
				obj.Stop();
				return 0;
			}
			else if (count == 2)
			{
				UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)ToLua.CheckObject(L, 1, typeof(UnityEngine.ParticleSystem));
				bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
				obj.Stop(arg0);
				return 0;
			}
			else if (count == 3)
			{
				UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)ToLua.CheckObject(L, 1, typeof(UnityEngine.ParticleSystem));
				bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
				UnityEngine.ParticleSystemStopBehavior arg1 = (UnityEngine.ParticleSystemStopBehavior)ToLua.CheckObject(L, 3, typeof(UnityEngine.ParticleSystemStopBehavior));
				obj.Stop(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.ParticleSystem.Stop");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Clear(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)ToLua.CheckObject(L, 1, typeof(UnityEngine.ParticleSystem));
				obj.Clear();
				return 0;
			}
			else if (count == 2)
			{
				UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)ToLua.CheckObject(L, 1, typeof(UnityEngine.ParticleSystem));
				bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
				obj.Clear(arg0);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.ParticleSystem.Clear");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IsAlive(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)ToLua.CheckObject(L, 1, typeof(UnityEngine.ParticleSystem));
				bool o = obj.IsAlive();
				LuaDLL.lua_pushboolean(L, o);
				return 1;
			}
			else if (count == 2)
			{
				UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)ToLua.CheckObject(L, 1, typeof(UnityEngine.ParticleSystem));
				bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
				bool o = obj.IsAlive(arg0);
				LuaDLL.lua_pushboolean(L, o);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.ParticleSystem.IsAlive");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Emit(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)ToLua.CheckObject(L, 1, typeof(UnityEngine.ParticleSystem));
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
				obj.Emit(arg0);
				return 0;
			}
			else if (count == 3)
			{
				UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)ToLua.CheckObject(L, 1, typeof(UnityEngine.ParticleSystem));
				UnityEngine.ParticleSystem.EmitParams arg0 = StackTraits<UnityEngine.ParticleSystem.EmitParams>.Check(L, 2);
				int arg1 = (int)LuaDLL.luaL_checknumber(L, 3);
				obj.Emit(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.ParticleSystem.Emit");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TriggerSubEmitter(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2)
			{
				UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)ToLua.CheckObject(L, 1, typeof(UnityEngine.ParticleSystem));
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
				obj.TriggerSubEmitter(arg0);
				return 0;
			}
			else if (count == 3 && TypeChecker.CheckTypes<UnityEngine.ParticleSystem.Particle>(L, 3))
			{
				UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)ToLua.CheckObject(L, 1, typeof(UnityEngine.ParticleSystem));
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
				UnityEngine.ParticleSystem.Particle arg1 = StackTraits<UnityEngine.ParticleSystem.Particle>.To(L, 3);
				obj.TriggerSubEmitter(arg0, ref arg1);
				ToLua.PushValue(L, arg1);
				return 1;
			}
			else if (count == 3 && TypeChecker.CheckTypes<System.Collections.Generic.List<UnityEngine.ParticleSystem.Particle>>(L, 3))
			{
				UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)ToLua.CheckObject(L, 1, typeof(UnityEngine.ParticleSystem));
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 2);
				System.Collections.Generic.List<UnityEngine.ParticleSystem.Particle> arg1 = (System.Collections.Generic.List<UnityEngine.ParticleSystem.Particle>)ToLua.ToObject(L, 3);
				obj.TriggerSubEmitter(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: UnityEngine.ParticleSystem.TriggerSubEmitter");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ResetPreMappedBufferMemory(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			UnityEngine.ParticleSystem.ResetPreMappedBufferMemory();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isPlaying(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)o;
			bool ret = obj.isPlaying;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index isPlaying on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isEmitting(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)o;
			bool ret = obj.isEmitting;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index isEmitting on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isStopped(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)o;
			bool ret = obj.isStopped;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index isStopped on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isPaused(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)o;
			bool ret = obj.isPaused;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index isPaused on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_particleCount(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)o;
			int ret = obj.particleCount;
			LuaDLL.lua_pushinteger(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index particleCount on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_time(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)o;
			float ret = obj.time;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index time on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_randomSeed(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)o;
			uint ret = obj.randomSeed;
			LuaDLL.lua_pushnumber(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index randomSeed on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_useAutoRandomSeed(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)o;
			bool ret = obj.useAutoRandomSeed;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index useAutoRandomSeed on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_proceduralSimulationSupported(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)o;
			bool ret = obj.proceduralSimulationSupported;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index proceduralSimulationSupported on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_main(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)o;
			UnityEngine.ParticleSystem.MainModule ret = obj.main;
			ToLua.PushValue(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index main on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_emission(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)o;
			UnityEngine.ParticleSystem.EmissionModule ret = obj.emission;
			ToLua.PushValue(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index emission on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_shape(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)o;
			UnityEngine.ParticleSystem.ShapeModule ret = obj.shape;
			ToLua.PushValue(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index shape on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_velocityOverLifetime(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)o;
			UnityEngine.ParticleSystem.VelocityOverLifetimeModule ret = obj.velocityOverLifetime;
			ToLua.PushValue(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index velocityOverLifetime on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_limitVelocityOverLifetime(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)o;
			UnityEngine.ParticleSystem.LimitVelocityOverLifetimeModule ret = obj.limitVelocityOverLifetime;
			ToLua.PushValue(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index limitVelocityOverLifetime on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_inheritVelocity(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)o;
			UnityEngine.ParticleSystem.InheritVelocityModule ret = obj.inheritVelocity;
			ToLua.PushValue(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index inheritVelocity on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_lifetimeByEmitterSpeed(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)o;
			UnityEngine.ParticleSystem.LifetimeByEmitterSpeedModule ret = obj.lifetimeByEmitterSpeed;
			ToLua.PushValue(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index lifetimeByEmitterSpeed on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_forceOverLifetime(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)o;
			UnityEngine.ParticleSystem.ForceOverLifetimeModule ret = obj.forceOverLifetime;
			ToLua.PushValue(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index forceOverLifetime on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_colorOverLifetime(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)o;
			UnityEngine.ParticleSystem.ColorOverLifetimeModule ret = obj.colorOverLifetime;
			ToLua.PushValue(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index colorOverLifetime on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_colorBySpeed(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)o;
			UnityEngine.ParticleSystem.ColorBySpeedModule ret = obj.colorBySpeed;
			ToLua.PushValue(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index colorBySpeed on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_sizeOverLifetime(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)o;
			UnityEngine.ParticleSystem.SizeOverLifetimeModule ret = obj.sizeOverLifetime;
			ToLua.PushValue(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index sizeOverLifetime on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_sizeBySpeed(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)o;
			UnityEngine.ParticleSystem.SizeBySpeedModule ret = obj.sizeBySpeed;
			ToLua.PushValue(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index sizeBySpeed on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_rotationOverLifetime(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)o;
			UnityEngine.ParticleSystem.RotationOverLifetimeModule ret = obj.rotationOverLifetime;
			ToLua.PushValue(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index rotationOverLifetime on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_rotationBySpeed(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)o;
			UnityEngine.ParticleSystem.RotationBySpeedModule ret = obj.rotationBySpeed;
			ToLua.PushValue(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index rotationBySpeed on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_externalForces(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)o;
			UnityEngine.ParticleSystem.ExternalForcesModule ret = obj.externalForces;
			ToLua.PushValue(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index externalForces on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_noise(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)o;
			UnityEngine.ParticleSystem.NoiseModule ret = obj.noise;
			ToLua.PushValue(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index noise on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_collision(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)o;
			UnityEngine.ParticleSystem.CollisionModule ret = obj.collision;
			ToLua.PushValue(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index collision on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_trigger(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)o;
			UnityEngine.ParticleSystem.TriggerModule ret = obj.trigger;
			ToLua.PushValue(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index trigger on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_subEmitters(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)o;
			UnityEngine.ParticleSystem.SubEmittersModule ret = obj.subEmitters;
			ToLua.PushValue(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index subEmitters on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_textureSheetAnimation(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)o;
			UnityEngine.ParticleSystem.TextureSheetAnimationModule ret = obj.textureSheetAnimation;
			ToLua.PushValue(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index textureSheetAnimation on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_lights(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)o;
			UnityEngine.ParticleSystem.LightsModule ret = obj.lights;
			ToLua.PushValue(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index lights on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_trails(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)o;
			UnityEngine.ParticleSystem.TrailModule ret = obj.trails;
			ToLua.PushValue(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index trails on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_customData(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)o;
			UnityEngine.ParticleSystem.CustomDataModule ret = obj.customData;
			ToLua.PushValue(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index customData on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_time(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)o;
			float arg0 = (float)LuaDLL.luaL_checknumber(L, 2);
			obj.time = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index time on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_randomSeed(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)o;
			uint arg0 = (uint)LuaDLL.luaL_checknumber(L, 2);
			obj.randomSeed = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index randomSeed on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_useAutoRandomSeed(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UnityEngine.ParticleSystem obj = (UnityEngine.ParticleSystem)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.useAutoRandomSeed = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index useAutoRandomSeed on a nil value");
		}
	}
}

