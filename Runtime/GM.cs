/*
 * Author: 吴雁涛(Yantao Wu)
 * Date: 2025-7-26
 * Description: 其他单例的统一入口
 */

namespace KuonTools.Base
{
    /// <summary>
    /// 统一入口
    /// </summary>
    public sealed class GM
    {
        private static GM instance = null;

        private GM() { }

        /// <summary>
        /// 实例
        /// </summary>
        public static GM I
        {
            get
            {
                if (instance == null)
                {
                    instance = new GM();
                }

                return instance;
            }
        }
    }
}