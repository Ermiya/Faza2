using Bitspco.Framework.Common.Exceptions;
using Bitspco.Framework.Common.Exceptions.Validations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Faza.Treasury.Shared.Models
{
    public class BankChangeDto : BaseChangeDto
    {
        public string Name { get; set; }
        public bool Status { get; set; }

        public ValidationException Validate()
        {
            var ex = new ValidationException();
            if (string.IsNullOrEmpty(Name)) ex.InnerExceptions.Add(new RequiredException() { FieldName = "Name" });
            return ex;
        }
    }
}
