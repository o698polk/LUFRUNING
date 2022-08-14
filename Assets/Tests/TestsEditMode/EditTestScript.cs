using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using MathSolution;
using System;
using SystemSave;
public class EditTestScript
{

    [SetUp]
    public void SetUp(){

        Debug.Log("SetUp");
    }
    [TearDown]
    public void TearDown(){

        Debug.Log("TearDown");
    }
    // A Test behaves as an ordinary method
   [Test]
    public void Sum_TheParameterArePositives_ReturnsTheCorrectResult()
    {
        //Arrange
       var calcular= new Calculos();
      

       //action
       var result = calcular.sum(1,2);
       //Assert
      Assert.AreEqual(3,result);
      
    }
   [TestCase(-10,20)]
   [TestCase(10,-20)]
    public void Sum_AnyParameterIsNegative_ReturnExectionResul(int value1, int value2)
    {
        //Arrange
       var calcular= new Calculos();
      

      
     
       //Assert
      Assert
      .Throws<Exception>
        (()=>{
             //action
              var result = calcular.sum(value1,value2);
        });
      }
      
   [Test]
    public void Verify_SystemSave_ReturnOk()
    {
        //Arrange
    var savet= new SaveAll();
    int a;
     //action
     savet.SetLife(2);
      a=savet.GetLife();
     
       //Assert
     Assert.AreEqual(2,a);
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator EditTestScriptWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}
