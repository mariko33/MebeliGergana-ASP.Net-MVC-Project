using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace MebeliGergana.Models.Attributes
{
  public class ValidateFileAttribute: ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            
            string[] allowedFileExtensions = new string[] { ".jpg", ".gif", ".png", ".pdf" };

            var file = value as HttpPostedFileBase;

            if (file == null)
                return false;
            else if (!allowedFileExtensions.Contains(file.FileName.Substring(file.FileName.LastIndexOf('.'))))
            {
                ErrorMessage = "Please upload Your Photo of type: " + string.Join(", ", allowedFileExtensions);
                return false;
            }
            
            else
                return true;
        }
    }
}
