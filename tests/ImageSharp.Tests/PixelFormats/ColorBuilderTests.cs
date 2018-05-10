﻿// Copyright (c) Six Labors and contributors.
// Licensed under the Apache License, Version 2.0.

using System;
using SixLabors.ImageSharp.PixelFormats;
using Xunit;

namespace SixLabors.ImageSharp.Tests.Colors
{
    public class ColorBuilderTests
    {
        [Fact]
        public void ParseHexLeadingPoundIsOptional()
        {
            Assert.Equal(new Rgb24(0, 128, 128), ColorBuilder<Rgb24>.FromHex("#008080"));
            Assert.Equal(new Rgb24(0, 128, 128), ColorBuilder<Rgb24>.FromHex("008080"));
        }

        [Fact]
        public void ParseHexThrowsOnEmpty()
        {
            Assert.Throws<ArgumentException>(() => ColorBuilder<Rgb24>.FromHex(""));
        }

        [Fact]
        public void ParseHexThrowsOnNull()
        {
            Assert.Throws<ArgumentNullException>(() => ColorBuilder<Rgb24>.FromHex(null));
        }
    }
}
