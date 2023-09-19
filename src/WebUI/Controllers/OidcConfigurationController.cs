using Microsoft.AspNetCore.Mvc;

namespace Final.WebUI.Controllers;

[ApiExplorerSettings(IgnoreApi = true)]
public class OidcConfigurationController : Controller
{
    private readonly ILogger<OidcConfigurationController> _logger;

    public OidcConfigurationController(
        ILogger<OidcConfigurationController> logger)
    {
        _logger = logger;
    }


}
