using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Mvp.Feature.Reviews.Services;
using Sitecore.AspNet.RenderingEngine;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mvp.Feature.Reviews.Rendering.Components
{
    public class ApplicationDetailViewComponent : ViewComponent
    {
        public ApplicationDetailViewComponent()
        {

        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
