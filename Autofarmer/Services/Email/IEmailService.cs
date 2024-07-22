using Autofarmer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Autofarmer.Services.Email
{
    internal interface IEmailService
    {
        public List<Models.Email> GetEmailModels(List<string> emailStrings);

        public Models.Email GetEmailModel(List<Models.Email> emailModels);

        public Models.Email GetEmailModelFromString(string emailString);
    }
}
