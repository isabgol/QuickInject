﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
namespace QuickInject
{
    using System.Reflection;

    public abstract class InjectionMember
    {
        public MethodInfo Factory { get; protected set; }
    }
}