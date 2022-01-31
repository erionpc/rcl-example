using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCLExample.Web.Configuration
{
    public class TemplatesConfiguration
    {
        public TemplateConfig[] TemplateUrls { get; set; } = Array.Empty<TemplateConfig>();
    }

    public class TemplateConfig
    {
        public string? TemplateName { get; set; }
        public string? Url { get; set; }
    }
}
