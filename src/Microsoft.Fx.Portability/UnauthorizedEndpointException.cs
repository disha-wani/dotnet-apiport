﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Microsoft.Fx.Portability.Resources;
using System.Globalization;

namespace Microsoft.Fx.Portability
{
    public class UnauthorizedEndpointException : PortabilityAnalyzerException
    {
        public UnauthorizedEndpointException()
            : base(string.Format(CultureInfo.CurrentCulture, LocalizedStrings.UnauthorizedAccess))
        {
        }
    }
}
