using System.Web;
using System.Web.Mvc;

namespace CST356_Lab1_CastonYoung
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}
