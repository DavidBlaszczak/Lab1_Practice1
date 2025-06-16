using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;
using Geometry;
using System.Drawing;

namespace Geometry.Tests;

public class PointTests
{
    [Fact]
    public void DefaultCtorTest()
    {
        var p = new Point();
        p.X.Should().Be(0);
        p.Y.Should().Be(0);
    }

    [Fact]
    public void SingleArgCtorTest()
    {
        var p = new Point(2);
        p.X.Should().Be(2);
        p.Y.Should().Be(2);
    }

    [Fact]
    public void TwoArgCtorTest()
    {
        var p = new Point(1, 3);
        p.X.Should().Be(1);
        p.Y.Should().Be(3);
    }

    [Fact]
    public void MoveTest()
    {
        var p = new Point(1, 1);
        p.Move(3, 4);
        p.X.Should().Be(4);
        p.Y.Should().Be(5);
    }

    [Fact]
    public void DistanceTest()
    {
        var p = new Point(3, 4);
        p.Distance().Should().BeApproximately(5, 0.01);
    }
}