using System.Collections.Generic;

namespace WATSharp.tests
{
    public class PropertyTest: WAT.Test
    {
        public override string Title()
        {
            return "Given A Collection";
        }

        [Test]
        public void WhenCallingHasValueWhenListHasValue()
        {
            var list = new List<int> {2, 4, 5};
            Assert.Contains(4, list);
        }

        [Test]
        public void WhenCallingDoesNotContainWhenListDoesNotHaveValue()
        {
            var list = new List<int> {2, 5, 9};
            Assert.DoesNotContain(100, list);
        }
    }
}