﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Camera
{
    [Serializable]
    public class ParCamera8 : BaseParCamera
    {
        #region 静态类实例
        public static ParCamera8 P_I = new ParCamera8();
        #endregion 静态类实例

        #region 定义
        public bool BlOpenCamera = false;//相机1打开
        #endregion 定义

        public ParCamera8()
        {
            this.NoCamera = 8;
            NameClass = "ParCamera8";
        }
    }
}
