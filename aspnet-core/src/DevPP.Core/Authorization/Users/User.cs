using System;
using System.ComponentModel.DataAnnotations;
using Abp.Authorization.Users;
using Abp.Extensions;

namespace DevPP.Authorization.Users
{
    public class User : AbpUser<User>
    {
        public const string DefaultPassword = "123qwe";

		public const int MaxLongString = 500;
		public const int MaxMediumString = 256;
		public const int MaxShortString = 30;

		[StringLength(MaxLongString)]
		public string MiniBio { get; set; }

		[StringLength(MaxLongString)]
		public string LastPresentationUrl { get; set; }

		[StringLength(MaxMediumString)]
		public string Title { get; set; }

		[StringLength(MaxMediumString)]
		public string Site { get; set; }

		[StringLength(MaxShortString)]
		public string WhatsApp { get; set; }

		public static string CreateRandomPassword()
        {
            return Guid.NewGuid().ToString("N").Truncate(16);
        }

        public static User CreateTenantAdminUser(int tenantId, string emailAddress)
        {
            var user = new User
            {
                TenantId = tenantId,
                UserName = AdminUserName,
                Name = AdminUserName,
                Surname = AdminUserName,
                EmailAddress = emailAddress
            };

            user.SetNormalizedNames();

            return user;
        }
    }
}
