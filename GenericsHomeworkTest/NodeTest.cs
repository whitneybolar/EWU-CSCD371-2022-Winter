using GenericsHomework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GenericsHomeworkTest
{
    [TestClass]
    public class NodeTest
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
            Assert.AreEqual("First Node", cur.SetNext(cur).ToString());
        }

        [TestMethod]
        public void Node_Clear()
        {
            Node cur = new Node("First Node");
            cur.Append("obj2");
            cur.Append("obj3");
            cur.Append("obj2");
            cur.Append("obj3");
            cur.Append("obj2");
            cur.Append("obj3");

            cur.Clear();
            Assert.AreEqual(1, cur.GetSize());
            Assert.AreEqual(false, cur.Exists("obj2"));
            Assert.AreEqual(false, cur.Exists("obj3"));
        }

        [TestMethod]
        public void Node_ToString()
        {
            Node cur = new Node("First Node");
            Assert.AreEqual("First Node", cur.ToString());
        }

    }
}