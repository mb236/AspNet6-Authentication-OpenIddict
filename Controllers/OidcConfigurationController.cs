using identity_angular.Models;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace identity_angular.Controllers;

public class OidcConfigurationController : Controller
{
    private readonly ILogger<OidcConfigurationController> _logger;

    public OidcConfigurationController(ILogger<OidcConfigurationController> logger)
    {
        _logger = logger;
    }

    //public IClientRequestParametersProvider ClientRequestParametersProvider { get; }

    [HttpGet("_configuration/{clientId}")]
    public IActionResult GetClientRequestParameters([FromRoute] string clientId)
    {
        if (clientId == "identity_angular")
        {
            var baseUrl = $"{Request.Scheme}://{Request.Host}";
            return Ok(new OidcConfiguration
            {
                Authority = baseUrl,
                ClientId = clientId,
                RedirectUri = $"{baseUrl}/authentication/login-callback",
                PostLogoutRedirectUri = $"{baseUrl}/authentication/logout-callback",
                ResponseType = "code",
                Scope = "openid profile",
                MonitorSession = true
            });
        }
        return NotFound();
    }
}
