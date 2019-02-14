using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;

namespace Blog.Filter
{
    public class AutorizacaoFilterAttribute : ActionFilterAttribute
    {

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string logado = filterContext.HttpContext.Session.GetString("usuario");
            
            //string logado = filterContext.HttpContext.Session["usuario"]

            if (logado == null)
            {
                filterContext.Result = new RedirectToRouteResult(
                    new RouteValueDictionary(
                        new
                        {
                            area = "",
                            controller = "Usuario",
                            action = "Login"
                        }));
            }
        }
    }
}
