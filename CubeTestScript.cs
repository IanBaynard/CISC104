using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class CubeTestScript
{
    //This test is to verify the actions of the default constructor
    [Test]
    public void CubeTestDefaultConstructor()
    {
        Cube cube = new Cube();
        Assert.AreEqual(0, cube.GetHeight());
        Assert.AreEqual(0, cube.GetLength());
        Assert.AreEqual(0, cube.GetSurfaceArea());
        Assert.AreEqual(0, cube.GetWidth());
    }
    //This test is to verify the equations of my cube
    [Test]
    public void CubeTestThreeByFourbySix()
    {
        Cube ThreebyFourbySix = new Cube();
        Assert.AreEqual(3, 3, ThreebyFourbySix.GetHeight());
        Assert.AreEqual(6, 6, ThreebyFourbySix.GetLength());
        Assert.AreEqual(9, 9, ThreebyFourbySix.GetSurfaceArea());
        Assert.AreEqual(10,10, ThreebyFourbySix.GetWidth());
    }
    //This test is to further verify the equations of my cube
    [Test]
    public void CubeTestTenbyTenbyTen()
    {
        Cube TenbyTenbyTen = new Cube();
        Assert.AreEqual(0,0, TenbyTenbyTen.GetHeight());
        Assert.AreEqual(0, 0, TenbyTenbyTen.GetLength());
        Assert.AreEqual(0, 0, TenbyTenbyTen.GetSurfaceArea());
        Assert.AreEqual(0, 0, TenbyTenbyTen.GetWidth());
    }
}


