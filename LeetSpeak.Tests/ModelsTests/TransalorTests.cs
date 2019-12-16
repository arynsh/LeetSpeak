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
       LeetSpeakTranslator testObj = new LeetSpeakTranslator("i");
       Assert.AreEqual("1", testObj.Translator()); 
    }

      [TestMethod]
     public void Translator_TTranslatesTo7_7()
    {
       LeetSpeakTranslator testObj = new LeetSpeakTranslator("t");
       Assert.AreEqual("7", testObj.Translator()); 
    }
      [TestMethod]
     public void Translator_STranslatesToZ_Z()
    {
       LeetSpeakTranslator testObj = new LeetSpeakTranslator("z");
       Assert.AreEqual("z", testObj.Translator()); 
    }
  }

}


