﻿using System;
using UnityEngine;
using System.Reflection;
using System.Collections.Generic;

namespace SK.Framework
{
    public static class ObjectPool
    {
        /// <summary>
        /// 从对象池中获取实例
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <returns>对象实例</returns>
        public static T Allocate<T>() where T : IPoolable, new()
        {
            return ObjectPool<T>.Instance.Allocate();
        }
        /// <summary>
        /// 回收对象
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="t">回收对象实例</param>
        /// <returns>回收成功返回true 否则返回false</returns>
        public static bool Recycle<T>(T t) where T : IPoolable, new()
        {
            return ObjectPool<T>.Instance.Recycle(t);
        }
        /// <summary>
        /// 释放对象池
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        public static void Release<T>() where T : IPoolable, new()
        {
            ObjectPool<T>.Instance.Release();
        }
        /// <summary>
        /// 设置对象池缓存数量上限
        /// </summary>
        /// <typeparam name="T">对象类型</typeparam>
        /// <param name="maxCacheCount">缓存数量上限</param>
        public static void SetMaxCacheCount<T>(int maxCacheCount) where T : IPoolable, new()
        {
            ObjectPool<T>.Instance.MaxCacheCount = maxCacheCount;
        }
    }

    public class ObjectPool<T> : IObjectPool<T> where T : IPoolable, new()
    {
        private static ObjectPool<T> instance;
        //对象池缓存数量上限 默认9
        private int maxCacheCount = 9;
        //对象池
        private readonly Stack<T> pool = new Stack<T>();

        public static ObjectPool<T> Instance
        {
            get
            {
                if (null == instance)
                {
                    var ctors = typeof(T).GetConstructors(BindingFlags.Instance | BindingFlags.Public);
                    var index = Array.FindIndex(ctors, m => m.GetParameters().Length == 0);
                    if (index == -1)
                    {
                        Debug.LogError($"{typeof(ObjectPool<T>)} 类型不具有公有无参构造函数.");
                    }
                    else
                    {
                        instance = Activator.CreateInstance<ObjectPool<T>>();
                    }
                }
                return instance;
            }
        }
        /// <summary>
        /// 当前池中缓存的数量
        /// </summary>
        public int CurrentCacheCount
        {
            get
            {
                return pool.Count;
            }
        }
        /// <summary>
        /// 缓存数量上限
        /// </summary>
        public int MaxCacheCount
        {
            get
            {
                return maxCacheCount;
            }
            set
            {
                if (maxCacheCount != value)
                {
                    maxCacheCount = value;
                    if (maxCacheCount > 0 && maxCacheCount < pool.Count)
                    {
                        int removeCount = pool.Count - maxCacheCount;
                        while (removeCount > 0)
                        {
                            pool.Pop();
                            removeCount--;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// 获取实例
        /// </summary>
        /// <returns>对象实例</returns>
        public T Allocate()
        {
            //若对象池中有缓存则从对象池中获取
            T retT = pool.Count > 0 ? pool.Pop() : new T();
            retT.IsRecycled = false;
            return retT;
        }
        /// <summary>
        /// 回收对象
        /// </summary>
        /// <param name="t">回收对象实例</param>
        /// <returns>回收成功返回true 否则返回false</returns>
        public bool Recycle(T t)
        {
            if (null == t || t.IsRecycled) return false;
            t.IsRecycled = true;
            t.OnRecycled();
            //若未达到缓存数量上限 放入池中
            if (pool.Count < maxCacheCount)
            {
                pool.Push(t);
            }
            return true;
        }
        /// <summary>
        /// 释放对象池
        /// </summary>
        public void Release()
        {
            pool.Clear();
            instance = null;
        }
    }
}