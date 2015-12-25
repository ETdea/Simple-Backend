using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SimpleBackend.ViewModels
{
    public class SmtpSettingsViewModel : ICast
    {
        [DisplayName("伺服器名稱")]
        [DataType(DataType.Text)]
        public string Host { get; set; }

        [DisplayName("埠號")]
        [DataType(DataType.Text)]
        [Range(1, ushort.MaxValue)]
        public ushort Port { get; set; }

        [DisplayName("寄件人")]
        [DataType(DataType.Text)]
        public string From { get; set; }

        [DisplayName("使用SSL")]
        public bool EnableSsl { get; set; }

        [DisplayName("驗證")]
        public bool DefaultCredentials { get; set; }

        [DisplayName("使用者名稱")]
        [DataType(DataType.Text)]
        public string UserName { get; set; }

        [DisplayName("密碼")]
        [DataType(DataType.Text)]
        public string Password { get; set; }
    }
}