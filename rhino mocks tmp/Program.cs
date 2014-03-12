using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Rhino.Mocks;
using Rhino.Mocks.MethodRecorders;

namespace rhino_mocks_tmp
{
    class Program
    {
        private static void Main(string[] args)
        {
    var foo = MockRepository.GenerateMock<IFoo>();
    foo.Expect(x => x.GetValue(42)).Return("forty two");

    // in real test, this would call the tested method
    var value = foo.GetValue(42);

    Assert.AreEqual("forty two", value);
        }
    }

    public interface IFoo
    {
        string GetValue(int number);
        string GetValue2(int number);

        string Name { get; set; }
    }
}
