/*
 * Author: 吴雁涛(Yantao Wu)
 * Date: 2025-7-26
 * Description: 简单的泛型单实例
 */

using UnityEngine;

namespace KuonTools.Base
{
    /// <summary>
    /// 泛型单实例
    /// </summary>
    /// <typeparam name="T">泛型</typeparam>
    public class Singleton<T> : MonoBehaviour where T : Singleton<T>
    {
        /// <summary>
        /// 实例
        /// </summary>
        private static T instance;

        /// <summary>
        /// 返回实例
        /// </summary>
        public static T Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// 设置实例
        /// </summary>
        protected virtual void Awake()
        {
            //保证场景中只有一个实例
            if (instance != null)
            {
                Destroy(gameObject);
            }
            else
            {
                instance = (T)this;
            }

            //场景切换时候不被删除。
            DontDestroyOnLoad(gameObject);
        }

        /// <summary>
        /// 销毁时，清除实例
        /// </summary>
        protected virtual void OnDestroy()
        {
            if (instance == this)
            {
                instance = null;
            }
        }
    }
}