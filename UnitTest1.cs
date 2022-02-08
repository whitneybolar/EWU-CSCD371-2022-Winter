using GenericsHomework;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GenericsHomeworkTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Node_Create()
        {
            Node cur = new Node("First Node");
            Assert.IsNotNull(cur);
            Assert.AreEqual(0, cur.GetSize());
        }


        [TestMethod]
        public void Node_Append()
        {
            Node cur = new Node("First Node");
            cur.Append("obj");
            Assert.AreEqual(cur.Size, cur.GetSize());
            Assert.AreEqual("First Node", cur.Next.ToString());
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Node_AppendExistsNull()
        {
            Node cur = new Node("Hi");
            cur.Append("Hi");
        }

        [TestMethod]
        public void Node_Clear()
        {
            Node cur = new Node("Node Clear");
            cur.Append("obj2");
            cur.Append("obj4");
            cur.Append("obj5");
            cur.Append("obj6");
            cur.Append("obj7");
            cur.Append("obj8");

            cur.Clear();
            Assert.AreEqual(1, cur.GetSize());
            Assert.AreEqual(false, cur.Exists("obj2"));
            Assert.AreEqual(false, cur.Exists("obj3"));
            Assert.AreEqual(false, cur.Exists("obj4"));
            Assert.AreEqual(false, cur.Exists("obj5"));
            Assert.AreEqual(false, cur.Exists("obj6"));
            Assert.AreEqual(false, cur.Exists("obj7"));
            Assert.AreEqual(false, cur.Exists("obj8"));
        }

        [TestMethod]
        public void Node_ToString()
        {
            Node cur = new Node("Node Clear");
            Assert.AreEqual("Node Clear", cur.ToString());
        }

        [TestMethod]
        public void Node_GarbageCollection()
        {
            Node cur = new Node("Node Garbage");
            cur.Append("obj1");
            cur.Append("obj2");
            cur.Append("obj4");
            cur.Append("obj5");
            cur.Append("obj6");
            cur.Append("obj7");
            cur.Append("obj8");

            cur.GarbageCollection();
            Assert.AreEqual("Worry about garbage collection", cur.GarbageCollection().ToString());

            cur.Clear();
            cur.Append("obj2");
            Assert.AreEqual("Your list is fine", cur.GarbageCollection().ToString());
        }

    }
}