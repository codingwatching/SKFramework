/*============================================================
 * SKFramework
 * Copyright © 2019-2024 Zhang Shoukun. All rights reserved.
 * Feedback: mailto:136512892@qq.com
 *============================================================*/

using System;
using System.Collections.Generic;

namespace SK.Framework.Events
{
    public class Events : ModuleBase
    {
        private readonly Dictionary<int, List<Delegate>> m_Dic = new Dictionary<int, List<Delegate>>();

        public void Publish(int eventId)
        {
            if (m_Dic.TryGetValue(eventId, out List<Delegate> list))
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] is Action action)
                    {
                        action.Invoke();
                    }
                }
            }
        }
        public void Publish<T>(int eventId, T arg)
        {
            if (m_Dic.TryGetValue(eventId, out List<Delegate> list))
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] is Action<T> action)
                    {
                        action.Invoke(arg);
                    }
                }
            }
        }
        public void Publish<T1, T2>(int eventId, T1 arg1, T2 arg2)
        {
            if (m_Dic.TryGetValue(eventId, out List<Delegate> list))
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] is Action<T1, T2> action)
                    {
                        action.Invoke(arg1, arg2);
                    }
                }
            }
        }
        public void Publish<T1, T2, T3>(int eventId, T1 arg1, T2 arg2, T3 arg3)
        {
            if (m_Dic.TryGetValue(eventId, out List<Delegate> list))
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] is Action<T1, T2, T3> action)
                    {
                        action.Invoke(arg1, arg2, arg3);
                    }
                }
            }
        }
        public void Publish<T1, T2, T3, T4>(int eventId, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
        {
            if (m_Dic.TryGetValue(eventId, out List<Delegate> list))
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] is Action<T1, T2, T3, T4> action)
                    {
                        action.Invoke(arg1, arg2, arg3, arg4);
                    }
                }
            }
        }
        public void Publish<T1, T2, T3, T4, T5>(int eventId, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5)
        {
            if (m_Dic.TryGetValue(eventId, out List<Delegate> list))
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] is Action<T1, T2, T3, T4, T5> action)
                    {
                        action.Invoke(arg1, arg2, arg3, arg4, arg5);
                    }
                }
            }
        }
        public void Publish<T1, T2, T3, T4, T5, T6>(int eventId, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6)
        {
            if (m_Dic.TryGetValue(eventId, out List<Delegate> list))
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] is Action<T1, T2, T3, T4, T5, T6> action)
                    {
                        action.Invoke(arg1, arg2, arg3, arg4, arg5, arg6);
                    }
                }
            }
        }
        public void Publish<T1, T2, T3, T4, T5, T6, T7>(int eventId, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7)
        {
            if (m_Dic.TryGetValue(eventId, out List<Delegate> list))
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] is Action<T1, T2, T3, T4, T5, T6, T7> action)
                    {
                        action.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
                    }
                }
            }
        }
        public void Publish<T1, T2, T3, T4, T5, T6, T7, T8>(int eventId, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8)
        {
            if (m_Dic.TryGetValue(eventId, out List<Delegate> list))
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] is Action<T1, T2, T3, T4, T5, T6, T7, T8> action)
                    {
                        action.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
                    }
                }
            }
        }
        public void Publish<T1, T2, T3, T4, T5, T6, T7, T8, T9>(int eventId, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9)
        {
            if (m_Dic.TryGetValue(eventId, out List<Delegate> list))
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] is Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action)
                    {
                        action.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
                    }
                }
            }
        }
        public void Publish<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(int eventId, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10)
        {
            if (m_Dic.TryGetValue(eventId, out List<Delegate> list))
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] is Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action)
                    {
                        action.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
                    }
                }
            }
        }
        public void Publish<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(int eventId, T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11)
        {
            if (m_Dic.TryGetValue(eventId, out List<Delegate> list))
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] is Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action)
                    {
                        action.Invoke(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
                    }
                }
            }
        }
        
        private void SubscribeInternal(int eventId, Delegate callback)
        {
            if (!m_Dic.ContainsKey(eventId))
                m_Dic.Add(eventId, new List<Delegate>());
            m_Dic[eventId].Add(callback);
        }
        private bool UnsubscribeInternal(int eventId, Delegate callback)
        {
            if (m_Dic.TryGetValue(eventId, out List<Delegate> list))
            {
                list.Remove(callback);
                if (list.Count == 0)
                    m_Dic.Remove(eventId);
                return true;
            }
            return false;
        }
        
        public void Subscribe(int eventId, Action callback)
        {
            SubscribeInternal(eventId, callback);
        }
        public void Subscribe<T>(int eventId, Action<T> callback)
        {
            SubscribeInternal(eventId, callback);
        }
        public void Subscribe<T1, T2>(int eventId, Action<T1, T2> callback)
        {
            SubscribeInternal(eventId, callback);
        }
        public void Subscribe<T1, T2, T3>(int eventId, Action<T1, T2, T3> callback)
        {
            SubscribeInternal(eventId, callback);
        }
        public void Subscribe<T1, T2, T3, T4>(int eventId, Action<T1, T2, T3, T4> callback)
        {
            SubscribeInternal(eventId, callback);
        }
        public void Subscribe<T1, T2, T3, T4, T5>(int eventId, Action<T1, T2, T3, T4, T5> callback)
        {
            SubscribeInternal(eventId, callback);
        }
        public void Subscribe<T1, T2, T3, T4, T5, T6>(int eventId, Action<T1, T2, T3, T4, T5, T6> callback)
        {
            SubscribeInternal(eventId, callback);
        }
        public void Subscribe<T1, T2, T3, T4, T5, T6, T7>(int eventId, Action<T1, T2, T3, T4, T5, T6, T7> callback)
        {
            SubscribeInternal(eventId, callback);
        }
        public void Subscribe<T1, T2, T3, T4, T5, T6, T7, T8>(int eventId, Action<T1, T2, T3, T4, T5, T6, T7, T8> callback)
        {
            SubscribeInternal(eventId, callback);
        }
        public void Subscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9>(int eventId, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> callback)
        {
            SubscribeInternal(eventId, callback);
        }
        public void Subscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(int eventId, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> callback)
        {
            SubscribeInternal(eventId, callback);
        }

        public bool Unsubscribe(int eventId, Action callback)
        {
            return UnsubscribeInternal(eventId, callback);
        }
        public bool Unsubscribe<T>(int eventId, Action<T> callback)
        {
            return UnsubscribeInternal(eventId, callback);
        }
        public bool Unsubscribe<T1, T2>(int eventId, Action<T1, T2> callback)
        {
            return UnsubscribeInternal(eventId, callback);
        }
        public bool Unsubscribe<T1, T2, T3>(int eventId, Action<T1, T2, T3> callback)
        {
            return UnsubscribeInternal(eventId, callback);
        }
        public bool Unsubscribe<T1, T2, T3, T4>(int eventId, Action<T1, T2, T3, T4> callback)
        {
            return UnsubscribeInternal(eventId, callback);
        }
        public bool Unsubscribe<T1, T2, T3, T4, T5>(int eventId, Action<T1, T2, T3, T4, T5> callback)
        {
            return UnsubscribeInternal(eventId, callback);
        }
        public bool Unsubscribe<T1, T2, T3, T4, T5, T6>(int eventId, Action<T1, T2, T3, T4, T5, T6> callback)
        {
            return UnsubscribeInternal(eventId, callback);
        }
        public bool Unsubscribe<T1, T2, T3, T4, T5, T6, T7>(int eventId, Action<T1, T2, T3, T4, T5, T6, T7> callback)
        {
            return UnsubscribeInternal(eventId, callback);
        }
        public bool Unsubscribe<T1, T2, T3, T4, T5, T6, T7, T8>(int eventId, Action<T1, T2, T3, T4, T5, T6, T7, T8> callback)
        {
            return UnsubscribeInternal(eventId, callback);
        }
        public bool Unsubscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9>(int eventId, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> callback)
        {
            return UnsubscribeInternal(eventId, callback);
        }
        public bool Unsubscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(int eventId, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> callback)
        {
            return UnsubscribeInternal(eventId, callback);
        }
        public bool Unsubscribe<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(int eventId, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> callback)
        {
            return UnsubscribeInternal(eventId, callback);
        }


        private readonly Dictionary<int, List<Action<EventArgs>>> m_Dic2 = new Dictionary<int, List<Action<EventArgs>>>();
        private readonly Queue<EventArgs> m_Queue = new Queue<EventArgs>();

        private void Update()
        {
            while (m_Queue.Count > 0)
            {
                EventArgs e = m_Queue.Dequeue();
                if (m_Dic2.TryGetValue(e.ID, out List<Action<EventArgs>> list))
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        list[i].Invoke(e);
                    }
                    e.OnInvoke();
                }
            }
        }

        public void Publish<T>(T t) where T : EventArgs
        {
            if (t == null) 
                return;
            m_Queue.Enqueue(t);
        }

        public void Subscribe(int eventId, Action<EventArgs> callback)
        {
            if (!m_Dic2.TryGetValue(eventId, out List<Action<EventArgs>> list))
            {
                m_Dic2.Add(eventId, new List<Action<EventArgs>>());
                m_Dic2[eventId].Add(callback);
            }
            else
            {
                if (!list.Contains(callback)) 
                    list.Add(callback);
            }
        }

        public bool Unsubscribe(int eventId, Action<EventArgs> callback) 
        {
            if (m_Dic2.TryGetValue(eventId, out List<Action<EventArgs>> list))
            {
                list.Remove(callback);
                if (list.Count == 0)
                    m_Dic2.Remove(eventId);
                return true;
            }
            return false;
        }
    }
}