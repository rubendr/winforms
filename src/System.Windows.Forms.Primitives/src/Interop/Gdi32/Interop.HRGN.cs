﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

internal static partial class Interop
{
    internal static partial class Gdi32
    {
        public readonly struct HRGN
        {
            public IntPtr Handle { get; }

            public HRGN(IntPtr handle) => Handle = handle;

            public static implicit operator HGDIOBJ(HRGN hrgn) => new HGDIOBJ(hrgn.Handle);
        }
    }
}
