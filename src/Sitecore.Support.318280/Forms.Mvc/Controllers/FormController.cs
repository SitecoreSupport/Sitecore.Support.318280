using Sitecore.Forms.Mvc.Attributes;
using Sitecore.Forms.Mvc.Controllers.Filters;
using Sitecore.Forms.Mvc.Controllers.ModelBinders;
using Sitecore.Forms.Mvc.ViewModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace Sitecore.Support.Forms.Mvc.Controllers
{
  public class FormController: Sitecore.Forms.Mvc.Controllers.FormController
  {
    public override ActionResult Index([ModelBinder(typeof(FormModelBinder))] FormViewModel formViewModel)
    {
      CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
      Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

      var result = base.Index(formViewModel);

      Thread.CurrentThread.CurrentCulture = currentCulture;
      return result;
    }
  }
}