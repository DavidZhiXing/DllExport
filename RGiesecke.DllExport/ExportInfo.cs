﻿// [Decompiled] Assembly: RGiesecke.DllExport, Version=1.2.7.38850, Culture=neutral, PublicKeyToken=8f52d83c1a22df51
// Author of original assembly (MIT-License): Robert Giesecke
// Use Readme & LICENSE files for details.

using System;
using System.Runtime.InteropServices;

namespace RGiesecke.DllExport
{
    [Serializable]
    public class ExportInfo: IExportInfo
    {
        public virtual string ExportName
        {
            get;
            set;
        }

        public CallingConvention CallingConvention
        {
            get;
            set;
        }

        public bool IsStatic
        {
            get;
            set;
        }

        public bool IsGeneric
        {
            get;
            set;
        }

        public void AssignFrom(IExportInfo info)
        {
            if(info == null)
            {
                return;
            }
            this.CallingConvention = info.CallingConvention != (CallingConvention)0 ? info.CallingConvention : CallingConvention.StdCall;
            this.ExportName = info.ExportName;
        }
    }
}
