using Microsoft.AspNetCore.Http;
using System.Text.Json;

namespace practice_C_.Areas.code
{
    public class SessionHelper
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public SessionHelper(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public void SetSession(UserSession session)
        {
            var serializedSession = JsonSerializer.Serialize(session);
            _httpContextAccessor.HttpContext.Session.SetString("loginSession", serializedSession);
        }

        public UserSession GetSession()
        {
            var serializedSession = _httpContextAccessor.HttpContext.Session.GetString("loginSession");
            return serializedSession == null ? null : JsonSerializer.Deserialize<UserSession>(serializedSession);
        }
    }
}
