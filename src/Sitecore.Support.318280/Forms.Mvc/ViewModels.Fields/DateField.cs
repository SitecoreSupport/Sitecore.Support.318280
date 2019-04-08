using System;
using System.Collections.Generic;
using Sitecore.Forms.Mvc.Attributes;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;

namespace Sitecore.Support.Forms.Mvc.ViewModels.Fields
{
  public class DateField: Sitecore.Forms.Mvc.ViewModels.Fields.DateField
  {
    public override void Initialize()
    {
      CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
      Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

      base.Initialize();

      Thread.CurrentThread.CurrentCulture = currentCulture;

    }

    [ParameterName("SelectedDate")]
    public override string Value
    {
      get
      {
        return base.Value;
      }
      set
      {

        CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        base.Value = value;

        Thread.CurrentThread.CurrentCulture = currentCulture;
      }
    }
  }
}