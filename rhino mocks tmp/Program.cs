using NUnit.Framework;
using Rhino.Mocks;

namespace rhino_mocks_tmp
{
    class Program
    {
        private static void Main()
        {
            var foo = MockRepository.GenerateStrictMock<IFoo>();
            foo.Expect(x => x.GetValue(42)).Return("forty two");

            var value = foo.GetValue(42);
            
            Assert.AreEqual("forty two", value);
            foo.VerifyAllExpectations();
        }
    }

    public interface IFoo
    {
        string GetValue(int number);
    }
}
