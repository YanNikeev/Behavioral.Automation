using Behavioral.Automation.Elements;
using Behavioral.Automation.Model;
using System;

namespace Behavioral.Automation.FluentAssertions.Abstractions
{
    public interface IAssertionBuilderWithInversion
    {
        IAssertionBuilder Be<TVal>(Func<IWebElementWrapper, TVal> valueAcessor, Func<TVal, TVal, bool> comparer, TVal value, string message);
        IAssertionBuilder Be<T>(AssertionObject<T> assertion);
        IAssertionBuilder Become<TVal>(Func<IWebElementWrapper, TVal> valueAcessor, Func<TVal, TVal, bool> comparer, TVal value, string message);
        IAssertionBuilder Become<T>(AssertionObject<T> assertion);
    }
}
