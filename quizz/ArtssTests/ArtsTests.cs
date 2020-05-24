﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using quizz;
using Artss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quizz.Tests
{
    [TestClass()]
    public class ArtsTests
    {
        [TestMethod()]
        public void getQuestionTest()
        {
            Arts arts = new Arts();
            arts.Questions();
            Assert.AreEqual("What nationality was painter Frida Kahlo ? ", arts.getQuestion(1));
        }

        [TestMethod()]
        public void getQuestionTest1()
        {
            Arts arts = new Arts();
            arts.Questions();
            Assert.AreEqual("A Russian woman was arrested in Paris in August 2009 for throwing a cup of tea at which work of art?", arts.getQuestion(5));
        }

        [TestMethod()]
        public void domainNameTest()
        {
            Arts arts = new Arts();
            Assert.AreEqual("Arts", arts.domainName);
        }

        [TestMethod()]
        public void getAnswerTest()
        {
            Arts arts = new Arts();
            arts.Questions();
            Assert.AreEqual("New York", arts.getAnswer(2, 3));
        }

        [TestMethod()]
        public void getQuestionNumberTest()
        {
            Arts arts = new Arts();
            Assert.AreEqual(20, arts.getQuestionNumber);
        }

    }
}