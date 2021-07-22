// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

internal partial class Interop
{
    internal unsafe partial class WinFormsComWrappers
    {
        internal struct COMDLG_FILTERSPEC_native
        {
            public IntPtr pszName;
            public IntPtr pszSpec;
        }
    }
}
