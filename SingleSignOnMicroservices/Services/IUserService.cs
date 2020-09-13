using SingleSignOnMicroservices.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleSignOnMicroservices.Services
{
    public interface IUserService
    {
        Task<UserManagerResponse> LoginUserAsync(LoginBindingModel model);
    }

    public class UserManagerResponse
    {
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
        public IEnumerable<string> Errors { get; set; }
        public DateTime? ExpireDate { get; set; }
    }
}
