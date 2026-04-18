using Microsoft.AspNetCore.Mvc;
using Student_Inquiry_Assistance_API.Models;

namespace Student_Inquiry_Assistance_API.Services
{
    public interface IAuth
    {
        Task<IActionResult> Register([FromBody] Register register, string role);
        Task<IActionResult> Login([FromBody] Login login);
    }
}
