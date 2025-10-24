using InvestOnIdeas.Dtos;
using InvestOnIdeas.Models;
using InvestOnIdeas.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using InvestOnIdeas.Dtos;
using System.IdentityModel.Tokens.Jwt;


namespace InvestOnIdeas.Services
{
    internal class AuthService
    {
        private readonly HttpClient _httpClient;

        public AuthService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<UserModel> GetLogin(LoginDto loginDto)
        {
            string apiUrl = Resources.api; // Base API URL

            var content = new StringContent(JsonConvert.SerializeObject(loginDto), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync($"{apiUrl}/Auth/login", content);

            if (!response.IsSuccessStatusCode)
                return null;

            // Read API response JSON
            string responseJson = await response.Content.ReadAsStringAsync();

            // Extract token from response
            var tokenObj = JsonConvert.DeserializeObject<Dictionary<string, string>>(responseJson);
            if (!tokenObj.TryGetValue("token", out string jwtTokenString))
                return null;

            // Decode JWT claims
            var handler = new JwtSecurityTokenHandler();
            var jwtToken = handler.ReadJwtToken(jwtTokenString);

            var claimsDict = jwtToken.Claims.ToDictionary(c => c.Type, c => (object)c.Value);

            // Optionally print JSON
            string claimsJson = JsonConvert.SerializeObject(claimsDict, Formatting.Indented);
            Console.WriteLine(claimsJson);

            // Map claims to UserModel
            var user = new UserModel
            {
                UserId = claimsDict.TryGetValue("UserId", out var id) ? int.Parse(id.ToString()) : 0,
                Name = claimsDict.TryGetValue("Name", out var n) ? n.ToString() : null,
                Email = claimsDict.TryGetValue("Email", out var e) ? e.ToString() : null
            };

            return user;
        }

    }
}
