﻿#region   文件版本注释
/************************************************************************
*CLR版本  ：4.0.30319.42000
*项目名称 ：TestLib
*项目描述 ：
*命名空间 ：TestLib
*文件名称 ：ActionInvoke.cs
* 功能描述 ：ActionInvoke
* 创建时间 ：2020
*版本号   :   2020|V1.0.0.0 
---------------------------------------------------------------------
* Copyright @ jinyu 2020. All rights reserved.
---------------------------------------------------------------------

***********************************************************************/
#endregion



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLib
{
   public class ActionInvoke<TSource,TDest>
    {
        public Action<TSource,TDest> Action { get; set; }
    }
}
