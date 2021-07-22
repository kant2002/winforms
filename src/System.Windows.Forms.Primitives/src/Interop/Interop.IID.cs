// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

internal partial class Interop
{
    internal static class IID
    {
        // 0000000C-0000-0000-C000-000000000046
        internal static Guid IStream = new Guid(0x0000000C, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        // 00000109-0000-0000-C000-000000000046
        internal static Guid IPersistStream = new Guid(0x00000109, 0x0000, 0x0000, 0xC0, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x46);

        // 7BF80980-BF32-101A-8BBB-00AA00300CAB
        internal static Guid IPicture = new Guid(0x7BF80980, 0xBF32, 0x101A, 0x8B, 0xBB, 0x00, 0xAA, 0x00, 0x30, 0x0C, 0xAB);

        // 43826D1E-E718-42EE-BC55-A1E261C37BFE
        internal static Guid IShellItem = new Guid(0x43826D1E, 0xE718, 0x42EE, 0xBC, 0x55, 0xA1, 0xE2, 0x61, 0xC3, 0x7B, 0xFE);

        // 973510DB-7D7F-452B-8975-74A85828D354
        internal static Guid IFileDialogEvents = new Guid(0x973510DB, 0x7D7F, 0x452B, 0x89, 0x75, 0x74, 0xA8, 0x58, 0x28, 0xD3, 0x54);
    }
}
