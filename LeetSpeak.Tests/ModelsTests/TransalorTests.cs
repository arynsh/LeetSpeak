using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LeetSpeak;

namespace LeetSpeak.Tests {

  [TestClass]
  public class LeetSpeakTest
  {
    [TestMethod]
    public void Translator_ETranslatesTo3_3()
    {
       LeetSpeakTranslator testObj = new LeetSpeakTranslator("e");
       Assert.AreEqual("3", testObj.Translator()); 
    }

    [TestMethod]
     public void Translator_OTranslatesTo0_0()
    {
       LeetSpeakTranslator testObj = new LeetSpeakTranslator("o");
       Assert.AreEqual("0", testObj.Translator()); 
    }

      [TestMethod]
     public void Translator_ITranslatesTo1_1()
    {
       LeetSpeakTranslator testObj = new LeetSpeakTranslator("I");
       Assert.AreEqual("1", testObj.Translator()); 
    }

      [TestMethod]
     public void Translator_TTranslatesTo7_7()
    {
       LeetSpeakTranslator testObj = new LeetSpeakTranslator("t");
       Assert.AreEqual("7", testObj.Translator()); 
    }

      [TestMethod]
     public void Translator_STranslatesToZ_s()
    {
       LeetSpeakTranslator testObj = new LeetSpeakTranslator("s");
       Assert.AreEqual("s", testObj.Translator()); 
    }

       [TestMethod]
     public void Translator_STranslatesToZ_jz()
    {
       LeetSpeakTranslator testObj = new LeetSpeakTranslator("js");
       Assert.AreEqual("jz", testObj.Translator()); 
    }
  }

}


