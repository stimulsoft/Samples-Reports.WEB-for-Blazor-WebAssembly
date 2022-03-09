using System;
using System.Linq;
using Stimulsoft.Data.Extensions;

namespace CustomFunctionsLibrary
{
    public class CustomFunction
    {
		public static decimal MySum(object value)
		{
			if (!ListExt.IsList(value))
				return Stimulsoft.Base.Helpers.StiValueHelper.TryToDecimal(value);

			return Stimulsoft.Data.Functions.Funcs.SkipNulls(ListExt.ToList(value))
				.TryCastToDecimal()
				.Sum();
		}
	}
}
