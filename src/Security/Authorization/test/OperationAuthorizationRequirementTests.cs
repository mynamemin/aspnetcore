// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Xunit;

namespace Microsoft.AspNetCore.Authorization.Test
{
    public class OperationAuthorizationRequirementTests
    {
        private OperationAuthorizationRequirement CreateRequirement(string name)
        {
            return new OperationAuthorizationRequirement()
            {
                Name = name
            };
        }
        
        [Fact]
        public void ToString_ShouldReturnFormatValue()
        {
            // Arrange
            var requirement = CreateRequirement("Custom");

            // Act
            var formattedValue = requirement.ToString();

            // Assert
            Assert.Equal("OperationAuthorizationRequirement:Name=Custom", formattedValue);
        }
    }
}
