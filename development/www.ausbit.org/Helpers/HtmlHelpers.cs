using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
 
namespace www.ausbit.org.Helpers
{
    public static class HtmlHelpers
    {
        public static MvcHtmlString NewlineToBr(this HtmlHelper helper, string input)
        {
            var result = string.Join(
                "<br/>",
                input
                    .Split(new[] { Environment.NewLine }, StringSplitOptions.None)
                    .Select(x => HttpUtility.HtmlEncode(x))
            );
            return MvcHtmlString.Create(result);
        }
    }
}